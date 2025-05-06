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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string textToCopy = txtTextToCopy.Text;
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

            // Define the batch file content to copy text to clipboard and exit
            string batchContent = @$"
@echo off
echo|set /p=""{textToCopy}"" | clip
";

            // Determine application directory
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Full path for the batch file
            string batchFilePath = Path.Combine(appDirectory, fileName);

            try
            {
                // Write the batch file directly to the application's location
                File.WriteAllText(batchFilePath, batchContent);

                // Show success message
                MessageBox.Show($"Batch file created successfully at:\n{batchFilePath}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the text boxes after successful generation
                txtTextToCopy.Clear();
                txtFileName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
