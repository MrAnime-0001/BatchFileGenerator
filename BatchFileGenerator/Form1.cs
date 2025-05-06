using System;
using System.IO;
using System.Windows.Forms;

namespace BatchFileGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            string textToCopy = rtbTextToCopy.Text;
            string fileName = txtFileName.Text;

            if (string.IsNullOrWhiteSpace(textToCopy))
            {
                MessageBox.Show("Please enter text to copy to the clipboard.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Please enter a file name for the batch file.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("File name contains invalid characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!fileName.EndsWith(".bat", StringComparison.OrdinalIgnoreCase))
            {
                fileName += ".bat";
            }

            // Define the batch file content to copy text to clipboard
            string batchContent = @$"@echo off
echo|set /p=""{textToCopy}"" | clip";

            SaveBatchFile(fileName, batchContent);
        }

        private void btnCreateExecutableBatch_Click(object sender, EventArgs e)
        {
            string batchContent = rtbTextToCopy.Text;
            string fileName = txtFileName.Text;

            if (string.IsNullOrWhiteSpace(batchContent))
            {
                MessageBox.Show("Please enter batch commands to execute.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Please enter a file name for the batch file.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("File name contains invalid characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!fileName.EndsWith(".bat", StringComparison.OrdinalIgnoreCase))
            {
                fileName += ".bat";
            }

            SaveBatchFile(fileName, batchContent);
        }

        private void SaveBatchFile(string fileName, string content)
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string batchFilePath = Path.Combine(appDirectory, fileName);

            try
            {
                File.WriteAllText(batchFilePath, content);
                MessageBox.Show($"Batch file created successfully at:\n{batchFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbTextToCopy.Clear();
                txtFileName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
