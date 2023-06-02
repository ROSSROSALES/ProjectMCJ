namespace ProjectMCJ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadIDButton = new System.Windows.Forms.Button();
            this.loadIDTextBox = new System.Windows.Forms.TextBox();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.folderPathTextBox = new System.Windows.Forms.TextBox();
            this.loadIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadIDButton
            // 
            this.loadIDButton.Location = new System.Drawing.Point(12, 51);
            this.loadIDButton.Name = "loadIDButton";
            this.loadIDButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loadIDButton.Size = new System.Drawing.Size(91, 23);
            this.loadIDButton.TabIndex = 0;
            this.loadIDButton.Text = "Load ID";
            this.loadIDButton.UseVisualStyleBackColor = true;
            this.loadIDButton.Click += new System.EventHandler(this.findTarget);
            // 
            // loadIDTextBox
            // 
            this.loadIDTextBox.Location = new System.Drawing.Point(109, 53);
            this.loadIDTextBox.Name = "loadIDTextBox";
            this.loadIDTextBox.Size = new System.Drawing.Size(225, 20);
            this.loadIDTextBox.TabIndex = 1;
            this.loadIDTextBox.TextChanged += new System.EventHandler(this.loadIDTextBox_TextChanged);
            // 
            // targetTextBox
            // 
            this.targetTextBox.Location = new System.Drawing.Point(110, 79);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.ReadOnly = true;
            this.targetTextBox.Size = new System.Drawing.Size(224, 20);
            this.targetTextBox.TabIndex = 2;
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(66, 82);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(38, 13);
            this.targetLabel.TabIndex = 3;
            this.targetLabel.Text = "Target";
            this.targetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(12, 12);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(91, 23);
            this.selectFolderButton.TabIndex = 4;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderPath);
            // 
            // folderPathTextBox
            // 
            this.folderPathTextBox.Location = new System.Drawing.Point(109, 14);
            this.folderPathTextBox.Name = "folderPathTextBox";
            this.folderPathTextBox.ReadOnly = true;
            this.folderPathTextBox.Size = new System.Drawing.Size(224, 20);
            this.folderPathTextBox.TabIndex = 5;
            // 
            // loadIDLabel
            // 
            this.loadIDLabel.AutoSize = true;
            this.loadIDLabel.Location = new System.Drawing.Point(340, 56);
            this.loadIDLabel.Name = "loadIDLabel";
            this.loadIDLabel.Size = new System.Drawing.Size(159, 13);
            this.loadIDLabel.TabIndex = 6;
            this.loadIDLabel.Text = "Input must be 9 characters long.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 269);
            this.Controls.Add(this.loadIDLabel);
            this.Controls.Add(this.folderPathTextBox);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.loadIDTextBox);
            this.Controls.Add(this.loadIDButton);
            this.Name = "Form1";
            this.Text = "MCJ Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadIDButton;
        private System.Windows.Forms.TextBox loadIDTextBox;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.TextBox folderPathTextBox;
        private System.Windows.Forms.Label loadIDLabel;
    }
}

