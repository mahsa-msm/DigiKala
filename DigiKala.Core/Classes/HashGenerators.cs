using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
namespace DigiKala.Core.Classes
{
    public  static class HashGenerators
    {
        public static string MD5Encodeing(string password)
        {
            Byte[] mainBytes;
            Byte[] encodeBytes;
            MD5 mD5;
            mD5 = new MD5CryptoServiceProvider();
            mainBytes = ASCIIEncoding.Default.GetBytes(password );
            encodeBytes = mD5.ComputeHash(mainBytes);
            return BitConverter.ToString(encodeBytes);

        }
    }
}
