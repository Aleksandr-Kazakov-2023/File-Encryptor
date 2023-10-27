using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace File_Encryptor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private String path = null;

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                pathTextBox.Text = path;
            }
        }

        private bool CheckFields()
        {
            if (path == null)
            {
                MessageBox.Show("Не выбран файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (passwordTextBox.Text.Trim() != repeatPasswordTextBox.Text.Trim())
            {
                MessageBox.Show("Пароли должны совпадать!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (passwordTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Не указан пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        enum FileProcess
        {
            Encode,
            Decode
        }

        private void DoProcess(FileProcess process)
        {
            string outFilePath = null;
            string key = passwordTextBox.Text;

            if (CheckFields())
            {
                if (saveInSameFileCheckBox.Checked)
                    outFilePath = path;
                else
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outFilePath = saveFileDialog.FileName;
                }

                if (outFilePath != null)
                {
                    switch (process)
                    {
                        case FileProcess.Encode:
                            Encryptor.EncryptFile(path, outFilePath, key);
                            break;
                        case FileProcess.Decode:
                            Encryptor.DecryptFile(path, outFilePath, key);
                            break;
                    }
                    if (openPathAfterProcessСheckBox.Checked)
                        Process.Start("explorer.exe", Path.GetDirectoryName(outFilePath));
                }
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            DoProcess(FileProcess.Encode);
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            DoProcess(FileProcess.Decode);
        }
    }
}