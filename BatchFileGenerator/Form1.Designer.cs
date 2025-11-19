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
            btnAddCreateFolder = new Button();
            btnVersionControlCopy = new Button();
            SuspendLayout();
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI", 9.75F);
            lblFileName.ForeColor = Color.FromArgb(220, 220, 220);
            lblFileName.Location = new Point(12, 15);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(66, 17);
            lblFileName.TabIndex = 0;
            lblFileName.Text = "File Name";
            // 
            // txtFileName
            // 
            txtFileName.BackColor = Color.WhiteSmoke;
            txtFileName.BorderStyle = BorderStyle.FixedSingle;
            txtFileName.Font = new Font("Segoe UI", 9.75F);
            txtFileName.ForeColor = Color.Black;
            txtFileName.Location = new Point(84, 12);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(238, 25);
            txtFileName.TabIndex = 2;
            // 
            // btnCopyToClipboard
            // 
            btnCopyToClipboard.BackColor = Color.FromArgb(33, 150, 243);
            btnCopyToClipboard.FlatAppearance.BorderSize = 0;
            btnCopyToClipboard.FlatStyle = FlatStyle.Flat;
            btnCopyToClipboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCopyToClipboard.ForeColor = Color.White;
            btnCopyToClipboard.Location = new Point(328, 12);
            btnCopyToClipboard.Name = "btnCopyToClipboard";
            btnCopyToClipboard.Size = new Size(109, 311);
            btnCopyToClipboard.TabIndex = 4;
            btnCopyToClipboard.Text = "Create Clipboard Batch File";
            btnCopyToClipboard.UseVisualStyleBackColor = false;
            btnCopyToClipboard.Click += btnCopyToClipboard_Click;
            // 
            // rtbTextToCopy
            // 
            rtbTextToCopy.BackColor = Color.FromArgb(30, 30, 30);
            rtbTextToCopy.BorderStyle = BorderStyle.FixedSingle;
            rtbTextToCopy.Font = new Font("Consolas", 9F);
            rtbTextToCopy.ForeColor = Color.WhiteSmoke;
            rtbTextToCopy.Location = new Point(12, 41);
            rtbTextToCopy.Name = "rtbTextToCopy";
            rtbTextToCopy.Size = new Size(310, 315);
            rtbTextToCopy.TabIndex = 5;
            rtbTextToCopy.Text = "";
            // 
            // btnCreateExecutableBatch
            // 
            btnCreateExecutableBatch.BackColor = Color.FromArgb(76, 175, 80);
            btnCreateExecutableBatch.FlatAppearance.BorderSize = 0;
            btnCreateExecutableBatch.FlatStyle = FlatStyle.Flat;
            btnCreateExecutableBatch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCreateExecutableBatch.ForeColor = Color.White;
            btnCreateExecutableBatch.Location = new Point(328, 331);
            btnCreateExecutableBatch.Name = "btnCreateExecutableBatch";
            btnCreateExecutableBatch.Size = new Size(109, 311);
            btnCreateExecutableBatch.TabIndex = 6;
            btnCreateExecutableBatch.Text = "Create Executable Batch File";
            btnCreateExecutableBatch.UseVisualStyleBackColor = false;
            btnCreateExecutableBatch.Click += btnCreateExecutableBatch_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(244, 67, 54);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(12, 586);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(310, 28);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset Everything";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnAddRoboCopy
            // 
            btnAddRoboCopy.BackColor = Color.FromArgb(63, 81, 181);
            btnAddRoboCopy.FlatAppearance.BorderSize = 0;
            btnAddRoboCopy.FlatStyle = FlatStyle.Flat;
            btnAddRoboCopy.Font = new Font("Segoe UI", 9.75F);
            btnAddRoboCopy.ForeColor = Color.White;
            btnAddRoboCopy.Location = new Point(12, 362);
            btnAddRoboCopy.Name = "btnAddRoboCopy";
            btnAddRoboCopy.Size = new Size(310, 28);
            btnAddRoboCopy.TabIndex = 8;
            btnAddRoboCopy.Text = "Add Robo Copy";
            btnAddRoboCopy.UseVisualStyleBackColor = false;
            btnAddRoboCopy.Click += btnAddRoboCopy_Click;
            // 
            // btnAddFolderDelete
            // 
            btnAddFolderDelete.BackColor = Color.FromArgb(63, 81, 181);
            btnAddFolderDelete.FlatAppearance.BorderSize = 0;
            btnAddFolderDelete.FlatStyle = FlatStyle.Flat;
            btnAddFolderDelete.Font = new Font("Segoe UI", 9.75F);
            btnAddFolderDelete.ForeColor = Color.White;
            btnAddFolderDelete.Location = new Point(12, 502);
            btnAddFolderDelete.Name = "btnAddFolderDelete";
            btnAddFolderDelete.Size = new Size(310, 28);
            btnAddFolderDelete.TabIndex = 9;
            btnAddFolderDelete.Text = "Add Folder Delete";
            btnAddFolderDelete.UseVisualStyleBackColor = false;
            btnAddFolderDelete.Click += btnAddFolderDelete_Click;
            // 
            // btnAddTaskKill
            // 
            btnAddTaskKill.BackColor = Color.FromArgb(63, 81, 181);
            btnAddTaskKill.FlatAppearance.BorderSize = 0;
            btnAddTaskKill.FlatStyle = FlatStyle.Flat;
            btnAddTaskKill.Font = new Font("Segoe UI", 9.75F);
            btnAddTaskKill.ForeColor = Color.White;
            btnAddTaskKill.Location = new Point(12, 530);
            btnAddTaskKill.Name = "btnAddTaskKill";
            btnAddTaskKill.Size = new Size(310, 28);
            btnAddTaskKill.TabIndex = 10;
            btnAddTaskKill.Text = "Add Task Kill";
            btnAddTaskKill.UseVisualStyleBackColor = false;
            btnAddTaskKill.Click += btnAddTaskKill_Click;
            // 
            // btnAddDeleteSpecificFile
            // 
            btnAddDeleteSpecificFile.BackColor = Color.FromArgb(63, 81, 181);
            btnAddDeleteSpecificFile.FlatAppearance.BorderSize = 0;
            btnAddDeleteSpecificFile.FlatStyle = FlatStyle.Flat;
            btnAddDeleteSpecificFile.Font = new Font("Segoe UI", 9.75F);
            btnAddDeleteSpecificFile.ForeColor = Color.White;
            btnAddDeleteSpecificFile.Location = new Point(12, 418);
            btnAddDeleteSpecificFile.Name = "btnAddDeleteSpecificFile";
            btnAddDeleteSpecificFile.Size = new Size(310, 28);
            btnAddDeleteSpecificFile.TabIndex = 11;
            btnAddDeleteSpecificFile.Text = "Add Delete Specific File";
            btnAddDeleteSpecificFile.UseVisualStyleBackColor = false;
            btnAddDeleteSpecificFile.Click += btnAddDeleteSpecificFile_Click;
            // 
            // btnAddDeleteAllFilesinFolder
            // 
            btnAddDeleteAllFilesinFolder.BackColor = Color.FromArgb(63, 81, 181);
            btnAddDeleteAllFilesinFolder.FlatAppearance.BorderSize = 0;
            btnAddDeleteAllFilesinFolder.FlatStyle = FlatStyle.Flat;
            btnAddDeleteAllFilesinFolder.Font = new Font("Segoe UI", 9.75F);
            btnAddDeleteAllFilesinFolder.ForeColor = Color.White;
            btnAddDeleteAllFilesinFolder.Location = new Point(12, 446);
            btnAddDeleteAllFilesinFolder.Name = "btnAddDeleteAllFilesinFolder";
            btnAddDeleteAllFilesinFolder.Size = new Size(310, 28);
            btnAddDeleteAllFilesinFolder.TabIndex = 12;
            btnAddDeleteAllFilesinFolder.Text = "Add Delete All Files in Folder";
            btnAddDeleteAllFilesinFolder.UseVisualStyleBackColor = false;
            btnAddDeleteAllFilesinFolder.Click += btnAddDeleteAllFilesinFolder_Click;
            // 
            // btnAddWaitTime
            // 
            btnAddWaitTime.BackColor = Color.FromArgb(63, 81, 181);
            btnAddWaitTime.FlatAppearance.BorderSize = 0;
            btnAddWaitTime.FlatStyle = FlatStyle.Flat;
            btnAddWaitTime.Font = new Font("Segoe UI", 9.75F);
            btnAddWaitTime.ForeColor = Color.White;
            btnAddWaitTime.Location = new Point(12, 558);
            btnAddWaitTime.Name = "btnAddWaitTime";
            btnAddWaitTime.Size = new Size(310, 28);
            btnAddWaitTime.TabIndex = 13;
            btnAddWaitTime.Text = "Add Wait Time";
            btnAddWaitTime.UseVisualStyleBackColor = false;
            btnAddWaitTime.Click += btnAddWaitTime_Click;
            // 
            // btnExitApplication
            // 
            btnExitApplication.BackColor = Color.FromArgb(97, 97, 97);
            btnExitApplication.FlatAppearance.BorderSize = 0;
            btnExitApplication.FlatStyle = FlatStyle.Flat;
            btnExitApplication.Font = new Font("Segoe UI", 9.75F);
            btnExitApplication.ForeColor = Color.White;
            btnExitApplication.Location = new Point(12, 614);
            btnExitApplication.Name = "btnExitApplication";
            btnExitApplication.Size = new Size(310, 28);
            btnExitApplication.TabIndex = 14;
            btnExitApplication.Text = "Close Program";
            btnExitApplication.UseVisualStyleBackColor = false;
            btnExitApplication.Click += btnExitApplication_Click;
            // 
            // btnAddCreateFolder
            // 
            btnAddCreateFolder.BackColor = Color.FromArgb(63, 81, 181);
            btnAddCreateFolder.FlatAppearance.BorderSize = 0;
            btnAddCreateFolder.FlatStyle = FlatStyle.Flat;
            btnAddCreateFolder.Font = new Font("Segoe UI", 9.75F);
            btnAddCreateFolder.ForeColor = Color.White;
            btnAddCreateFolder.Location = new Point(12, 474);
            btnAddCreateFolder.Name = "btnAddCreateFolder";
            btnAddCreateFolder.Size = new Size(310, 28);
            btnAddCreateFolder.TabIndex = 15;
            btnAddCreateFolder.Text = "Add Create Folder";
            btnAddCreateFolder.UseVisualStyleBackColor = false;
            btnAddCreateFolder.Click += btnAddCreateFolder_Click;
            // 
            // btnVersionControlCopy
            // 
            btnVersionControlCopy.BackColor = Color.FromArgb(63, 81, 181);
            btnVersionControlCopy.FlatAppearance.BorderSize = 0;
            btnVersionControlCopy.FlatStyle = FlatStyle.Flat;
            btnVersionControlCopy.Font = new Font("Segoe UI", 9.75F);
            btnVersionControlCopy.ForeColor = Color.White;
            btnVersionControlCopy.Location = new Point(12, 390);
            btnVersionControlCopy.Name = "btnVersionControlCopy";
            btnVersionControlCopy.Size = new Size(310, 28);
            btnVersionControlCopy.TabIndex = 16;
            btnVersionControlCopy.Text = "Version Control Copy";
            btnVersionControlCopy.UseVisualStyleBackColor = false;
            btnVersionControlCopy.Click += btnVersionControlCopy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(444, 649);
            Controls.Add(btnVersionControlCopy);
            Controls.Add(btnAddCreateFolder);
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
        private Button btnAddCreateFolder;
        private Button btnVersionControlCopy;
    }
}
