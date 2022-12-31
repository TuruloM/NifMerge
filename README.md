# NifMerge
Application used to merge NPC FaceGen .nif files.

The application was created to help creating custom NPCs using the RaceMenu + CharGen Extension mods from Expired. It will only automate the task of transferring the blocks from one .NIF file to another.

It requires some knowledge about how .NIF files work, and all this tool does can also be done with NifSkope, so I encourage you to use that tool if you need further customizations and also to check if the resulting files work correctly.

This iteration of NifMerge uses nifly (https://github.com/ousnius/nifly) library developed by ousnius.

Disclaimer: Use this application at your own risk, if instructed it will overwrite files so backup files manually before using this tool.

IMPORTANT: This application is not finished! It only implements merging of nodes/blocks that have the same vertex count.

### Building
- Clone nifly and NifMerge and place each repository at the same level
- Build nifly in release and debug (C++ 17 required)
- Build NifMerge

### Libraries used
- [nifly](https://github.com/ousnius/nifly) for reading and writing .nif files.

### Credits
- [Turulo](https://github.com/TuruloM)
- [ousnius for nifly](https://github.com/ousnius)