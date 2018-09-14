using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AESEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (Aes myAes = Aes.Create())
                {
                    string dataToEncrypt = "123123123123|121231231";
                    byte[] encrypted = Security.EncryptStringToBytes_Aes(dataToEncrypt);

                    Console.WriteLine("Original      : " + dataToEncrypt);
                    Console.WriteLine("Encrypted data: " + Convert.ToBase64String(encrypted));
                    Console.WriteLine("Decrypted data: " + Security.DecryptStringFromBytes_Aes(encrypted));
                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
    }
}
