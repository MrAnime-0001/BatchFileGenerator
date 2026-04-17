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
            pnlSidebar = new Panel();
            lblLibraryTitle = new Label();
            btnLibRoboCopy = new Button();
            btnLibVersionControl = new Button();
            btnLibDeleteFile = new Button();
            btnLibDeleteFolderFiles = new Button();
            btnLibCreateFolder = new Button();
            btnLibDeleteFolder = new Button();
            btnLibStartApp = new Button();
            btnLibKillTask = new Button();
            btnLibWait = new Button();
            btnLibSetPriority = new Button();
            pnlMain = new Panel();
            pnlEditor = new Panel();
            rtbBatchContent = new RichTextBox();
            pnlTopBar = new Panel();
            txtFileExtension = new TextBox();
            lblFileExtension = new Label();
            txtFileName = new TextBox();
            lblFileName = new Label();
            pnlBottomBar = new Panel();
            btnActionReset = new Button();
            btnActionExit = new Button();
            btnActionCreateFile = new Button();
            btnActionCreateClipboard = new Button();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlEditor.SuspendLayout();
            pnlTopBar.SuspendLayout();
            pnlBottomBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(32, 32, 32);
            pnlSidebar.Controls.Add(btnLibSetPriority);
            pnlSidebar.Controls.Add(btnLibWait);
            pnlSidebar.Controls.Add(btnLibKillTask);
            pnlSidebar.Controls.Add(btnLibStartApp);
            pnlSidebar.Controls.Add(btnLibDeleteFolder);
            pnlSidebar.Controls.Add(btnLibCreateFolder);
            pnlSidebar.Controls.Add(btnLibDeleteFolderFiles);
            pnlSidebar.Controls.Add(btnLibDeleteFile);
            pnlSidebar.Controls.Add(btnLibVersionControl);
            pnlSidebar.Controls.Add(btnLibRoboCopy);
            pnlSidebar.Controls.Add(lblLibraryTitle);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Padding = new Padding(10);
            pnlSidebar.Size = new Size(220, 561);
            pnlSidebar.TabIndex = 0;
            // 
            // lblLibraryTitle
            // 
            lblLibraryTitle.AutoSize = true;
            lblLibraryTitle.Dock = DockStyle.Top;
            lblLibraryTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblLibraryTitle.ForeColor = Color.White;
            lblLibraryTitle.Location = new Point(10, 10);
            lblLibraryTitle.Name = "lblLibraryTitle";
            lblLibraryTitle.Padding = new Padding(0, 0, 0, 15);
            lblLibraryTitle.Size = new Size(144, 36);
            lblLibraryTitle.TabIndex = 0;
            lblLibraryTitle.Text = "Command Library";
            // 
            // btnLibRoboCopy
            // 
            btnLibRoboCopy.BackColor = Color.FromArgb(45, 45, 48);
            btnLibRoboCopy.Dock = DockStyle.Top;
            btnLibRoboCopy.FlatAppearance.BorderSize = 0;
            btnLibRoboCopy.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 66);
            btnLibRoboCopy.FlatStyle = FlatStyle.Flat;
            btnLibRoboCopy.Font = new Font("Segoe UI", 9F);
            btnLibRoboCopy.ForeColor = Color.FromArgb(240, 240, 240);
            btnLibRoboCopy.Location = new Point(10, 46);
            btnLibRoboCopy.Margin = new Padding(0, 2, 0, 2);
            btnLibRoboCopy.Name = "btnLibRoboCopy";
            btnLibRoboCopy.Size = new Size(200, 35);
            btnLibRoboCopy.TabIndex = 1;
            btnLibRoboCopy.Text = "Robo Copy";
            btnLibRoboCopy.TextAlign = ContentAlignment.MiddleLeft;
            btnLibRoboCopy.UseVisualStyleBackColor = false;
            btnLibRoboCopy.Click += btnLibRoboCopy_Click;
            // 
            // btnLibVersionControl
            // 
            btnLibVersionControl.BackColor = Color.FromArgb(45, 45, 48);
            btnLibVersionControl.Dock = DockStyle.Top;
            btnLibVersionControl.FlatAppearance.BorderSize = 0;
            btnLibVersionControl.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 66);
            btnLibVersionControl.FlatStyle = FlatStyle.Flat;
            btnLibVersionControl.Font = new Font("Segoe UI", 9F);
            btnLibVersionControl.ForeColor = Color.FromArgb(240, 240, 240);
            btnLibVersionControl.Location = new Point(10, 81);
            btnLibVersionControl.Name = "btnLibVersionControl";
            btnLibVersionControl.Size = new Size(200, 35);
            btnLibVersionControl.TabIndex = 2;
            btnLibVersionControl.Text = "Version Control Copy";
            btnLibVersionControl.TextAlign = ContentAlignment.MiddleLeft;
            btnLibVersionControl.UseVisualStyleBackColor = false;
            btnLibVersionControl.Click += btnLibVersionControl_Click;
            // 
            // btnLibDeleteFile
            // 
            btnLibDeleteFile.BackColor = Color.FromArgb(45, 45, 48);
            btnLibDeleteFile.Dock = DockStyle.Top;
            btnLibDeleteFile.FlatAppearance.BorderSize = 0;
            btnLibDeleteFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 66);
            btnLibDeleteFile.FlatStyle = FlatStyle.Flat;
            btnLibDeleteFile.Font = new Font("Segoe UI", 9F);
            btnLibDeleteFile.ForeColor = Color.FromArgb(240, 240, 240);
            btnLibDeleteFile.Location = new Point(10, 116);
            btnLibDeleteFile.Name = "btnLibDeleteFile";
            btnLibDeleteFile.Size = new Size(200, 35);
            btnLibDeleteFile.TabIndex = 3;
            btnLibDeleteFile.Text = "Delete Specific File";
            btnLibDeleteFile.TextAlign = ContentAlignment.MiddleLeft;
            btnLibDeleteFile.UseVisualStyleBackColor = false;
            btnLibDeleteFile.Click += btnLibDeleteFile_Click;
            // 
            // btnLibDeleteFolderFiles
            // 
            btnLibDeleteFolderFiles.BackColor = Color.FromArgb(45, 45, 48);
            btnLibDeleteFolderFiles.Dock = DockStyle.Top;
            btnLibDeleteFolderFiles.FlatAppearance.BorderSize = 0;
            btnLibDeleteFolderFiles.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 66);
            btnLibDeleteFolderFiles.FlatStyle = FlatStyle.Flat;
            btnLibDeleteFolderFiles.Font = new Font("Segoe UI", 9F);
            btnLibDeleteFolderFiles.ForeColor = Color.FromArgb(240, 240, 240);
            btnLibDeleteFolderFiles.Location = new Point(10, 151);
            btnLibDeleteFolderFiles.Name = "btnLibDeleteFolderFiles";
            btnLibDeleteFolderFiles.Size = new Size(200, 35);
            btnLibDeleteFolderFiles.TabIndex = 4;
            btnLibDeleteFolderFiles.Text = "Delete All Files in Folder";
            btnLibDeleteFolderFiles.TextAlign = ContentAlignment.MiddleLeft;
            btnLibDeleteFolderFiles.UseVisualStyleBackColor = false;
            btnLibDeleteFolderFiles.Click += btnLibDeleteFolderFiles_Click;
            // 
            // btnLibCreateFolder
            // 
            btnLibCreateFolder.BackColor = Color.FromArgb(45, 45, 48);
            btnLibCreateFolder.Dock = DockStyle.Top;
            btnLibCreateFolder.FlatAppearance.BorderSize = 0;
            btnLibCreateFolder.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 66);
            btnLibCreateFolder.FlatStyle = FlatStyle.Flat;
            btnLibCreateFolder.Font = new Font("Segoe UI", 9F);
            btnLibCreateFolder.ForeColor = Color.FromArgb(240, 240, 240);
            btnLibCreateFolder.Location = new Point(10, 186);
            btnLibCreateFolder.Name = "btnLibCreateFolder";
            btnLibCreateFolder.Size = new Size(200, 35);
            btnLibCreateFolder.TabIndex = 5;
            btnLibCreateFolder.Text = "Create Folder";
            btnLibCreateFolder.TextAlign = ContentAlignment.MiddleLeft;
            btnLibCreateFolder.UseVisualStyleBackColor = false;
            btnLibCreateFolder.Click += btnLibCreateFolder_Click;
            // 
            // btnLibDeleteFolder
            // 
            btnLibDeleteFolder.BackColor = Color.FromArgb(45, 45, 48);
            btnLibDeleteFolder.Dock = DockStyle.Top;
            btnLibDeleteFolder.FlatAppearance.BorderSize = 0;
            btnLibDeleteFolder.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 66);
            btnLibDeleteFolder.FlatStyle = FlatStyle.Flat;
            btnLibDeleteFolder.Font = new Font("Segoe UI", 9F);
            btnLibDeleteFolder.ForeColor = Color.FromArgb(240, 240, 240);
            btnLibDeleteFolder.Location = new Point(10, 221);
            btnLibDeleteFolder.Name = "btnLibDeleteFolder";
            btnLibDeleteFolder.Size = new Size(200, 35);
            btnLibDeleteFolder.TabIndex = 6;
            btnLibDeleteFolder.Text = "Delete Folder Tree";
            btnLibDeleteFolder.TextAlign = ContentAlignment.MiddleLeft;
            btnLibDeleteFolder.UseVisualStyleBackColor = false;
            btnLibDeleteFolder.Click += btnLibDeleteFolder_Click;
            // 
            // btnLibStartApp
            // 
            btnLibStartApp.BackColor = Color.FromArgb(45, 45, 48);
            btnLibStartApp.Dock = DockStyle.Top;
            btnLibStartApp.FlatAppearance.BorderSize = 0;
            btnLibStartApp.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 66);
            btnLibStartApp.FlatStyle = FlatStyle.Flat;
            btnLibStartApp.Font = new Font("Segoe UI", 9F);
            btnLibStartApp.ForeColor = Color.FromArgb(240, 240, 240);
            btnLibStartApp.Location = new Point(10, 256);
            btnLibStartApp.Name = "btnLibStartApp";
            btnLibStartApp.Size = new Size(200, 35);
            btnLibStartApp.TabIndex = 7;
            btnLibStartApp.Text = "Start Application";
            btnLibStartApp.TextAlign = ContentAlignment.MiddleLeft;
            btnLibStartApp.UseVisualStyleBackColor = false;
            btnLibStartApp.Click += btnLibStartApp_Click;
            // 
            // btnLibKillTask
            // 
            btnLibKillTask.BackColor = Color.FromArgb(45, 45, 48);
            btnLibKillTask.Dock = DockStyle.Top;
            btnLibKillTask.FlatAppearance.BorderSize = 0;
            btnLibKillTask.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 66);
            btnLibKillTask.FlatStyle = FlatStyle.Flat;
            btnLibKillTask.Font = new Font("Segoe UI", 9F);
            btnLibKillTask.ForeColor = Color.FromArgb(240, 240, 240);
            btnLibKillTask.Location = new Point(10, 291);
            btnLibKillTask.Name = "btnLibKillTask";
            btnLibKillTask.Size = new Size(200, 35);
            btnLibKillTask.TabIndex = 8;
            btnLibKillTask.Text = "Kill Task";
            btnLibKillTask.TextAlign = ContentAlignment.MiddleLeft;
            btnLibKillTask.UseVisualStyleBackColor = false;
            btnLibKillTask.Click += btnLibKillTask_Click;
            // 
            // btnLibWait
            // 
            btnLibWait.BackColor = Color.FromArgb(45, 45, 48);
            btnLibWait.Dock = DockStyle.Top;
            btnLibWait.FlatAppearance.BorderSize = 0;
            btnLibWait.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 66);
            btnLibWait.FlatStyle = FlatStyle.Flat;
            btnLibWait.Font = new Font("Segoe UI", 9F);
            btnLibWait.ForeColor = Color.FromArgb(240, 240, 240);
            btnLibWait.Location = new Point(10, 326);
            btnLibWait.Name = "btnLibWait";
            btnLibWait.Size = new Size(200, 35);
            btnLibWait.TabIndex = 9;
            btnLibWait.Text = "Wait Time";
            btnLibWait.TextAlign = ContentAlignment.MiddleLeft;
            btnLibWait.UseVisualStyleBackColor = false;
            btnLibWait.Click += btnLibWait_Click;
            // 
            // btnLibSetPriority
            // 
            btnLibSetPriority.BackColor = Color.FromArgb(45, 45, 48);
            btnLibSetPriority.Dock = DockStyle.Top;
            btnLibSetPriority.FlatAppearance.BorderSize = 0;
            btnLibSetPriority.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 66);
            btnLibSetPriority.FlatStyle = FlatStyle.Flat;
            btnLibSetPriority.Font = new Font("Segoe UI", 9F);
            btnLibSetPriority.ForeColor = Color.FromArgb(240, 240, 240);
            btnLibSetPriority.Location = new Point(10, 361);
            btnLibSetPriority.Name = "btnLibSetPriority";
            btnLibSetPriority.Size = new Size(200, 35);
            btnLibSetPriority.TabIndex = 10;
            btnLibSetPriority.Text = "Set Process Priority";
            btnLibSetPriority.TextAlign = ContentAlignment.MiddleLeft;
            btnLibSetPriority.UseVisualStyleBackColor = false;
            btnLibSetPriority.Click += btnLibSetPriority_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlEditor);
            pnlMain.Controls.Add(pnlTopBar);
            pnlMain.Controls.Add(pnlBottomBar);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(220, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(664, 561);
            pnlMain.TabIndex = 1;
            // 
            // pnlEditor
            // 
            pnlEditor.Controls.Add(rtbBatchContent);
            pnlEditor.Dock = DockStyle.Fill;
            pnlEditor.Location = new Point(0, 60);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Padding = new Padding(10);
            pnlEditor.Size = new Size(664, 431);
            pnlEditor.TabIndex = 1;
            // 
            // rtbBatchContent
            // 
            rtbBatchContent.BackColor = Color.FromArgb(30, 30, 30);
            rtbBatchContent.BorderStyle = BorderStyle.None;
            rtbBatchContent.Dock = DockStyle.Fill;
            rtbBatchContent.Font = new Font("Consolas", 11.25F);
            rtbBatchContent.ForeColor = Color.FromArgb(220, 220, 220);
            rtbBatchContent.Location = new Point(10, 10);
            rtbBatchContent.Name = "rtbBatchContent";
            rtbBatchContent.Size = new Size(644, 411);
            rtbBatchContent.TabIndex = 0;
            rtbBatchContent.Text = "";
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(28, 28, 28);
            pnlTopBar.Controls.Add(txtFileExtension);
            pnlTopBar.Controls.Add(lblFileExtension);
            pnlTopBar.Controls.Add(txtFileName);
            pnlTopBar.Controls.Add(lblFileName);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(664, 60);
            pnlTopBar.TabIndex = 0;
            // 
            // txtFileExtension
            // 
            txtFileExtension.BackColor = Color.FromArgb(45, 45, 48);
            txtFileExtension.BorderStyle = BorderStyle.FixedSingle;
            txtFileExtension.Font = new Font("Segoe UI", 9.75F);
            txtFileExtension.ForeColor = Color.White;
            txtFileExtension.Location = new Point(474, 18);
            txtFileExtension.Name = "txtFileExtension";
            txtFileExtension.Size = new Size(80, 25);
            txtFileExtension.TabIndex = 3;
            txtFileExtension.Text = "bat";
            // 
            // lblFileExtension
            // 
            lblFileExtension.AutoSize = true;
            lblFileExtension.ForeColor = Color.FromArgb(160, 160, 160);
            lblFileExtension.Location = new Point(410, 22);
            lblFileExtension.Name = "lblFileExtension";
            lblFileExtension.Size = new Size(58, 15);
            lblFileExtension.TabIndex = 2;
            lblFileExtension.Text = "Extension";
            // 
            // txtFileName
            // 
            txtFileName.BackColor = Color.FromArgb(45, 45, 48);
            txtFileName.BorderStyle = BorderStyle.FixedSingle;
            txtFileName.Font = new Font("Segoe UI", 9.75F);
            txtFileName.ForeColor = Color.White;
            txtFileName.Location = new Point(80, 18);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(310, 25);
            txtFileName.TabIndex = 1;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.ForeColor = Color.FromArgb(160, 160, 160);
            lblFileName.Location = new Point(14, 22);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(60, 15);
            lblFileName.TabIndex = 0;
            lblFileName.Text = "File Name";
            // 
            // pnlBottomBar
            // 
            pnlBottomBar.BackColor = Color.FromArgb(28, 28, 28);
            pnlBottomBar.Controls.Add(btnActionReset);
            pnlBottomBar.Controls.Add(btnActionExit);
            pnlBottomBar.Controls.Add(btnActionCreateFile);
            pnlBottomBar.Controls.Add(btnActionCreateClipboard);
            pnlBottomBar.Dock = DockStyle.Bottom;
            pnlBottomBar.Location = new Point(0, 491);
            pnlBottomBar.Name = "pnlBottomBar";
            pnlBottomBar.Size = new Size(664, 70);
            pnlBottomBar.TabIndex = 2;
            // 
            // btnActionReset
            // 
            btnActionReset.BackColor = Color.FromArgb(63, 63, 70);
            btnActionReset.FlatAppearance.BorderSize = 0;
            btnActionReset.FlatStyle = FlatStyle.Flat;
            btnActionReset.Font = new Font("Segoe UI", 9F);
            btnActionReset.ForeColor = Color.White;
            btnActionReset.Location = new Point(380, 15);
            btnActionReset.Name = "btnActionReset";
            btnActionReset.Size = new Size(120, 40);
            btnActionReset.TabIndex = 3;
            btnActionReset.Text = "Reset";
            btnActionReset.UseVisualStyleBackColor = false;
            btnActionReset.Click += btnActionReset_Click;
            // 
            // btnActionExit
            // 
            btnActionExit.BackColor = Color.FromArgb(63, 63, 70);
            btnActionExit.FlatAppearance.BorderSize = 0;
            btnActionExit.FlatStyle = FlatStyle.Flat;
            btnActionExit.Font = new Font("Segoe UI", 9F);
            btnActionExit.ForeColor = Color.White;
            btnActionExit.Location = new Point(510, 15);
            btnActionExit.Name = "btnActionExit";
            btnActionExit.Size = new Size(120, 40);
            btnActionExit.TabIndex = 2;
            btnActionExit.Text = "Exit";
            btnActionExit.UseVisualStyleBackColor = false;
            btnActionExit.Click += btnActionExit_Click;
            // 
            // btnActionCreateFile
            // 
            btnActionCreateFile.BackColor = Color.FromArgb(0, 122, 204);
            btnActionCreateFile.FlatAppearance.BorderSize = 0;
            btnActionCreateFile.FlatStyle = FlatStyle.Flat;
            btnActionCreateFile.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnActionCreateFile.ForeColor = Color.White;
            btnActionCreateFile.Location = new Point(190, 15);
            btnActionCreateFile.Name = "btnActionCreateFile";
            btnActionCreateFile.Size = new Size(170, 40);
            btnActionCreateFile.TabIndex = 1;
            btnActionCreateFile.Text = "Create Executable";
            btnActionCreateFile.UseVisualStyleBackColor = false;
            btnActionCreateFile.Click += btnActionCreateFile_Click;
            // 
            // btnActionCreateClipboard
            // 
            btnActionCreateClipboard.BackColor = Color.FromArgb(0, 122, 204);
            btnActionCreateClipboard.FlatAppearance.BorderSize = 0;
            btnActionCreateClipboard.FlatStyle = FlatStyle.Flat;
            btnActionCreateClipboard.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnActionCreateClipboard.ForeColor = Color.White;
            btnActionCreateClipboard.Location = new Point(14, 15);
            btnActionCreateClipboard.Name = "btnActionCreateClipboard";
            btnActionCreateClipboard.Size = new Size(170, 40);
            btnActionCreateClipboard.TabIndex = 0;
            btnActionCreateClipboard.Text = "Copy to Clipboard";
            btnActionCreateClipboard.UseVisualStyleBackColor = false;
            btnActionCreateClipboard.Click += btnActionCreateClipboard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(884, 561);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Batch Script Architect";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlEditor.ResumeLayout(false);
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlBottomBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblLibraryTitle;
        private Button btnLibRoboCopy;
        private Button btnLibVersionControl;
        private Button btnLibDeleteFile;
        private Button btnLibDeleteFolderFiles;
        private Button btnLibCreateFolder;
        private Button btnLibDeleteFolder;
        private Button btnLibStartApp;
        private Button btnLibKillTask;
        private Button btnLibWait;
        private Button btnLibSetPriority;
        private Panel pnlMain;
        private Panel pnlTopBar;
        private TextBox txtFileName;
        private Label lblFileName;
        private TextBox txtFileExtension;
        private Label lblFileExtension;
        private Panel pnlEditor;
        private RichTextBox rtbBatchContent;
        private Panel pnlBottomBar;
        private Button btnActionCreateClipboard;
        private Button btnActionCreateFile;
        private Button btnActionExit;
        private Button btnActionReset;
    }
}
