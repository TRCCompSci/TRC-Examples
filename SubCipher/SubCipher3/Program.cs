using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubCipher3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ciphertext = "";
            string plaintext = "";
            string character = "";
            string alphabet = " abcdefghijklmnopqrstuvxwyz";
            string cipher = "qwertyuiopasdfghjklzxcvbnm ";
            int pos = 0;

            //add choice to enter a different cipher key
            
            //add a choice to Encrypt or Decrypt

            Console.WriteLine("Please enter a message and press enter to encrypt it:");
            plaintext = Console.ReadLine();
            for (int charpos = 0; charpos < plaintext.Length; charpos++)
            {
                character = plaintext.Substring(charpos, 1);
                character.ToLower();
                pos = alphabet.IndexOf(character);
                ciphertext = ciphertext + cipher.Substring(pos, 1);
            }
            Console.WriteLine("Your plain text was:");
            Console.WriteLine(plaintext);
            Console.WriteLine("Your cipher text is:");
            Console.WriteLine(ciphertext);

            //use the code above to Decrypt

            Console.ReadLine();
        }
    }
}
