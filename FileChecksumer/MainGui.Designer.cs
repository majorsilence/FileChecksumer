namespace FileChecksumer
{
    partial class MainGui
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileChecksum = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCheckSumFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboHashType = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadComparisonFile = new System.Windows.Forms.Button();
            this.txtOrigFile = new System.Windows.Forms.TextBox();
            this.saveFileDialogChecksum = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogFile = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogChecksum = new System.Windows.Forms.OpenFileDialog();
            this.btnCompare = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filename:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File checksum:";
            // 
            // txtFileChecksum
            // 
            this.txtFileChecksum.AllowDrop = true;
            this.txtFileChecksum.Location = new System.Drawing.Point(131, 73);
            this.txtFileChecksum.Name = "txtFileChecksum";
            this.txtFileChecksum.ReadOnly = true;
            this.txtFileChecksum.Size = new System.Drawing.Size(385, 20);
            this.txtFileChecksum.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::FileChecksumer.Properties.Resources.document_save_as28x28;
            this.btnSave.Location = new System.Drawing.Point(522, 59);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 46);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCheckSumFile
            // 
            this.txtCheckSumFile.AllowDrop = true;
            this.txtCheckSumFile.Location = new System.Drawing.Point(131, 128);
            this.txtCheckSumFile.Name = "txtCheckSumFile";
            this.txtCheckSumFile.ReadOnly = true;
            this.txtCheckSumFile.Size = new System.Drawing.Size(385, 20);
            this.txtCheckSumFile.TabIndex = 7;
            this.txtCheckSumFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtCheckSumFile_DragDrop);
            this.txtCheckSumFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtCheckSumFile_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Checksum File:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Checksum type:";
            // 
            // cboHashType
            // 
            this.cboHashType.FormattingEnabled = true;
            this.cboHashType.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA512"});
            this.cboHashType.Location = new System.Drawing.Point(131, 170);
            this.cboHashType.Name = "cboHashType";
            this.cboHashType.Size = new System.Drawing.Size(151, 21);
            this.cboHashType.TabIndex = 10;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Image = global::FileChecksumer.Properties.Resources.system_search28x28;
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.Location = new System.Drawing.Point(442, 161);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(136, 37);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.FlatAppearance.BorderSize = 0;
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFile.Image = global::FileChecksumer.Properties.Resources.document_open28x28;
            this.btnLoadFile.Location = new System.Drawing.Point(522, 27);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 39);
            this.btnLoadFile.TabIndex = 5;
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 209);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(630, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem1.Text = "&Open";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem1.Text = "&Save";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpFileToolStripMenuItem1,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // helpFileToolStripMenuItem1
            // 
            this.helpFileToolStripMenuItem1.Name = "helpFileToolStripMenuItem1";
            this.helpFileToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.helpFileToolStripMenuItem1.Text = "Hel&p File";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.aboutToolStripMenuItem1.Text = "&About";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpFileToolStripMenuItem
            // 
            this.helpFileToolStripMenuItem.Name = "helpFileToolStripMenuItem";
            this.helpFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpFileToolStripMenuItem.Text = "Help File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnLoadComparisonFile
            // 
            this.btnLoadComparisonFile.FlatAppearance.BorderSize = 0;
            this.btnLoadComparisonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadComparisonFile.Image = global::FileChecksumer.Properties.Resources.document_open28x28;
            this.btnLoadComparisonFile.Location = new System.Drawing.Point(522, 118);
            this.btnLoadComparisonFile.Name = "btnLoadComparisonFile";
            this.btnLoadComparisonFile.Size = new System.Drawing.Size(75, 39);
            this.btnLoadComparisonFile.TabIndex = 14;
            this.btnLoadComparisonFile.UseVisualStyleBackColor = true;
            this.btnLoadComparisonFile.Click += new System.EventHandler(this.btnLoadComparisonFile_Click);
            // 
            // txtOrigFile
            // 
            this.txtOrigFile.AllowDrop = true;
            this.txtOrigFile.Location = new System.Drawing.Point(131, 37);
            this.txtOrigFile.Name = "txtOrigFile";
            this.txtOrigFile.Size = new System.Drawing.Size(385, 20);
            this.txtOrigFile.TabIndex = 15;
            this.txtOrigFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtOrigFile_DragDrop);
            this.txtOrigFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtOrigFile_DragEnter);
            // 
            // saveFileDialogChecksum
            // 
            this.saveFileDialogChecksum.Filter = "MD5|*.md5|SHA1|*.sha1|SHA512|*.sha512";
            // 
            // openFileDialogChecksum
            // 
            this.openFileDialogChecksum.Filter = "MD5|*.md5|SHA1|*.sha1|SHA512|*.sha512";
            // 
            // btnCompare
            // 
            this.btnCompare.Image = global::FileChecksumer.Properties.Resources.system_search28x28;
            this.btnCompare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompare.Location = new System.Drawing.Point(300, 161);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(136, 37);
            this.btnCompare.TabIndex = 16;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 231);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtOrigFile);
            this.Controls.Add(this.btnLoadComparisonFile);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cboHashType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCheckSumFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFileChecksum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainGui";
            this.Text = "File Check Sum Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileChecksum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox txtCheckSumFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboHashType;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Button btnLoadComparisonFile;
        private System.Windows.Forms.TextBox txtOrigFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialogChecksum;
        private System.Windows.Forms.OpenFileDialog openFileDialogFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogChecksum;
        private System.Windows.Forms.Button btnCompare;
    }
}

