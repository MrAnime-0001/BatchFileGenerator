using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace BatchFileGenerator
{
    public partial class Form1 : Form
    {

        public static void ShowToast(string message, int duration = 2000, bool playSound = true)
        {
            Form toast = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.Manual,
                ShowInTaskbar = false,
                TopMost = true,
                BackColor = Color.FromArgb(45, 45, 48),
                Size = new Size(250, 60),
                Opacity = 0.9
            };

            toast.Controls.Add(new Label
            {
                Text = message,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White
            });

            var screen = Screen.PrimaryScreen.WorkingArea;
            toast.Location = new Point(screen.Right - toast.Width - 10, screen.Bottom - toast.Height - 10);

            toast.Shown += async (s, e) =>
            {
                if (playSound)
                {
                    SystemSounds.Exclamation.Play(); // Default Windows notification sound
                }

                await Task.Delay(duration);
                toast.Close();
            };

            toast.Show();
        }

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
                ShowToast("⚠️ Please enter text to copy to the clipboard.", 3000, false);
                return;
            }

            if (string.IsNullOrWhiteSpace(fileName))
            {
                ShowToast("⚠️ Please enter a file name for the batch file.", 3000, false);
                return;
            }

            if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                ShowToast("⚠️ File name contains invalid characters.", 3000, false);
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
                ShowToast("⚠️ Please enter batch commands to execute.", 3000, false);
                return;
            }

            if (string.IsNullOrWhiteSpace(fileName))
            {
                ShowToast("⚠️ Please enter a file name for the batch file.", 3000, false);
                return;
            }

            if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                ShowToast("⚠️ File name contains invalid characters.", 3000, false);
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
                ShowToast($"✅ Batch file created successfully at:\n{batchFilePath}", 4000, true);
                rtbTextToCopy.Clear();
                txtFileName.Clear();
                btnCopyToClipboard.Enabled = true;
                btnCopyToClipboard.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                ShowToast($"❌ An error occurred: {ex.Message}", 4000, false);
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
