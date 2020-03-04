using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFP.Code2Text
{
    public partial class FileBuilder : Form
    {
        public FileBuilder()
        {
            InitializeComponent();
        }

        private void sourceFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog.ShowNewFolderButton = false;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                sourceFolderTextBox.Text = selectedPath;
            }
        }

        private void targetFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                targetFolderTextBox.Text = selectedPath;
            }
        }

        private void CreateFileButton_Click(object sender, EventArgs e)
        {
            string sourceFolder = sourceFolderTextBox.Text.Trim();
            string fileExtensions = fileExtensionsTextBox.Text.Trim();
            string targetFolder = targetFolderTextBox.Text.Trim();
            string targetFileName = targetFileNameTextBox.Text.Trim();

            if (String.IsNullOrWhiteSpace(sourceFolder) 
                || String.IsNullOrWhiteSpace(fileExtensions)
                || String.IsNullOrWhiteSpace(targetFolder)
                || String.IsNullOrWhiteSpace(targetFileName))
            {
                MessageBox.Show("Please, enter all parameters to create file!", "Code2Text", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cursor = Cursors.WaitCursor;

            string[] files = Directory.GetFiles(sourceFolder, fileExtensions, SearchOption.AllDirectories);
            CreateTextFile(files, Path.Combine(targetFolder, targetFileName));

            Cursor = Cursors.Default;
            MessageBox.Show("WoW! file with source code created magically!", "Code2Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CreateTextFile(string[] files, string targetFilePath)
        {
            var contents = files
                .Select(path => new { Name = Path.GetFileName(path), Contents = File.ReadAllText(path) })
                .Select(info => String.Concat(
                    "*******************************************",
                    Environment.NewLine,
                    "Filename: " + info.Name,
                    Environment.NewLine,
                    "*******************************************",
                    info.Contents));

            var text = String.Join(Environment.NewLine, contents);
            File.WriteAllText(targetFilePath, text, Encoding.UTF8);
        }
    }
}