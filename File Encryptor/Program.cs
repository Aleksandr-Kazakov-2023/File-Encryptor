using System;
using System.Windows.Forms;

namespace File_Encryptor
{
    static class Program
    {
        /// <summary>
        /// TODO: 
        ///       3. Кодирование любых типоф файлов
        ///       4. Progress Bar или Loading window
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
        }
    }
}