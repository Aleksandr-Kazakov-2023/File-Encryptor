using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace File_Encryptor
{
    public class Encryptor
    {
        private static char _fillChar = '$';
        private static int _keyLength = 32;

        public static string PasswordPrepare(string password)
        {
            var resultPassword = password ?? "";
            if (resultPassword.Length < _keyLength)
                resultPassword += new string(_fillChar, _keyLength - resultPassword.Length);
            else if (resultPassword.Length > _keyLength)
                resultPassword = resultPassword.Substring(0, _keyLength);
            return resultPassword;
        }
        
        public static string Encrypt(string str, string key)
        {
            key = PasswordPrepare(key);
            byte[] strBytes = Encoding.UTF8.GetBytes(str);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            RijndaelManaged rijndael = new RijndaelManaged();
            rijndael.Key = keyBytes;
            rijndael.Mode = CipherMode.ECB;
            rijndael.Padding = PaddingMode.PKCS7;
            ICryptoTransform cryptoTransform = rijndael.CreateEncryptor();
            byte[] result = cryptoTransform.TransformFinalBlock(strBytes, 0, strBytes.Length);
            return Convert.ToBase64String(result, 0, result.Length);
        }

        public static string Decrypt(string str, string key)
        {
            key = PasswordPrepare(key);
            byte[] strBytes = Convert.FromBase64String(str);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            RijndaelManaged rijndael = new RijndaelManaged();
            rijndael.Key = keyBytes;
            rijndael.Mode = CipherMode.ECB;
            rijndael.Padding = PaddingMode.PKCS7;
            ICryptoTransform cryptoTransform = rijndael.CreateDecryptor();
            byte[] result = cryptoTransform.TransformFinalBlock(strBytes, 0, strBytes.Length);
            return Encoding.UTF8.GetString(result, 0, result.Length);
        }

        public static void EncryptFile(string inPath, string outPath, string key)
        {
            StreamReader inStream = new StreamReader(inPath);
            StreamWriter outStream;

            if (inPath == outPath)
            {
                outStream = new StreamWriter("tmp.dat");
            }
            else
            {
                outStream = new StreamWriter(outPath);
            }

            while (!inStream.EndOfStream)
            {
                String line = inStream.ReadLine();
                outStream.WriteLine(Encrypt(line, key));
            }
            inStream.Close();
            outStream.Close();
            if (inPath == outPath)
            {
                File.Delete(inPath);
                File.Move("tmp.dat", inPath);
            }
        }
        
        public static void DecryptFile(string inPath, string outPath, string key)
        {
            StreamReader inStream = new StreamReader(inPath);
            StreamWriter outStream;

            if (inPath == outPath)
            {
                outStream = new StreamWriter("tmp.dat");
            }
            else
            {
                outStream = new StreamWriter(outPath);
            }
            
            while (!inStream.EndOfStream)
            {
                String line = inStream.ReadLine();
                outStream.WriteLine(Decrypt(line, key));
            }
            inStream.Close();
            outStream.Close();
            if (inPath == outPath)
            {
                File.Delete(inPath);
                File.Move("tmp.dat", inPath);
            }
        }
    }
}