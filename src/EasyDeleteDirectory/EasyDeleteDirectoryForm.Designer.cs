
namespace EasyDeleteDirectory
{
    partial class EasyDeleteDirectoryForm
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
            this.TargetDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.SelectDirectoryButton = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.CurrentSelectedDirectoryLabel = new System.Windows.Forms.Label();
            this.DirectoryNamesLabel = new System.Windows.Forms.Label();
            this.TargetDirectoryNamesTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.DeleteDirectoryButton = new System.Windows.Forms.Button();
            this.ClearDirectoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TargetDirectoryTextBox
            // 
            this.TargetDirectoryTextBox.BackColor = System.Drawing.Color.White;
            this.TargetDirectoryTextBox.Enabled = false;
            this.TargetDirectoryTextBox.Location = new System.Drawing.Point(11, 37);
            this.TargetDirectoryTextBox.Multiline = true;
            this.TargetDirectoryTextBox.Name = "TargetDirectoryTextBox";
            this.TargetDirectoryTextBox.ReadOnly = true;
            this.TargetDirectoryTextBox.Size = new System.Drawing.Size(417, 44);
            this.TargetDirectoryTextBox.TabIndex = 0;
            // 
            // SelectDirectoryButton
            // 
            this.SelectDirectoryButton.Location = new System.Drawing.Point(434, 36);
            this.SelectDirectoryButton.Name = "SelectDirectoryButton";
            this.SelectDirectoryButton.Size = new System.Drawing.Size(129, 46);
            this.SelectDirectoryButton.TabIndex = 1;
            this.SelectDirectoryButton.Text = "Select Directory";
            this.SelectDirectoryButton.UseVisualStyleBackColor = true;
            this.SelectDirectoryButton.Click += new System.EventHandler(this.SelectDirectoryButton_Click);
            // 
            // CurrentSelectedDirectoryLabel
            // 
            this.CurrentSelectedDirectoryLabel.AutoSize = true;
            this.CurrentSelectedDirectoryLabel.Location = new System.Drawing.Point(11, 14);
            this.CurrentSelectedDirectoryLabel.Name = "CurrentSelectedDirectoryLabel";
            this.CurrentSelectedDirectoryLabel.Size = new System.Drawing.Size(204, 14);
            this.CurrentSelectedDirectoryLabel.TabIndex = 2;
            this.CurrentSelectedDirectoryLabel.Text = "Current Selected Directory：";
            // 
            // DirectoryNamesLabel
            // 
            this.DirectoryNamesLabel.AutoSize = true;
            this.DirectoryNamesLabel.Location = new System.Drawing.Point(11, 88);
            this.DirectoryNamesLabel.Name = "DirectoryNamesLabel";
            this.DirectoryNamesLabel.Size = new System.Drawing.Size(318, 14);
            this.DirectoryNamesLabel.TabIndex = 3;
            this.DirectoryNamesLabel.Text = "Target Directory Names（Split with comma）：";
            // 
            // TargetDirectoryNamesTextBox
            // 
            this.TargetDirectoryNamesTextBox.Location = new System.Drawing.Point(11, 112);
            this.TargetDirectoryNamesTextBox.Name = "TargetDirectoryNamesTextBox";
            this.TargetDirectoryNamesTextBox.Size = new System.Drawing.Size(417, 22);
            this.TargetDirectoryNamesTextBox.TabIndex = 4;
            this.TargetDirectoryNamesTextBox.Text = "bin,obj";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.Color.White;
            this.MessageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MessageTextBox.Location = new System.Drawing.Point(11, 166);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ReadOnly = true;
            this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MessageTextBox.Size = new System.Drawing.Size(417, 46);
            this.MessageTextBox.TabIndex = 5;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(11, 145);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(120, 14);
            this.MessageLabel.TabIndex = 6;
            this.MessageLabel.Text = "Output Message：";
            // 
            // DeleteDirectoryButton
            // 
            this.DeleteDirectoryButton.Location = new System.Drawing.Point(434, 165);
            this.DeleteDirectoryButton.Name = "DeleteDirectoryButton";
            this.DeleteDirectoryButton.Size = new System.Drawing.Size(129, 46);
            this.DeleteDirectoryButton.TabIndex = 7;
            this.DeleteDirectoryButton.Text = "Delete Directory";
            this.DeleteDirectoryButton.UseVisualStyleBackColor = true;
            this.DeleteDirectoryButton.Click += new System.EventHandler(this.DeleteDirectoryButton_Click);
            // 
            // ClearDirectoryButton
            // 
            this.ClearDirectoryButton.Location = new System.Drawing.Point(434, 88);
            this.ClearDirectoryButton.Name = "ClearDirectoryButton";
            this.ClearDirectoryButton.Size = new System.Drawing.Size(129, 46);
            this.ClearDirectoryButton.TabIndex = 8;
            this.ClearDirectoryButton.Text = "Clear Selected Directory";
            this.ClearDirectoryButton.UseVisualStyleBackColor = true;
            this.ClearDirectoryButton.Click += new System.EventHandler(this.ClearDirectoryButton_Click);
            // 
            // EasyDeleteDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 221);
            this.Controls.Add(this.ClearDirectoryButton);
            this.Controls.Add(this.DeleteDirectoryButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.TargetDirectoryNamesTextBox);
            this.Controls.Add(this.DirectoryNamesLabel);
            this.Controls.Add(this.CurrentSelectedDirectoryLabel);
            this.Controls.Add(this.SelectDirectoryButton);
            this.Controls.Add(this.TargetDirectoryTextBox);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "EasyDeleteDirectoryForm";
            this.Text = "Easy Delete Directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TargetDirectoryTextBox;
        private System.Windows.Forms.Button SelectDirectoryButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Label CurrentSelectedDirectoryLabel;
        private System.Windows.Forms.Label DirectoryNamesLabel;
        private System.Windows.Forms.TextBox TargetDirectoryNamesTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button DeleteDirectoryButton;
        private System.Windows.Forms.Button ClearDirectoryButton;
    }
}

