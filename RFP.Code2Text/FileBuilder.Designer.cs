namespace RFP.Code2Text
{
    partial class FileBuilder
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
            this.sourceFolderLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.sourceFolderTextBox = new System.Windows.Forms.TextBox();
            this.sourceFolderBrowseButton = new System.Windows.Forms.Button();
            this.targetFileNameLabel = new System.Windows.Forms.Label();
            this.targetFileNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateFileButton = new System.Windows.Forms.Button();
            this.fileExtensionsTextBox = new System.Windows.Forms.TextBox();
            this.extensionsLabel = new System.Windows.Forms.Label();
            this.sourceGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.targetFolderButton = new System.Windows.Forms.Button();
            this.targetFolderTextBox = new System.Windows.Forms.TextBox();
            this.targetFolderLabel = new System.Windows.Forms.Label();
            this.sourceGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceFolderLabel
            // 
            this.sourceFolderLabel.AutoSize = true;
            this.sourceFolderLabel.Location = new System.Drawing.Point(34, 56);
            this.sourceFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sourceFolderLabel.Name = "sourceFolderLabel";
            this.sourceFolderLabel.Size = new System.Drawing.Size(156, 20);
            this.sourceFolderLabel.TabIndex = 0;
            this.sourceFolderLabel.Text = "Solution or project folder";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // sourceFolderTextBox
            // 
            this.sourceFolderTextBox.Location = new System.Drawing.Point(34, 87);
            this.sourceFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sourceFolderTextBox.Name = "sourceFolderTextBox";
            this.sourceFolderTextBox.ReadOnly = true;
            this.sourceFolderTextBox.Size = new System.Drawing.Size(607, 26);
            this.sourceFolderTextBox.TabIndex = 1;
            this.sourceFolderTextBox.TabStop = false;
            // 
            // sourceFolderBrowseButton
            // 
            this.sourceFolderBrowseButton.Location = new System.Drawing.Point(636, 69);
            this.sourceFolderBrowseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sourceFolderBrowseButton.Name = "sourceFolderBrowseButton";
            this.sourceFolderBrowseButton.Size = new System.Drawing.Size(100, 35);
            this.sourceFolderBrowseButton.TabIndex = 2;
            this.sourceFolderBrowseButton.Text = "Browse...";
            this.sourceFolderBrowseButton.UseVisualStyleBackColor = true;
            this.sourceFolderBrowseButton.Click += new System.EventHandler(this.sourceFolderButton_Click);
            // 
            // targetFileNameLabel
            // 
            this.targetFileNameLabel.AutoSize = true;
            this.targetFileNameLabel.Location = new System.Drawing.Point(21, 132);
            this.targetFileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.targetFileNameLabel.Name = "targetFileNameLabel";
            this.targetFileNameLabel.Size = new System.Drawing.Size(100, 20);
            this.targetFileNameLabel.TabIndex = 3;
            this.targetFileNameLabel.Text = "Result filename";
            // 
            // targetFileNameTextBox
            // 
            this.targetFileNameTextBox.Location = new System.Drawing.Point(21, 158);
            this.targetFileNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.targetFileNameTextBox.Name = "targetFileNameTextBox";
            this.targetFileNameTextBox.Size = new System.Drawing.Size(607, 26);
            this.targetFileNameTextBox.TabIndex = 6;
            // 
            // CreateFileButton
            // 
            this.CreateFileButton.Location = new System.Drawing.Point(13, 490);
            this.CreateFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateFileButton.Name = "CreateFileButton";
            this.CreateFileButton.Size = new System.Drawing.Size(131, 57);
            this.CreateFileButton.TabIndex = 7;
            this.CreateFileButton.Text = "Create text file";
            this.CreateFileButton.UseVisualStyleBackColor = true;
            this.CreateFileButton.Click += new System.EventHandler(this.CreateFileButton_Click);
            // 
            // fileExtensionsTextBox
            // 
            this.fileExtensionsTextBox.Location = new System.Drawing.Point(34, 160);
            this.fileExtensionsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileExtensionsTextBox.Name = "fileExtensionsTextBox";
            this.fileExtensionsTextBox.Size = new System.Drawing.Size(607, 26);
            this.fileExtensionsTextBox.TabIndex = 3;
            this.fileExtensionsTextBox.Text = "*.cs";
            // 
            // extensionsLabel
            // 
            this.extensionsLabel.AutoSize = true;
            this.extensionsLabel.Location = new System.Drawing.Point(34, 129);
            this.extensionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.extensionsLabel.Name = "extensionsLabel";
            this.extensionsLabel.Size = new System.Drawing.Size(100, 20);
            this.extensionsLabel.TabIndex = 6;
            this.extensionsLabel.Text = "File extensions";
            // 
            // sourceGroupBox
            // 
            this.sourceGroupBox.Controls.Add(this.sourceFolderBrowseButton);
            this.sourceGroupBox.Location = new System.Drawing.Point(13, 14);
            this.sourceGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sourceGroupBox.Name = "sourceGroupBox";
            this.sourceGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sourceGroupBox.Size = new System.Drawing.Size(758, 220);
            this.sourceGroupBox.TabIndex = 8;
            this.sourceGroupBox.TabStop = false;
            this.sourceGroupBox.Text = "Source";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.targetFolderButton);
            this.groupBox1.Controls.Add(this.targetFileNameTextBox);
            this.groupBox1.Controls.Add(this.targetFolderTextBox);
            this.groupBox1.Controls.Add(this.targetFileNameLabel);
            this.groupBox1.Controls.Add(this.targetFolderLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 244);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(758, 220);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target";
            // 
            // targetFolderButton
            // 
            this.targetFolderButton.Location = new System.Drawing.Point(636, 82);
            this.targetFolderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.targetFolderButton.Name = "targetFolderButton";
            this.targetFolderButton.Size = new System.Drawing.Size(100, 35);
            this.targetFolderButton.TabIndex = 5;
            this.targetFolderButton.Text = "Browse...";
            this.targetFolderButton.UseVisualStyleBackColor = true;
            this.targetFolderButton.Click += new System.EventHandler(this.targetFolderButton_Click);
            // 
            // targetFolderTextBox
            // 
            this.targetFolderTextBox.Location = new System.Drawing.Point(21, 86);
            this.targetFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.targetFolderTextBox.Name = "targetFolderTextBox";
            this.targetFolderTextBox.ReadOnly = true;
            this.targetFolderTextBox.Size = new System.Drawing.Size(607, 26);
            this.targetFolderTextBox.TabIndex = 4;
            this.targetFolderTextBox.TabStop = false;
            // 
            // targetFolderLabel
            // 
            this.targetFolderLabel.AutoSize = true;
            this.targetFolderLabel.Location = new System.Drawing.Point(21, 59);
            this.targetFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.targetFolderLabel.Name = "targetFolderLabel";
            this.targetFolderLabel.Size = new System.Drawing.Size(121, 20);
            this.targetFolderLabel.TabIndex = 10;
            this.targetFolderLabel.Text = "Result target folder";
            // 
            // FileBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.fileExtensionsTextBox);
            this.Controls.Add(this.extensionsLabel);
            this.Controls.Add(this.CreateFileButton);
            this.Controls.Add(this.sourceFolderTextBox);
            this.Controls.Add(this.sourceFolderLabel);
            this.Controls.Add(this.sourceGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code2File";
            this.sourceGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sourceFolderLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox sourceFolderTextBox;
        private System.Windows.Forms.Button sourceFolderBrowseButton;
        private System.Windows.Forms.Label targetFileNameLabel;
        private System.Windows.Forms.TextBox targetFileNameTextBox;
        private System.Windows.Forms.Button CreateFileButton;
        private System.Windows.Forms.TextBox fileExtensionsTextBox;
        private System.Windows.Forms.Label extensionsLabel;
        private System.Windows.Forms.GroupBox sourceGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button targetFolderButton;
        private System.Windows.Forms.TextBox targetFolderTextBox;
        private System.Windows.Forms.Label targetFolderLabel;
    }
}

