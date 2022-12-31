
namespace NifMerge.App
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkNoSafeVertexCopy = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.sourceGroupBox = new System.Windows.Forms.GroupBox();
            this.sourceGrid = new System.Windows.Forms.DataGridView();
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.targetGroupBox = new System.Windows.Forms.GroupBox();
            this.targetGrid = new System.Windows.Forms.DataGridView();
            this.targetPath = new System.Windows.Forms.TextBox();
            this.mergeAsCommand = new System.Windows.Forms.Button();
            this.mergeCommand = new System.Windows.Forms.Button();
            this.matchByVertexCommand = new System.Windows.Forms.Button();
            this.showLeft = new System.Windows.Forms.Button();
            this.showRight = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.sourceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceGrid)).BeginInit();
            this.targetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // chkNoSafeVertexCopy
            // 
            this.chkNoSafeVertexCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkNoSafeVertexCopy.AutoSize = true;
            this.chkNoSafeVertexCopy.Enabled = false;
            this.chkNoSafeVertexCopy.Location = new System.Drawing.Point(18, 383);
            this.chkNoSafeVertexCopy.Name = "chkNoSafeVertexCopy";
            this.chkNoSafeVertexCopy.Size = new System.Drawing.Size(116, 17);
            this.chkNoSafeVertexCopy.TabIndex = 8;
            this.chkNoSafeVertexCopy.Text = "Merge Child Nodes";
            this.chkNoSafeVertexCopy.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(310, 17);
            this.statusLabel.Text = "Drag && drop .NIF files to define the source and target files";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(12, 6);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.sourceGroupBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.targetGroupBox);
            this.splitContainer.Size = new System.Drawing.Size(760, 362);
            this.splitContainer.SplitterDistance = 306;
            this.splitContainer.TabIndex = 12;
            // 
            // sourceGroupBox
            // 
            this.sourceGroupBox.Controls.Add(this.showLeft);
            this.sourceGroupBox.Controls.Add(this.sourceGrid);
            this.sourceGroupBox.Controls.Add(this.sourcePath);
            this.sourceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceGroupBox.Location = new System.Drawing.Point(0, 0);
            this.sourceGroupBox.Name = "sourceGroupBox";
            this.sourceGroupBox.Size = new System.Drawing.Size(306, 362);
            this.sourceGroupBox.TabIndex = 4;
            this.sourceGroupBox.TabStop = false;
            this.sourceGroupBox.Text = "Source NPC Face Model:";
            // 
            // sourceGrid
            // 
            this.sourceGrid.AllowDrop = true;
            this.sourceGrid.AllowUserToAddRows = false;
            this.sourceGrid.AllowUserToDeleteRows = false;
            this.sourceGrid.AllowUserToResizeRows = false;
            this.sourceGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.sourceGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sourceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sourceGrid.Location = new System.Drawing.Point(6, 45);
            this.sourceGrid.Name = "sourceGrid";
            this.sourceGrid.RowHeadersVisible = false;
            this.sourceGrid.Size = new System.Drawing.Size(294, 311);
            this.sourceGrid.TabIndex = 1;
            this.sourceGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.Grid_DragDrop);
            this.sourceGrid.DragEnter += new System.Windows.Forms.DragEventHandler(this.Grid_DragEnter);
            // 
            // sourcePath
            // 
            this.sourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourcePath.BackColor = System.Drawing.SystemColors.Menu;
            this.sourcePath.Enabled = false;
            this.sourcePath.Location = new System.Drawing.Point(6, 19);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.Size = new System.Drawing.Size(265, 20);
            this.sourcePath.TabIndex = 2;
            // 
            // targetGroupBox
            // 
            this.targetGroupBox.Controls.Add(this.showRight);
            this.targetGroupBox.Controls.Add(this.targetGrid);
            this.targetGroupBox.Controls.Add(this.targetPath);
            this.targetGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetGroupBox.Location = new System.Drawing.Point(0, 0);
            this.targetGroupBox.Name = "targetGroupBox";
            this.targetGroupBox.Size = new System.Drawing.Size(450, 362);
            this.targetGroupBox.TabIndex = 4;
            this.targetGroupBox.TabStop = false;
            this.targetGroupBox.Text = "Target NPC Face Model:";
            // 
            // targetGrid
            // 
            this.targetGrid.AllowDrop = true;
            this.targetGrid.AllowUserToAddRows = false;
            this.targetGrid.AllowUserToDeleteRows = false;
            this.targetGrid.AllowUserToResizeRows = false;
            this.targetGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.targetGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.targetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.targetGrid.Location = new System.Drawing.Point(6, 45);
            this.targetGrid.Name = "targetGrid";
            this.targetGrid.RowHeadersVisible = false;
            this.targetGrid.Size = new System.Drawing.Size(438, 311);
            this.targetGrid.TabIndex = 0;
            this.targetGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.Grid_DragDrop);
            this.targetGrid.DragEnter += new System.Windows.Forms.DragEventHandler(this.Grid_DragEnter);
            // 
            // targetPath
            // 
            this.targetPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetPath.BackColor = System.Drawing.SystemColors.Menu;
            this.targetPath.Enabled = false;
            this.targetPath.Location = new System.Drawing.Point(6, 19);
            this.targetPath.Name = "targetPath";
            this.targetPath.Size = new System.Drawing.Size(408, 20);
            this.targetPath.TabIndex = 2;
            // 
            // mergeAsCommand
            // 
            this.mergeAsCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mergeAsCommand.Location = new System.Drawing.Point(662, 379);
            this.mergeAsCommand.Name = "mergeAsCommand";
            this.mergeAsCommand.Size = new System.Drawing.Size(110, 23);
            this.mergeAsCommand.TabIndex = 9;
            this.mergeAsCommand.Text = "Merge Model As...";
            this.mergeAsCommand.UseVisualStyleBackColor = true;
            this.mergeAsCommand.Click += new System.EventHandler(this.MergeAs);
            // 
            // mergeCommand
            // 
            this.mergeCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mergeCommand.Enabled = false;
            this.mergeCommand.Location = new System.Drawing.Point(430, 379);
            this.mergeCommand.Name = "mergeCommand";
            this.mergeCommand.Size = new System.Drawing.Size(110, 23);
            this.mergeCommand.TabIndex = 10;
            this.mergeCommand.Text = "Merge to Target";
            this.mergeCommand.UseVisualStyleBackColor = true;
            this.mergeCommand.Click += new System.EventHandler(this.MergeToTarget);
            // 
            // matchByVertexCommand
            // 
            this.matchByVertexCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.matchByVertexCommand.Location = new System.Drawing.Point(546, 379);
            this.matchByVertexCommand.Name = "matchByVertexCommand";
            this.matchByVertexCommand.Size = new System.Drawing.Size(110, 23);
            this.matchByVertexCommand.TabIndex = 11;
            this.matchByVertexCommand.Text = "Match by Vertex";
            this.matchByVertexCommand.UseVisualStyleBackColor = true;
            this.matchByVertexCommand.Click += new System.EventHandler(this.MatchByVertex);
            // 
            // showLeft
            // 
            this.showLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showLeft.Location = new System.Drawing.Point(277, 18);
            this.showLeft.Name = "showLeft";
            this.showLeft.Size = new System.Drawing.Size(24, 22);
            this.showLeft.TabIndex = 3;
            this.showLeft.Text = "...";
            this.showLeft.UseVisualStyleBackColor = true;
            this.showLeft.Click += new System.EventHandler(this.showLeft_Click);
            // 
            // showRight
            // 
            this.showRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showRight.Location = new System.Drawing.Point(420, 18);
            this.showRight.Name = "showRight";
            this.showRight.Size = new System.Drawing.Size(24, 22);
            this.showRight.TabIndex = 4;
            this.showRight.Text = "...";
            this.showRight.UseVisualStyleBackColor = true;
            this.showRight.Click += new System.EventHandler(this.showRight_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(784, 432);
            this.Controls.Add(this.chkNoSafeVertexCopy);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.mergeAsCommand);
            this.Controls.Add(this.mergeCommand);
            this.Controls.Add(this.matchByVertexCommand);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.sourceGroupBox.ResumeLayout(false);
            this.sourceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceGrid)).EndInit();
            this.targetGroupBox.ResumeLayout(false);
            this.targetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkNoSafeVertexCopy;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox sourceGroupBox;
        private System.Windows.Forms.DataGridView sourceGrid;
        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.GroupBox targetGroupBox;
        private System.Windows.Forms.DataGridView targetGrid;
        private System.Windows.Forms.TextBox targetPath;
        private System.Windows.Forms.Button mergeAsCommand;
        private System.Windows.Forms.Button mergeCommand;
        private System.Windows.Forms.Button matchByVertexCommand;
        private System.Windows.Forms.Button showLeft;
        private System.Windows.Forms.Button showRight;
    }
}

