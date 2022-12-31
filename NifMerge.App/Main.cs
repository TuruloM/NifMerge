/*
NifMerge - Application to merge NPC's FaceGen NIF files
See the included GPLv3 LICENSE file
*/

using System;
using System.Linq;
using System.Windows.Forms;

namespace NifMerge.App
{
    public partial class Main : Form
    {
        NifMergeLib.NifFileInfo left = new NifMergeLib.NifFileInfo();
        NifMergeLib.NifFileInfo right = new NifMergeLib.NifFileInfo();
        const string no_source = "(no source)";

        public Main()
        {
            InitializeComponent();

            Text = "Merge NPC Face Models (SE Edition)";

            targetGrid.DataError += (o, e) => e.Cancel = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
#if DEBUG
            string left = Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\NifMerge", "LeftFile", "") as string;
            if (!string.IsNullOrEmpty(left))
                OpenLeft(left);
            string right = Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\NifMerge", "RightFile", "") as string;
            if (!string.IsNullOrEmpty(right))
                OpenRight(right);
#endif
        }

        private void Grid_DragDrop(object sender, DragEventArgs e)
        {
            // Obtain the filename from the drop'd element
            string filename = null;
            try
            {
                if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                {
                    var data = e.Data.GetData(DataFormats.FileDrop) as string[];
                    if (data != null)
                    {
                        if (data.Length == 1)
                        {
                            var path = data[0];
                            if (!string.IsNullOrEmpty(path))
                            {
                                var extension = System.IO.Path.GetExtension(path);
                                extension = extension.ToLower();
                                if (extension == ".nif")
									filename = path;
                            }
                        }
                    }
                }
            }
            catch
			{
                // Do nothing, the dropped element was not a valid file
            }

            // Open the .NIF file in the grid
            if (!string.IsNullOrEmpty(filename))
            {
                if (sender == sourceGrid)
                    OpenLeft(filename);

                if (sender == targetGrid)
                    OpenRight(filename);
            }
        }

        private void OpenLeft(string filename)
        {
            if (right != null)
            {
                foreach (var block in right.Blocks)
                {
                    block.Merge = false;
                    block.Source = no_source;
                }
                targetGrid.Refresh();
            }

            sourceGrid.DataSource = null;
            left.Dispose();
            left = new NifMergeLib.NifFileInfo();
            left.Open(filename);
            sourcePath.Text = filename;
            sourceGrid.DataSource = left.Blocks;
            sourceGrid.Columns["Source"].Visible = false;
            sourceGrid.Columns["Merge"].Visible = false;
            sourceGrid.AutoResizeColumns();

            UpdateTargetSourceColumn();

#if DEBUG
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\NifMerge", "LeftFile", filename);
#endif
        }

        private void OpenRight(string filename)
        {
            targetGrid.DataSource = null;
            right.Dispose();
            right = new NifMergeLib.NifFileInfo();
            right.Open(filename);
            targetPath.Text = filename;
            targetGrid.DataSource = right.Blocks;
            targetGrid.AutoResizeColumns();
            targetGrid.Columns["Merge"].DisplayIndex = 0;

            targetGrid.Columns.Remove("Source");
            var sourceColumn = new DataGridViewComboBoxColumn();
            sourceColumn.HeaderText = "Source";
            sourceColumn.Name = "Source";
            sourceColumn.Width = 80;
            sourceColumn.DataPropertyName = "Source";
            // sourceColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            targetGrid.Columns.Add(sourceColumn);
            targetGrid.Columns["Source"].DisplayIndex = 1;

            foreach (var block in right.Blocks)
                block.Source = no_source;

            UpdateTargetSourceColumn();

#if DEBUG
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\NifMerge", "RightFile", filename);
#endif
        }

        private void UpdateTargetSourceColumn()
        {
            var column = targetGrid.Columns["Source"] as DataGridViewComboBoxColumn;
            if (column != null)
            {
                column.Items.Clear();
                column.Items.Add(no_source);
                foreach (var block in left.Blocks)
                    column.Items.Add(block.Name);
                targetGrid.AutoResizeColumns();
            }
        }

        private void Grid_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Copy;

        private void MatchByVertex(object sender, EventArgs e)
        {
            foreach (var right_part in right.Blocks)
            {
                right_part.Merge = false;
                right_part.Source = no_source;
                foreach (var left_part in left.Blocks)
                {
                    if (left_part.Vertices == right_part.Vertices)
                    {
                        right_part.Source = left_part.Name;
                        right_part.Merge = true;
                        break;
                    }
                }
            }
            targetGrid.Refresh();
            targetGrid.AutoResizeColumns();
        }

        private void MergeToTarget(object sender, EventArgs e)
        {

        }

        private void MergeAs(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "NIF files (*.nif)|*.nif|All files (*.*)|*.*";
            if (dialog.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(dialog.FileName))
                return;

            foreach (var block in right.Blocks)
            {
                if (block.Merge && !string.IsNullOrEmpty(block.Source) && block.Source != no_source)
                {
                    var source = left.Blocks.FirstOrDefault(b => b.Name == block.Source);
                    if (source != null)
                    {
                        right.MergeBlock(block, left, source);
                        //block.MergeFrom(source);
                    }
                }
            }

            right.Save(dialog.FileName);
        }

        private void showLeft_Click(object sender, EventArgs e)
        {
            if (left != null && System.IO.File.Exists(left.FileName))
                System.Diagnostics.Process.Start(left.FileName);
        }

        private void showRight_Click(object sender, EventArgs e)
        {
            if (right != null && System.IO.File.Exists(right.FileName))
                System.Diagnostics.Process.Start(right.FileName);
        }
    }
}