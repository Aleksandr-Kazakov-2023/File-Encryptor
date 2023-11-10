using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using File_Encryptor.Properties;

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

        private delegate DialogResult ShowSaveFileDialogInvoker();

        private void DoProcess(FileProcess process)
        {
            string outFilePath = null;
            string key = passwordTextBox.Text;
            ShowSaveFileDialogInvoker invoker = saveFileDialog.ShowDialog;
            if (CheckFields())
            {
                if (saveInSameFileCheckBox.Checked)
                    outFilePath = path;
                else if (Invoke(invoker).Equals(DialogResult.OK))
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
                    resultPictureBox.Image = Resources.success;
                    resultPictureBox.Invalidate();
                    Task.Factory.StartNew(() => Thread.Sleep(6000))
                        .ContinueWith((t) =>
                        {
                            resultPictureBox.Image = null;
                        }, TaskContinuationOptions.ExecuteSynchronously);
                }
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                encryptButton.Image = Resources.loading;
                encryptButton.ImageAlign = ContentAlignment.MiddleCenter;
                encryptButton.Text = "";
                DoProcess(FileProcess.Encode);
                encryptButton.Text = "Зашифровать...";
                encryptButton.Image = null;
                passwordTextBox.Text = "";
                repeatPasswordTextBox.Text = "";
                pathTextBox.Text = "";
                path = null;
            });
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            Task decrypt = new Task(() =>
            {
                Image img = Resources.loading;
                decryptButton.Image = img;
                decryptButton.ImageAlign = ContentAlignment.MiddleCenter;
                decryptButton.Text = "";
                DoProcess(FileProcess.Decode);
                decryptButton.Text = "Расшифровать...";
                decryptButton.Image = null;
                passwordTextBox.Text = "";
                repeatPasswordTextBox.Text = "";
                pathTextBox.Text = "";
                path = null;
            });
            decrypt.Start();
        }
    }
}