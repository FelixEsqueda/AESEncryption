using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AESEncryption
{
    class Program
    {
        private static byte[] myKey = Convert.FromBase64String("Ksads234weweBkpuO6sadsdas98D9A8SdhabJSDpwfE=");

        public static void Main()
        {
            try
            {
                string original = "Here is some data to encrypt!";
                using (AesManaged myAes = new AesManaged())
                {
                    byte[] encrypted = Security.EncryptStringToBytes_Aes(original, myKey, myAes.IV);
                    string roundtrip = Security.DecryptStringFromBytes_Aes(encrypted, myKey, myAes.IV);

                    Console.WriteLine("Original:   {0}", original);
                    Console.WriteLine("Encrypted:  {0}", Convert.ToBase64String(encrypted));
                    Console.WriteLine("Round Trip: {0}", roundtrip);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }
    }
}