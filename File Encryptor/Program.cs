using System;
using System.Windows.Forms;

namespace File_Encryptor
{
    static class Program
    {
        /// <summary>
        /// TODO:
        ///       2. Сообщение об неуспешном выполнении (может быть не всплывающим)
        ///       3. Кодирование любых типоф файлов
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