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

        private string GenerateRoboCopyBatch(string sourcePath, string destinationPath, string fileMask)
        {
            // /E: Copy subdirectories, including empty ones.
            // /Z: Copy files in restartable mode (good for large files/unstable networks).
            // /R:3: Retry 3 times on failed copies.
            // /W:5: Wait 5 seconds between retries.
            // /NDL /NJH /NJS: Suppress log output to reduce console spam, making it cleaner.
            return $@"@echo off

:: Source: {sourcePath}
:: Destination: {destinationPath}
:: File/Mask: {fileMask}

robocopy ""{sourcePath}"" ""{destinationPath}"" ""{fileMask}"" /E /Z /R:3 /W:5 /NDL /NJH /NJS

echo RoboCopy operation completed or attempted.
pause";
        }

        private void btnAddRoboCopy_Click(object sender, EventArgs e)
        {
            // 1. Prompt for Source Path
            string sourcePath = PromptForPath("Select the **Source Folder** for RoboCopy.");
            if (string.IsNullOrEmpty(sourcePath))
            {
                ShowToast("Operation cancelled. Source folder not selected.", 3000, false);
                return;
            }

            // 2. Prompt for Destination Path
            string destinationPath = PromptForPath("Select the **Destination Folder** for RoboCopy.");
            if (string.IsNullOrEmpty(destinationPath))
            {
                ShowToast("Operation cancelled. Destination folder not selected.", 3000, false);
                return;
            }

            // 3. Prompt for the specific File/Folder name with the CLEARER explanation and E.G.s
            string promptExplanation = "Enter the **File Name** or **File Mask** to be copied.\n\n" +
                                       "**REMINDER: The asterisk (*) is the wildcard for 'all'.**\n\n" +
                                       "• Use ***.* for all files**.\n" +
                                       "• Use **a file mask** (e.g., ***.pdf** for PDFs, ***.log** for logs).\n" +
                                       "• Use **a specific file name** (e.g., **important.docx**).\n" +
                                       "• Use **a sub-folder name** (e.g., **Archive** to copy that folder and its contents).";

            string fileMask = Microsoft.VisualBasic.Interaction.InputBox(
                promptExplanation, // Updated Prompt String with specific E.G.s
                "RoboCopy File/Mask Input",
                "*.*"
            );

            // If the user cancelled the InputBox or entered nothing, we can default to *.* (all files)
            if (string.IsNullOrEmpty(fileMask))
            {
                fileMask = "*.*";
            }

            // 4. Generate the Batch Code
            string robocopyBatchPreset = GenerateRoboCopyBatch(sourcePath, destinationPath, fileMask);

            // 5. Input the generated code into the Rich Text Box
            AddToRichTextBox(robocopyBatchPreset);
            ShowToast("RoboCopy Batch code generated with selected paths.", 3000, true);
        }

        private string GenerateVersionControlBatch(string sourcePath, string destinationPath)
        {
            // The batch logic for finding the next version number (v1, v2, etc.) remains the same.
            // The paths are dynamically inserted into the batch content using string interpolation ($).
            return $@"@echo off
setlocal

:: Set the source and destination directories
set ""source_folder={sourcePath}""
set ""destination_folder={destinationPath}""

:: Set the optional base name for the copied folder
:: Leave empty to use default naming with ""v1"", ""v2"", etc.
set ""SetName=Copy""

:: Initialize the copy counter
set ""count=1""

:: Check for existing copies and find the next available number
:check_existing
if defined SetName (
    set ""folder_name=%SetName% v%count%""
) else (
    set ""folder_name=v%count%""
)

if exist ""%destination_folder%\%folder_name%"" (
    set /a count+=1
    goto :check_existing
)

:: Copy the folder and rename it with the incremented count
xcopy ""%source_folder%"" ""%destination_folder%\%folder_name%"" /E /I

echo Folder copied to ""%destination_folder%\%folder_name%""

endlocal
pause";
        }

        private string PromptForPath(string title)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = title;
                fbd.ShowNewFolderButton = true;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    return fbd.SelectedPath;
                }
            }
            return null; // User cancelled or closed the dialog
        }

        private void btnVersionControlCopy_Click(object sender, EventArgs e)
        {
            // 1. Prompt for Source Path
            string sourcePath = PromptForPath("Select the **Source Folder** to be version controlled (copied).");
            if (string.IsNullOrEmpty(sourcePath))
            {
                ShowToast("Operation cancelled. Source folder not selected.", 3000, false);
                return;
            }

            // 2. Prompt for Destination Path
            string destinationPath = PromptForPath("Select the **Destination Folder** where version copies will be saved.");
            if (string.IsNullOrEmpty(destinationPath))
            {
                ShowToast("Operation cancelled. Destination folder not selected.", 3000, false);
                return;
            }

            // 3. Generate the Batch Code using the selected paths
            string versionControlCopyPreset = GenerateVersionControlBatch(sourcePath, destinationPath);

            // 4. Input the generated code into the Rich Text Box
            AddToRichTextBox(versionControlCopyPreset);
            ShowToast("Version Control Batch code generated with selected paths.", 3000, true);
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
