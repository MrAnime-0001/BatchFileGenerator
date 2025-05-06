using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

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
                btnCopyToClipboard.Enabled = true;
                btnCopyToClipboard.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddToRichTextBox(string text)
        {
            if (!string.IsNullOrWhiteSpace(rtbTextToCopy.Text))
            {
                if (!rtbTextToCopy.Text.StartsWith("@echo off"))
                {
                    rtbTextToCopy.Text = "@echo off\n\n" + rtbTextToCopy.Text;
                }
                rtbTextToCopy.AppendText("\n\n" + text);
            }
            else
            {
                rtbTextToCopy.Text = "@echo off\n\n" + text;
            }

            btnCopyToClipboard.Enabled = false;
            btnCopyToClipboard.ForeColor = Color.Gray;
        }

        private void btnAddRoboCopy_Click(object sender, EventArgs e)
        {
            AddToRichTextBox(@"robocopy ""source"" ""destination"" ""file name"" /z /e");
        }

        private void btnAddDeleteSpecificFile_Click(object sender, EventArgs e)
        {
            AddToRichTextBox(@"del /q ""C:\Users\YourName\Documents\file.txt""");
        }

        private void btnAddDeleteAllFilesinFolder_Click(object sender, EventArgs e)
        {
            AddToRichTextBox(@"del /q ""C:\Users\YourName\Documents\*.*""");
        }

        private void btnAddCreateFolder_Click(object sender, EventArgs e)
        {
            AddToRichTextBox(@"mkdir ""C:\Path\To\NewFolder""");
        }

        private void btnAddFolderDelete_Click(object sender, EventArgs e)
        {
            AddToRichTextBox(@"rmdir /s /q ""C:\Path\to\Directory""");
        }

        private void btnAddTaskKill_Click(object sender, EventArgs e)
        {
            AddToRichTextBox(@"taskkill /F /IM ""application name""");
        }

        private void btnAddWaitTime_Click(object sender, EventArgs e)
        {
            AddToRichTextBox(@"timeout /t <seconds> /nobreak >nul  REM Waits for specified seconds");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtbTextToCopy.Clear();
            btnCopyToClipboard.Enabled = true;
            btnCopyToClipboard.ForeColor = Color.Black;
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
