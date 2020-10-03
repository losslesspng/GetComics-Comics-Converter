namespace GetComics_Comics_Converter
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statProgress = new System.Windows.Forms.StatusStrip();
            this.tslblTotalProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbTotalProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tslblCurrentProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbCurrentProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.cbContainersCBZ = new System.Windows.Forms.CheckBox();
            this.lblSourceFiles = new System.Windows.Forms.Label();
            this.cbContainersCBR = new System.Windows.Forms.CheckBox();
            this.cbContainersOther = new System.Windows.Forms.CheckBox();
            this.txtContainersOther = new System.Windows.Forms.TextBox();
            this.dgComicList = new System.Windows.Forms.DataGridView();
            this.lblCompressionType = new System.Windows.Forms.Label();
            this.cbCompressionType = new System.Windows.Forms.ComboBox();
            this.chbxProcess = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOutputContainer = new System.Windows.Forms.Label();
            this.cbOutputType = new System.Windows.Forms.ComboBox();
            this.tslblItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblCurrentItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblOf = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblTotalItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbWebpCompressionLevel = new System.Windows.Forms.CheckBox();
            this.txtWebpCompressionLevel = new System.Windows.Forms.TextBox();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.lblFileTypes = new System.Windows.Forms.Label();
            this.cbJPG = new System.Windows.Forms.CheckBox();
            this.cbJPEG = new System.Windows.Forms.CheckBox();
            this.cbPNG = new System.Windows.Forms.CheckBox();
            this.cbGIF = new System.Windows.Forms.CheckBox();
            this.cbOtherFilesTypes = new System.Windows.Forms.CheckBox();
            this.txtOtherFilesToConvert = new System.Windows.Forms.TextBox();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.tipToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.statProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgComicList)).BeginInit();
            this.SuspendLayout();
            // 
            // statProgress
            // 
            this.statProgress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblTotalProgress,
            this.tspbTotalProgress,
            this.tslblCurrentProgress,
            this.tspbCurrentProgress,
            this.tslblItem,
            this.tslblCurrentItem,
            this.tslblOf,
            this.tslblTotalItems});
            this.statProgress.Location = new System.Drawing.Point(0, 494);
            this.statProgress.Name = "statProgress";
            this.statProgress.Size = new System.Drawing.Size(730, 22);
            this.statProgress.TabIndex = 0;
            this.statProgress.Text = "statusStrip1";
            // 
            // tslblTotalProgress
            // 
            this.tslblTotalProgress.Name = "tslblTotalProgress";
            this.tslblTotalProgress.Size = new System.Drawing.Size(104, 17);
            this.tslblTotalProgress.Text = "Total Job Progress:";
            // 
            // tspbTotalProgress
            // 
            this.tspbTotalProgress.Name = "tspbTotalProgress";
            this.tspbTotalProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // tslblCurrentProgress
            // 
            this.tslblCurrentProgress.Name = "tslblCurrentProgress";
            this.tslblCurrentProgress.Size = new System.Drawing.Size(119, 17);
            this.tslblCurrentProgress.Text = "Current File Progress:";
            // 
            // tspbCurrentProgress
            // 
            this.tspbCurrentProgress.Name = "tspbCurrentProgress";
            this.tspbCurrentProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // cbContainersCBZ
            // 
            this.cbContainersCBZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbContainersCBZ.AutoSize = true;
            this.cbContainersCBZ.Checked = true;
            this.cbContainersCBZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContainersCBZ.Location = new System.Drawing.Point(86, 8);
            this.cbContainersCBZ.Name = "cbContainersCBZ";
            this.cbContainersCBZ.Size = new System.Drawing.Size(47, 17);
            this.cbContainersCBZ.TabIndex = 1;
            this.cbContainersCBZ.Text = "CBZ";
            this.cbContainersCBZ.UseVisualStyleBackColor = true;
            // 
            // lblSourceFiles
            // 
            this.lblSourceFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSourceFiles.AutoSize = true;
            this.lblSourceFiles.Location = new System.Drawing.Point(12, 9);
            this.lblSourceFiles.Name = "lblSourceFiles";
            this.lblSourceFiles.Size = new System.Drawing.Size(68, 13);
            this.lblSourceFiles.TabIndex = 2;
            this.lblSourceFiles.Text = "Source Files:";
            this.tipToolTips.SetToolTip(this.lblSourceFiles, "Select and/or specify what input formats to look for. Popular other formats inclu" +
        "de CB7, CBT, and PDF, though an attempt will be made to convert any files you li" +
        "st here.");
            // 
            // cbContainersCBR
            // 
            this.cbContainersCBR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbContainersCBR.AutoSize = true;
            this.cbContainersCBR.Checked = true;
            this.cbContainersCBR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContainersCBR.Location = new System.Drawing.Point(139, 8);
            this.cbContainersCBR.Name = "cbContainersCBR";
            this.cbContainersCBR.Size = new System.Drawing.Size(48, 17);
            this.cbContainersCBR.TabIndex = 3;
            this.cbContainersCBR.Text = "CBR";
            this.cbContainersCBR.UseVisualStyleBackColor = true;
            // 
            // cbContainersOther
            // 
            this.cbContainersOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbContainersOther.AutoSize = true;
            this.cbContainersOther.Location = new System.Drawing.Point(193, 8);
            this.cbContainersOther.Name = "cbContainersOther";
            this.cbContainersOther.Size = new System.Drawing.Size(55, 17);
            this.cbContainersOther.TabIndex = 4;
            this.cbContainersOther.Text = "Other:";
            this.cbContainersOther.UseVisualStyleBackColor = true;
            this.cbContainersOther.CheckedChanged += new System.EventHandler(this.cbContainersOther_CheckedChanged);
            // 
            // txtContainersOther
            // 
            this.txtContainersOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContainersOther.Enabled = false;
            this.txtContainersOther.Location = new System.Drawing.Point(254, 6);
            this.txtContainersOther.Name = "txtContainersOther";
            this.txtContainersOther.Size = new System.Drawing.Size(166, 20);
            this.txtContainersOther.TabIndex = 5;
            // 
            // dgComicList
            // 
            this.dgComicList.AllowDrop = true;
            this.dgComicList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgComicList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgComicList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chbxProcess,
            this.txtFilePath});
            this.dgComicList.Location = new System.Drawing.Point(12, 31);
            this.dgComicList.Name = "dgComicList";
            this.dgComicList.RowHeadersVisible = false;
            this.dgComicList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgComicList.Size = new System.Drawing.Size(708, 341);
            this.dgComicList.TabIndex = 7;
            // 
            // lblCompressionType
            // 
            this.lblCompressionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompressionType.AutoSize = true;
            this.lblCompressionType.Location = new System.Drawing.Point(426, 9);
            this.lblCompressionType.Name = "lblCompressionType";
            this.lblCompressionType.Size = new System.Drawing.Size(97, 13);
            this.lblCompressionType.TabIndex = 8;
            this.lblCompressionType.Text = "Compression Type:";
            // 
            // cbCompressionType
            // 
            this.cbCompressionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCompressionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompressionType.FormattingEnabled = true;
            this.cbCompressionType.Items.AddRange(new object[] {
            "Default (zip)",
            "gzip",
            "bzip2",
            "tar",
            "7z"});
            this.cbCompressionType.Location = new System.Drawing.Point(529, 6);
            this.cbCompressionType.Name = "cbCompressionType";
            this.cbCompressionType.Size = new System.Drawing.Size(83, 21);
            this.cbCompressionType.TabIndex = 9;
            // 
            // chbxProcess
            // 
            this.chbxProcess.FillWeight = 20.30457F;
            this.chbxProcess.HeaderText = "Process";
            this.chbxProcess.Name = "chbxProcess";
            this.chbxProcess.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chbxProcess.Width = 71;
            // 
            // txtFilePath
            // 
            this.txtFilePath.FillWeight = 179.6955F;
            this.txtFilePath.HeaderText = "File path";
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Width = 634;
            // 
            // lblOutputContainer
            // 
            this.lblOutputContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutputContainer.AutoSize = true;
            this.lblOutputContainer.Location = new System.Drawing.Point(618, 9);
            this.lblOutputContainer.Name = "lblOutputContainer";
            this.lblOutputContainer.Size = new System.Drawing.Size(50, 13);
            this.lblOutputContainer.TabIndex = 10;
            this.lblOutputContainer.Text = "Save As:";
            // 
            // cbOutputType
            // 
            this.cbOutputType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOutputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutputType.FormattingEnabled = true;
            this.cbOutputType.Items.AddRange(new object[] {
            "CBZ",
            "CBR",
            "CBT",
            "CB7"});
            this.cbOutputType.Location = new System.Drawing.Point(674, 6);
            this.cbOutputType.Name = "cbOutputType";
            this.cbOutputType.Size = new System.Drawing.Size(46, 21);
            this.cbOutputType.TabIndex = 11;
            // 
            // tslblItem
            // 
            this.tslblItem.Name = "tslblItem";
            this.tslblItem.Size = new System.Drawing.Size(34, 17);
            this.tslblItem.Text = "Item:";
            // 
            // tslblCurrentItem
            // 
            this.tslblCurrentItem.Name = "tslblCurrentItem";
            this.tslblCurrentItem.Size = new System.Drawing.Size(13, 17);
            this.tslblCurrentItem.Text = "0";
            // 
            // tslblOf
            // 
            this.tslblOf.Name = "tslblOf";
            this.tslblOf.Size = new System.Drawing.Size(12, 17);
            this.tslblOf.Text = "/";
            // 
            // tslblTotalItems
            // 
            this.tslblTotalItems.Name = "tslblTotalItems";
            this.tslblTotalItems.Size = new System.Drawing.Size(13, 17);
            this.tslblTotalItems.Text = "0";
            // 
            // cbWebpCompressionLevel
            // 
            this.cbWebpCompressionLevel.AutoSize = true;
            this.cbWebpCompressionLevel.Location = new System.Drawing.Point(12, 382);
            this.cbWebpCompressionLevel.Name = "cbWebpCompressionLevel";
            this.cbWebpCompressionLevel.Size = new System.Drawing.Size(151, 17);
            this.cbWebpCompressionLevel.TabIndex = 14;
            this.cbWebpCompressionLevel.Text = "WebP Compression Level:";
            this.cbWebpCompressionLevel.UseVisualStyleBackColor = true;
            this.cbWebpCompressionLevel.CheckedChanged += new System.EventHandler(this.cbWebpCompressionLevel_CheckedChanged);
            // 
            // txtWebpCompressionLevel
            // 
            this.txtWebpCompressionLevel.Enabled = false;
            this.txtWebpCompressionLevel.Location = new System.Drawing.Point(169, 380);
            this.txtWebpCompressionLevel.MaxLength = 3;
            this.txtWebpCompressionLevel.Name = "txtWebpCompressionLevel";
            this.txtWebpCompressionLevel.Size = new System.Drawing.Size(39, 20);
            this.txtWebpCompressionLevel.TabIndex = 15;
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(614, 378);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(104, 23);
            this.btnRemoveSelected.TabIndex = 16;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            // 
            // lblFileTypes
            // 
            this.lblFileTypes.AutoSize = true;
            this.lblFileTypes.Location = new System.Drawing.Point(9, 402);
            this.lblFileTypes.Name = "lblFileTypes";
            this.lblFileTypes.Size = new System.Drawing.Size(150, 13);
            this.lblFileTypes.TabIndex = 17;
            this.lblFileTypes.Text = "Look for these files to convert:";
            // 
            // cbJPG
            // 
            this.cbJPG.AutoSize = true;
            this.cbJPG.Checked = true;
            this.cbJPG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJPG.Location = new System.Drawing.Point(12, 419);
            this.cbJPG.Name = "cbJPG";
            this.cbJPG.Size = new System.Drawing.Size(47, 17);
            this.cbJPG.TabIndex = 18;
            this.cbJPG.Text = "*.jpg";
            this.cbJPG.UseVisualStyleBackColor = true;
            // 
            // cbJPEG
            // 
            this.cbJPEG.AutoSize = true;
            this.cbJPEG.Checked = true;
            this.cbJPEG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJPEG.Location = new System.Drawing.Point(12, 442);
            this.cbJPEG.Name = "cbJPEG";
            this.cbJPEG.Size = new System.Drawing.Size(53, 17);
            this.cbJPEG.TabIndex = 19;
            this.cbJPEG.Text = "*.jpeg";
            this.cbJPEG.UseVisualStyleBackColor = true;
            // 
            // cbPNG
            // 
            this.cbPNG.AutoSize = true;
            this.cbPNG.Checked = true;
            this.cbPNG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPNG.Location = new System.Drawing.Point(74, 419);
            this.cbPNG.Name = "cbPNG";
            this.cbPNG.Size = new System.Drawing.Size(51, 17);
            this.cbPNG.TabIndex = 20;
            this.cbPNG.Text = "*.png";
            this.cbPNG.UseVisualStyleBackColor = true;
            // 
            // cbGIF
            // 
            this.cbGIF.AutoSize = true;
            this.cbGIF.Checked = true;
            this.cbGIF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGIF.Location = new System.Drawing.Point(74, 442);
            this.cbGIF.Name = "cbGIF";
            this.cbGIF.Size = new System.Drawing.Size(44, 17);
            this.cbGIF.TabIndex = 21;
            this.cbGIF.Text = "*.gif";
            this.cbGIF.UseVisualStyleBackColor = true;
            // 
            // cbOtherFilesTypes
            // 
            this.cbOtherFilesTypes.AutoSize = true;
            this.cbOtherFilesTypes.Location = new System.Drawing.Point(12, 465);
            this.cbOtherFilesTypes.Name = "cbOtherFilesTypes";
            this.cbOtherFilesTypes.Size = new System.Drawing.Size(55, 17);
            this.cbOtherFilesTypes.TabIndex = 22;
            this.cbOtherFilesTypes.Text = "Other:";
            this.cbOtherFilesTypes.UseVisualStyleBackColor = true;
            // 
            // txtOtherFilesToConvert
            // 
            this.txtOtherFilesToConvert.Enabled = false;
            this.txtOtherFilesToConvert.Location = new System.Drawing.Point(73, 463);
            this.txtOtherFilesToConvert.Name = "txtOtherFilesToConvert";
            this.txtOtherFilesToConvert.Size = new System.Drawing.Size(135, 20);
            this.txtOtherFilesToConvert.TabIndex = 23;
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(614, 407);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(104, 23);
            this.btnEmpty.TabIndex = 24;
            this.btnEmpty.Text = "Empty List";
            this.btnEmpty.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(614, 436);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(104, 46);
            this.btnConvert.TabIndex = 25;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(529, 378);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 26;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(529, 407);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(75, 23);
            this.btnSelectNone.TabIndex = 27;
            this.btnSelectNone.Text = "Select None";
            this.btnSelectNone.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 516);
            this.Controls.Add(this.btnSelectNone);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.txtOtherFilesToConvert);
            this.Controls.Add(this.cbOtherFilesTypes);
            this.Controls.Add(this.cbGIF);
            this.Controls.Add(this.cbPNG);
            this.Controls.Add(this.cbJPEG);
            this.Controls.Add(this.cbJPG);
            this.Controls.Add(this.lblFileTypes);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.txtWebpCompressionLevel);
            this.Controls.Add(this.cbWebpCompressionLevel);
            this.Controls.Add(this.cbOutputType);
            this.Controls.Add(this.lblOutputContainer);
            this.Controls.Add(this.cbCompressionType);
            this.Controls.Add(this.lblCompressionType);
            this.Controls.Add(this.dgComicList);
            this.Controls.Add(this.txtContainersOther);
            this.Controls.Add(this.cbContainersOther);
            this.Controls.Add(this.cbContainersCBR);
            this.Controls.Add(this.lblSourceFiles);
            this.Controls.Add(this.cbContainersCBZ);
            this.Controls.Add(this.statProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetComics.info Comic Book Converter";
            this.statProgress.ResumeLayout(false);
            this.statProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgComicList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statProgress;
        private System.Windows.Forms.ToolStripStatusLabel tslblTotalProgress;
        private System.Windows.Forms.ToolStripProgressBar tspbTotalProgress;
        private System.Windows.Forms.ToolStripStatusLabel tslblCurrentProgress;
        private System.Windows.Forms.ToolStripProgressBar tspbCurrentProgress;
        private System.Windows.Forms.CheckBox cbContainersCBZ;
        private System.Windows.Forms.Label lblSourceFiles;
        private System.Windows.Forms.CheckBox cbContainersCBR;
        private System.Windows.Forms.CheckBox cbContainersOther;
        private System.Windows.Forms.TextBox txtContainersOther;
        private System.Windows.Forms.DataGridView dgComicList;
        private System.Windows.Forms.Label lblCompressionType;
        private System.Windows.Forms.ComboBox cbCompressionType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chbxProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFilePath;
        private System.Windows.Forms.Label lblOutputContainer;
        private System.Windows.Forms.ComboBox cbOutputType;
        private System.Windows.Forms.ToolStripStatusLabel tslblItem;
        private System.Windows.Forms.ToolStripStatusLabel tslblCurrentItem;
        private System.Windows.Forms.ToolStripStatusLabel tslblOf;
        private System.Windows.Forms.ToolStripStatusLabel tslblTotalItems;
        private System.Windows.Forms.CheckBox cbWebpCompressionLevel;
        private System.Windows.Forms.TextBox txtWebpCompressionLevel;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Label lblFileTypes;
        private System.Windows.Forms.CheckBox cbJPG;
        private System.Windows.Forms.CheckBox cbJPEG;
        private System.Windows.Forms.CheckBox cbPNG;
        private System.Windows.Forms.CheckBox cbGIF;
        private System.Windows.Forms.CheckBox cbOtherFilesTypes;
        private System.Windows.Forms.TextBox txtOtherFilesToConvert;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectNone;
        private System.Windows.Forms.ToolTip tipToolTips;
    }
}

