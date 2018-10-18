using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VernamCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string ciphertext = "";
            string plaintext = "";
            char cipherchar;
            int cipherascii;
            string key = "the quick brown fox jumped over the lazy dog";

            Console.WriteLine("Please enter a message and press enter to encrypt it:");
            plaintext = Console.ReadLine();

            //add option to change the key

            //check the size of the key (it should be the same size or bigger than the plaintext

            int[] asciiValues = new int[plaintext.Length];
            
            for (int charpos = 0; charpos < plaintext.Length; charpos++)
            {
                cipherascii = plaintext[charpos] ^ key[charpos]; // ^ is the xor character in C#
                cipherchar = (char)cipherascii; // this is casting, it changes cipherascii to a char for this line only
                asciiValues[charpos] = cipherascii;
                ciphertext = ciphertext + cipherchar;
                Console.WriteLine("plain: "+plaintext[charpos]);
                Console.WriteLine("key: " + key[charpos]);
                Console.WriteLine("cipher: "+cipherascii);
            }

            Console.WriteLine("Your plain text was:");
            Console.WriteLine(plaintext);
            Console.WriteLine("Your cipher text is:");
            Console.WriteLine(ciphertext);
            Console.WriteLine("Or as ascii values:");
            for (int value = 0; value < ciphertext.Length;value++)
            {
                Console.WriteLine(asciiValues[value]);
            }

            //add the code to decrypt

            Console.ReadLine();
        }
    }
}
