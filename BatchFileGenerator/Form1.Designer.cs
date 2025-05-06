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
            lblTextToCopy = new Label();
            txtFileName = new TextBox();
            txtTextToCopy = new TextBox();
            btnGenerate = new Button();
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
            // lblTextToCopy
            // 
            lblTextToCopy.AutoSize = true;
            lblTextToCopy.ForeColor = Color.White;
            lblTextToCopy.Location = new Point(12, 44);
            lblTextToCopy.Name = "lblTextToCopy";
            lblTextToCopy.Size = new Size(75, 15);
            lblTextToCopy.TabIndex = 1;
            lblTextToCopy.Text = "Text To Copy";
            // 
            // txtFileName
            // 
            txtFileName.ForeColor = Color.Black;
            txtFileName.Location = new Point(93, 12);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(129, 23);
            txtFileName.TabIndex = 2;
            // 
            // txtTextToCopy
            // 
            txtTextToCopy.ForeColor = Color.Black;
            txtTextToCopy.Location = new Point(93, 41);
            txtTextToCopy.Name = "txtTextToCopy";
            txtTextToCopy.Size = new Size(129, 23);
            txtTextToCopy.TabIndex = 3;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(12, 70);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(210, 23);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate Batch File";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(234, 100);
            Controls.Add(btnGenerate);
            Controls.Add(txtTextToCopy);
            Controls.Add(txtFileName);
            Controls.Add(lblTextToCopy);
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
        private Label lblTextToCopy;
        private TextBox txtFileName;
        private TextBox txtTextToCopy;
        private Button btnGenerate;
    }
}
