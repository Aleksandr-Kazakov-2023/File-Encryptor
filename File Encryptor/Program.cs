using System;
using System.Windows.Forms;

namespace File_Encryptor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Encryptor.EncryptFile("input.txt", "output.txt", "1234");
            //Encryptor.DecryptFile("output.txt", "decrypted.txt", "1234");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
        }
    }
}