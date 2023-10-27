namespace File_Encryptor
{
    partial class MainForm
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
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptButton = new System.Windows.Forms.Button();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openPathAfterProcessСheckBox = new System.Windows.Forms.CheckBox();
            this.saveInSameFileCheckBox = new System.Windows.Forms.CheckBox();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.passwordTextBox.Location = new System.Drawing.Point(210, 137);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(205, 33);
            this.passwordTextBox.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // loadFileButton
            // 
            this.loadFileButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.loadFileButton.Location = new System.Drawing.Point(436, 53);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(205, 40);
            this.loadFileButton.TabIndex = 1;
            this.loadFileButton.Text = "Загрузить файл...";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.encryptButton.Location = new System.Drawing.Point(83, 278);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(205, 40);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "Зашифровать...";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(789, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.pathLabel.Location = new System.Drawing.Point(28, 61);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(57, 25);
            this.pathLabel.TabIndex = 4;
            this.pathLabel.Text = "Путь:";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem, this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(654, 29);
            this.mainMenuStrip.TabIndex = 5;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(118, 25);
            this.aboutToolStripMenuItem.Text = "О программе";
            // 
            // decryptButton
            // 
            this.decryptButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.decryptButton.Location = new System.Drawing.Point(358, 278);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(205, 40);
            this.decryptButton.TabIndex = 6;
            this.decryptButton.Text = "Расшифровать...";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(210, 193);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.PasswordChar = '*';
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(205, 33);
            this.repeatPasswordTextBox.TabIndex = 7;
            // 
            // pathTextBox
            // 
            this.pathTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.pathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.pathTextBox.Location = new System.Drawing.Point(101, 61);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(314, 26);
            this.pathTextBox.TabIndex = 8;
            this.pathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // openPathAfterProcessСheckBox
            // 
            this.openPathAfterProcessСheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.openPathAfterProcessСheckBox.Location = new System.Drawing.Point(83, 352);
            this.openPathAfterProcessСheckBox.Name = "openPathAfterProcessСheckBox";
            this.openPathAfterProcessСheckBox.Size = new System.Drawing.Size(433, 27);
            this.openPathAfterProcessСheckBox.TabIndex = 9;
            this.openPathAfterProcessСheckBox.Text = "Открыть папку с файлом после завершения";
            this.openPathAfterProcessСheckBox.UseVisualStyleBackColor = true;
            // 
            // saveInSameFileCheckBox
            // 
            this.saveInSameFileCheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.saveInSameFileCheckBox.Location = new System.Drawing.Point(83, 385);
            this.saveInSameFileCheckBox.Name = "saveInSameFileCheckBox";
            this.saveInSameFileCheckBox.Size = new System.Drawing.Size(287, 29);
            this.saveInSameFileCheckBox.TabIndex = 10;
            this.saveInSameFileCheckBox.Text = "Сохранять в исходный файл";
            this.saveInSameFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 428);
            this.Controls.Add(this.saveInSameFileCheckBox);
            this.Controls.Add(this.openPathAfterProcessСheckBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "File Encryptor";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox openPathAfterProcessСheckBox;
        private System.Windows.Forms.CheckBox saveInSameFileCheckBox;

        private System.Windows.Forms.SaveFileDialog saveFileDialog;

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.TextBox pathTextBox;
    }
}