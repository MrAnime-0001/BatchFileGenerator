using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BatchFileGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtFileExtension.Text = "bat";
        }

        private void btnActionCreateClipboard_Click(object sender, EventArgs e)
        {
            string textToCopy = rtbBatchContent.Text;
            string fileName = txtFileName.Text;

            if (string.IsNullOrWhiteSpace(textToCopy))
            {
                UIHelper.ShowToast("⚠️ Please enter text to copy to the clipboard.", 3000, false);
                return;
            }

            if (!FileOperations.IsValidFileName(fileName))
            {
                UIHelper.ShowToast("⚠️ Please enter a valid file name.", 3000, false);
                return;
            }

            fileName = FileOperations.GetFullFileName(fileName, txtFileExtension.Text);
            string batchContent = BatchScriptGenerator.GenerateCopyToClipboardBatch(textToCopy);
            
            SaveAndNotify(fileName, batchContent);
        }

        private void btnActionCreateFile_Click(object sender, EventArgs e)
        {
            string batchContent = rtbBatchContent.Text;
            string fileName = txtFileName.Text;

            if (string.IsNullOrWhiteSpace(batchContent))
            {
                UIHelper.ShowToast("⚠️ Please enter batch commands to execute.", 3000, false);
                return;
            }

            if (!FileOperations.IsValidFileName(fileName))
            {
                UIHelper.ShowToast("⚠️ Please enter a valid file name.", 3000, false);
                return;
            }

            fileName = FileOperations.GetFullFileName(fileName, txtFileExtension.Text);
            SaveAndNotify(fileName, batchContent);
        }

        private void SaveAndNotify(string fileName, string content)
        {
            try
            {
                UIHelper.ExportChoice choice = UIHelper.ShowExportChoiceDialog();
                if (choice == UIHelper.ExportChoice.Cancel) return;

                string path;
                if (choice == UIHelper.ExportChoice.PickLocation)
                {
                    string? selectedPath = UIHelper.PromptForPath("Select the folder where you want to save the batch file.");
                    if (string.IsNullOrEmpty(selectedPath)) return;
                    path = FileOperations.SaveBatchFileToPath(selectedPath, fileName, content);
                }
                else
                {
                    path = FileOperations.SaveBatchFile(fileName, content);
                }

                UIHelper.ShowToast($"✅ Batch file created successfully at:\n{path}", 4000, true);
                
                rtbBatchContent.Clear();
                txtFileName.Clear();
                txtFileExtension.Text = "bat";
                btnActionCreateClipboard.Enabled = true;
                btnActionCreateClipboard.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                UIHelper.ShowToast($"❌ An error occurred: {ex.Message}", 4000, false);
            }
        }

        private void AddToRichTextBox(string text)
        {
            if (!string.IsNullOrWhiteSpace(rtbBatchContent.Text))
            {
                if (!rtbBatchContent.Text.StartsWith("@echo off"))
                {
                    rtbBatchContent.Text = "@echo off\n\n" + rtbBatchContent.Text;
                }
                rtbBatchContent.AppendText("\n\n" + text);
            }
            else
            {
                rtbBatchContent.Text = "@echo off\n\n" + text;
            }

            btnActionCreateClipboard.Enabled = false;
            btnActionCreateClipboard.ForeColor = Color.Gray;
        }

        private void btnLibRoboCopy_Click(object sender, EventArgs e)
        {
            string? sourcePath = UIHelper.PromptForPath("Select the **Source Folder** for RoboCopy.");
            if (string.IsNullOrEmpty(sourcePath)) return;

            string? destinationPath = UIHelper.PromptForPath("Select the **Destination Folder** for RoboCopy.");
            if (string.IsNullOrEmpty(destinationPath)) return;

            string promptExplanation = "Enter the **File Name** or **File Mask** to be copied.\n\n" +
                                       "**REMINDER: The asterisk (*) is the wildcard for 'all'.**\n\n" +
                                       "• Use ***.* for all files**.\n" +
                                       "• Use **a file mask** (e.g., ***.pdf** for PDFs, ***.log** for logs).\n" +
                                       "• Use **a specific file name** (e.g., **important.docx**).\n" +
                                       "• Use **a sub-folder name** (e.g., **Archive** to copy that folder and its contents).";

            string fileMask = Microsoft.VisualBasic.Interaction.InputBox(promptExplanation, "RoboCopy File/Mask Input", "*.*");
            if (string.IsNullOrEmpty(fileMask)) fileMask = "*.*";

            string robocopyBatch = BatchScriptGenerator.GenerateRoboCopyBatch(sourcePath, destinationPath, fileMask);
            AddToRichTextBox(robocopyBatch);
            UIHelper.ShowToast("RoboCopy Batch code generated.", 3000, true);
        }

        private void btnLibVersionControl_Click(object sender, EventArgs e)
        {
            string? sourcePath = UIHelper.PromptForPath("Select the **Source Folder** to be version controlled.");
            if (string.IsNullOrEmpty(sourcePath)) return;

            string? destinationPath = UIHelper.PromptForPath("Select the **Destination Folder** for version copies.");
            if (string.IsNullOrEmpty(destinationPath)) return;

            string versionControlBatch = BatchScriptGenerator.GenerateVersionControlBatch(sourcePath, destinationPath);
            AddToRichTextBox(versionControlBatch);
            UIHelper.ShowToast("Version Control Batch code generated.", 3000, true);
        }

        private void btnLibDeleteFile_Click(object sender, EventArgs e)
        {
            string? filePath = UIHelper.PromptForFile("Select the **Specific File** that should be deleted.");
            if (string.IsNullOrEmpty(filePath)) return;

            string deleteFileBatch = BatchScriptGenerator.GenerateDeleteFileBatch(filePath);
            AddToRichTextBox(deleteFileBatch);
            UIHelper.ShowToast("Delete Specific File Batch code generated.", 3000, true);
        }

        private void btnLibDeleteFolderFiles_Click(object sender, EventArgs e)
        {
            string? folderPath = UIHelper.PromptForPath("Select the **Folder** from which **all files** should be deleted.");
            if (string.IsNullOrEmpty(folderPath)) return;

            string deleteAllFilesBatch = BatchScriptGenerator.GenerateDeleteFilesInFolderBatch(folderPath);
            AddToRichTextBox(deleteAllFilesBatch);
            UIHelper.ShowToast("Delete All Files Batch code generated.", 3000, true);
        }

        private void btnLibCreateFolder_Click(object sender, EventArgs e)
        {
            AddToRichTextBox(@"mkdir ""C:\Path\To\NewFolder""");
        }

        private void btnLibDeleteFolder_Click(object sender, EventArgs e)
        {
            string? folderPath = UIHelper.PromptForPath("Select the **Folder** that should be deleted completely.");
            if (string.IsNullOrEmpty(folderPath)) return;

            string deleteFolderBatch = BatchScriptGenerator.GenerateDeleteFolderTreeBatch(folderPath);
            AddToRichTextBox(deleteFolderBatch);
            UIHelper.ShowToast("Delete Folder Batch code generated.", 3000, true);
        }

        private void btnLibStartApp_Click(object sender, EventArgs e)
        {
            string? filePath = UIHelper.PromptForFile("Select the **Application** or **File** you want to start.");
            if (string.IsNullOrEmpty(filePath)) return;

            string startCommand = $@"start """" ""{filePath}""";
            AddToRichTextBox(startCommand);
            UIHelper.ShowToast("Start Application command generated.", 3000, true);
        }

        private void btnLibKillTask_Click(object sender, EventArgs e)
        {
            AddToRichTextBox(@"taskkill /F /IM ""application name""");
        }

        private void btnLibWait_Click(object sender, EventArgs e)
        {
            AddToRichTextBox(@"timeout /t <seconds> /nobreak >nul  REM Waits for specified seconds");
        }

        private void btnActionReset_Click(object sender, EventArgs e)
        {
            rtbBatchContent.Clear();
            txtFileExtension.Text = "bat";
            btnActionCreateClipboard.Enabled = true;
            btnActionCreateClipboard.ForeColor = Color.White;
        }

        private void btnActionExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLibSetPriority_Click(object sender, EventArgs e)
        {
            string processName = Microsoft.VisualBasic.Interaction.InputBox("Enter the **Process Name** (e.g., ScreenToGif, chrome):", "Process Name", "");
            if (string.IsNullOrWhiteSpace(processName)) return;

            string priorityClass = Microsoft.VisualBasic.Interaction.InputBox("Enter the **Priority Class** (e.g., High, Normal, BelowNormal):", "Priority Class", "High");
            if (string.IsNullOrWhiteSpace(priorityClass)) priorityClass = "High";

            string priorityBatch = BatchScriptGenerator.GeneratePrioritySetterBatch(processName, priorityClass);
            AddToRichTextBox(priorityBatch);
            UIHelper.ShowToast("Priority Setting Batch code generated.", 3000, true);
        }
    }
}
