namespace BatchFileGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFileName = new Label();
            txtFileName = new TextBox();
            btnCopyToClipboard = new Button();
            rtbTextToCopy = new RichTextBox();
            btnCreateExecutableBatch = new Button();
            btnReset = new Button();
            btnAddRoboCopy = new Button();
            btnAddFolderDelete = new Button();
            btnAddTaskKill = new Button();
            btnAddDeleteSpecificFile = new Button();
            btnAddDeleteAllFilesinFolder = new Button();
            btnAddWaitTime = new Button();
            btnExitApplication = new Button();
            SuspendLayout();
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.ForeColor = Color.White;
            lblFileName.Location = new Point(12, 15);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(60, 15);
            lblFileName.TabIndex = 0;
            lblFileName.Text = "File Name";
            // 
            // txtFileName
            // 
            txtFileName.ForeColor = Color.Black;
            txtFileName.Location = new Point(72, 12);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(250, 23);
            txtFileName.TabIndex = 2;
            // 
            // btnCopyToClipboard
            // 
            btnCopyToClipboard.Location = new Point(328, 12);
            btnCopyToClipboard.Name = "btnCopyToClipboard";
            btnCopyToClipboard.Size = new Size(109, 267);
            btnCopyToClipboard.TabIndex = 4;
            btnCopyToClipboard.Text = "Create Clipboard Batch File";
            btnCopyToClipboard.UseVisualStyleBackColor = true;
            btnCopyToClipboard.Click += btnCopyToClipboard_Click;
            // 
            // rtbTextToCopy
            // 
            rtbTextToCopy.Location = new Point(12, 41);
            rtbTextToCopy.Name = "rtbTextToCopy";
            rtbTextToCopy.Size = new Size(310, 315);
            rtbTextToCopy.TabIndex = 5;
            rtbTextToCopy.Text = "";
            // 
            // btnCreateExecutableBatch
            // 
            btnCreateExecutableBatch.Location = new Point(328, 279);
            btnCreateExecutableBatch.Name = "btnCreateExecutableBatch";
            btnCreateExecutableBatch.Size = new Size(109, 267);
            btnCreateExecutableBatch.TabIndex = 6;
            btnCreateExecutableBatch.Text = "Create Executable Batch File";
            btnCreateExecutableBatch.UseVisualStyleBackColor = true;
            btnCreateExecutableBatch.Click += btnCreateExecutableBatch_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(12, 500);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(310, 23);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset Everything";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnAddRoboCopy
            // 
            btnAddRoboCopy.Location = new Point(12, 362);
            btnAddRoboCopy.Name = "btnAddRoboCopy";
            btnAddRoboCopy.Size = new Size(310, 23);
            btnAddRoboCopy.TabIndex = 8;
            btnAddRoboCopy.Text = "Add Robo Copy";
            btnAddRoboCopy.UseVisualStyleBackColor = true;
            btnAddRoboCopy.Click += btnAddRoboCopy_Click;
            // 
            // btnAddFolderDelete
            // 
            btnAddFolderDelete.Location = new Point(12, 431);
            btnAddFolderDelete.Name = "btnAddFolderDelete";
            btnAddFolderDelete.Size = new Size(310, 23);
            btnAddFolderDelete.TabIndex = 9;
            btnAddFolderDelete.Text = "Add Folder Delete";
            btnAddFolderDelete.UseVisualStyleBackColor = true;
            btnAddFolderDelete.Click += btnAddFolderDelete_Click;
            // 
            // btnAddTaskKill
            // 
            btnAddTaskKill.Location = new Point(12, 454);
            btnAddTaskKill.Name = "btnAddTaskKill";
            btnAddTaskKill.Size = new Size(310, 23);
            btnAddTaskKill.TabIndex = 10;
            btnAddTaskKill.Text = "Add Task Kill";
            btnAddTaskKill.UseVisualStyleBackColor = true;
            btnAddTaskKill.Click += btnAddTaskKill_Click;
            // 
            // btnAddDeleteSpecificFile
            // 
            btnAddDeleteSpecificFile.Location = new Point(12, 385);
            btnAddDeleteSpecificFile.Name = "btnAddDeleteSpecificFile";
            btnAddDeleteSpecificFile.Size = new Size(310, 23);
            btnAddDeleteSpecificFile.TabIndex = 11;
            btnAddDeleteSpecificFile.Text = "Add Delete Specific File";
            btnAddDeleteSpecificFile.UseVisualStyleBackColor = true;
            btnAddDeleteSpecificFile.Click += btnAddDeleteSpecificFile_Click;
            // 
            // btnAddDeleteAllFilesinFolder
            // 
            btnAddDeleteAllFilesinFolder.Location = new Point(12, 408);
            btnAddDeleteAllFilesinFolder.Name = "btnAddDeleteAllFilesinFolder";
            btnAddDeleteAllFilesinFolder.Size = new Size(310, 23);
            btnAddDeleteAllFilesinFolder.TabIndex = 12;
            btnAddDeleteAllFilesinFolder.Text = "Add Delete All Files in Folder";
            btnAddDeleteAllFilesinFolder.UseVisualStyleBackColor = true;
            btnAddDeleteAllFilesinFolder.Click += btnAddDeleteAllFilesinFolder_Click;
            // 
            // btnAddWaitTime
            // 
            btnAddWaitTime.Location = new Point(12, 477);
            btnAddWaitTime.Name = "btnAddWaitTime";
            btnAddWaitTime.Size = new Size(310, 23);
            btnAddWaitTime.TabIndex = 13;
            btnAddWaitTime.Text = "Add Wait Time";
            btnAddWaitTime.UseVisualStyleBackColor = true;
            btnAddWaitTime.Click += btnAddWaitTime_Click;
            // 
            // btnExitApplication
            // 
            btnExitApplication.Location = new Point(12, 523);
            btnExitApplication.Name = "btnExitApplication";
            btnExitApplication.Size = new Size(310, 23);
            btnExitApplication.TabIndex = 14;
            btnExitApplication.Text = "Close Program";
            btnExitApplication.UseVisualStyleBackColor = true;
            btnExitApplication.Click += btnExitApplication_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(443, 552);
            Controls.Add(btnExitApplication);
            Controls.Add(btnAddWaitTime);
            Controls.Add(btnAddDeleteAllFilesinFolder);
            Controls.Add(btnAddDeleteSpecificFile);
            Controls.Add(btnAddTaskKill);
            Controls.Add(btnAddFolderDelete);
            Controls.Add(btnAddRoboCopy);
            Controls.Add(btnReset);
            Controls.Add(btnCreateExecutableBatch);
            Controls.Add(rtbTextToCopy);
            Controls.Add(btnCopyToClipboard);
            Controls.Add(txtFileName);
            Controls.Add(lblFileName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Batch File Creation Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFileName;
        private TextBox txtFileName;
        private Button btnCopyToClipboard;
        private RichTextBox rtbTextToCopy;
        private Button btnCreateExecutableBatch;
        private Button btnReset;
        private Button btnAddRoboCopy;
        private Button btnAddFolderDelete;
        private Button btnAddTaskKill;
        private Button btnAddDeleteSpecificFile;
        private Button btnAddDeleteAllFilesinFolder;
        private Button btnAddWaitTime;
        private Button btnExitApplication;
    }
}
