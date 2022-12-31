/*
NifMerge - Application to merge NPC's FaceGen NIF files
See the included GPLv3 LICENSE file
*/

#pragma once

#include <iostream>
#include <vector>
#include <set>

#include <msclr\marshal_cppstd.h>

#if _DEBUG
#pragma comment(lib, "../../nifly/build/src/debug/nifly.lib")	// "../nifly/bin/debug/nifly.lib"
#else
#pragma comment(lib, "../../nifly/build/src/release/nifly.lib")	// "../nifly/bin/release/nifly.lib"
#endif

#include "../nifly/include/NifFile.hpp"

using namespace std;
using namespace nifly;

using namespace System;
using namespace System::Collections::Generic;

namespace NifMergeLib
{
	public ref class NifHeadPart : System::ComponentModel::INotifyPropertyChanged
	{
		String^ _name;
		String^ _source;
		Boolean _merge;
		int _vertexCount = 0;
		uint32_t _id;
		BSDynamicTriShape* _block;

	public:
		NifHeadPart(uint32_t id, BSDynamicTriShape* block)
		{
			_id = id;
			_name = gcnew String(block->name.get().c_str());
			_vertexCount = (int)block->vertData.size();
			_block = block;
		}

		property String^ Name { String^ get() { return _name; } }

		property String^ Source
		{
			String^ get() { return _source; }
			void set(String^ value)
			{
				_merge = false;
				_source = value;
				PropertyChanged(this, gcnew System::ComponentModel::PropertyChangedEventArgs(gcnew String(L"Source")));
			}
		}

		property Boolean Merge
		{
			Boolean get() { return _merge; }
			void set(Boolean value) 
			{
				if (!String::IsNullOrEmpty(_source))
					_merge = value;
			}
		}

		[System::ComponentModel::Browsable(false)]
		property int BlockId { int get() { return _id; } }

		property int Vertices { int get() { return _vertexCount; } }

		void MergeFrom(NifHeadPart^ source)
		{
			if (_vertexCount == source->_block->GetNumVertices())
			{
				for (uint32_t vt = 0; vt < source->_block->vertData.size(); vt++)
					_block->vertData[vt] = source->_block->vertData[vt];
			}
			else
			{
				_block->vertData = source->_block->vertData;
			}
		}

		virtual event System::ComponentModel::PropertyChangedEventHandler^ PropertyChanged;
	};

	public ref class NifFileInfo : IDisposable
	{
		List<NifHeadPart^>^ _blocks = gcnew List<NifHeadPart^>();
		NifFile* file = nullptr;
		String^ fileName;

	public:

		~NifFileInfo()
		{
			if (file != nullptr)
				delete file;
		}

		property List<NifHeadPart^>^ Blocks { List<NifHeadPart^>^ get() { return _blocks; } }

		property String^ FileName { String^ get() { return fileName; } }

		void Open(String^ filename)
		{
			fileName = filename;
			file = new NifFile();
			file->Load(msclr::interop::marshal_as<string>(filename));
			auto blockcount = file->GetHeader().GetNumBlocks();

			for (uint32_t id = 0; id < blockcount; id++)
			{
				auto block = file->GetHeader().GetBlock<BSDynamicTriShape>(id);
				if (block != nullptr)
				{
					Blocks->Add(gcnew NifHeadPart(id, block));
				}
			}
		}

		void Save(String^ filename)
		{
			if (file != nullptr)
				file->Save(msclr::interop::marshal_as<string>(filename));
		}

		void MergeBlock(NifHeadPart^ target_part, NifFileInfo^ source_file, NifHeadPart^ source_part)
		{
			if (target_part->Vertices == source_part->Vertices)
				target_part->MergeFrom(source_part);
			else
			{
				return;
				auto target = file->GetHeader().GetBlock<NiTriShape>(target_part->BlockId);
				auto source = source_file->file->GetHeader().GetBlock<NiTriShape>(source_part->BlockId);
				if (source != nullptr && target != nullptr)
				{
					auto g1 = source->GetGeomData();
					auto g2 = target->GetGeomData();
					if (g1 != nullptr && g2 != nullptr && g1->vertices.size() == g2->vertices.size())
					{
						target->SetGeomData(source->GetGeomData());
					}
					else
					{
						file->CloneChildren(source, source_file->file);
						file->GetHeader().ReplaceBlock(target_part->BlockId, source->Clone());
					}
				}
			}
		}
	};
}
