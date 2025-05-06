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
            btnCopyToClipboard.Location = new Point(12, 362);
            btnCopyToClipboard.Name = "btnCopyToClipboard";
            btnCopyToClipboard.Size = new Size(310, 23);
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
            btnCreateExecutableBatch.Location = new Point(12, 391);
            btnCreateExecutableBatch.Name = "btnCreateExecutableBatch";
            btnCreateExecutableBatch.Size = new Size(310, 23);
            btnCreateExecutableBatch.TabIndex = 6;
            btnCreateExecutableBatch.Text = "Create Executable Batch File";
            btnCreateExecutableBatch.UseVisualStyleBackColor = true;
            btnCreateExecutableBatch.Click += btnCreateExecutableBatch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(336, 421);
            Controls.Add(btnCreateExecutableBatch);
            Controls.Add(rtbTextToCopy);
            Controls.Add(btnCopyToClipboard);
            Controls.Add(txtFileName);
            Controls.Add(lblFileName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Batch Maker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFileName;
        private TextBox txtFileName;
        private Button btnCopyToClipboard;
        private RichTextBox rtbTextToCopy;
        private Button btnCreateExecutableBatch;
    }
}
