using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string outFilePath;
            string key = passwordTextBox.Text;
            if (path == null)
            {
                MessageBox.Show("Не выбран файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outFilePath = saveFileDialog.FileName;
                Encryptor.EncryptFile(path, outFilePath, key);
                
                Process.Start("explorer.exe", Path.GetDirectoryName(outFilePath));
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}