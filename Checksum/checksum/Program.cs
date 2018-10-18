using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace checksum
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Please enter your full name ");
            name = Console.ReadLine();
            Console.WriteLine("the hash of your name is:");
            Console.WriteLine(name.GetHashCode());

            Console.WriteLine("the MD5 of your name is: ");
            Console.WriteLine(CalculateMD5Hash(name));

            Console.WriteLine("the SHA256 of your name is: ");
            Console.WriteLine(getHashSha256(name));

            Console.ReadLine();
        }

        static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }

        public static string getHashSha256(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
    }
}
