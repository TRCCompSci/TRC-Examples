using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string ciphertext = "";
            string plaintext = "";
            string character = "";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int shift = 0;
            int pos, newpos = 0;

            //Add a choice of Encrypt or Decrypt

            Console.WriteLine("Enter your shift value:");
            shift = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a message and press enter to encrypt it:");
            plaintext = Console.ReadLine();
            for (int charpos = 0; charpos < plaintext.Length; charpos++)
            {
                character = plaintext.Substring(charpos, 1);
                character = character.ToLower();
                if (character != " ")
                {
                    pos = alphabet.IndexOf(character);
                    newpos = pos + shift;
                    if (newpos > 25)
                        newpos = newpos - 26;
                    ciphertext = ciphertext + alphabet.Substring(newpos, 1);
                }
                else ciphertext = ciphertext + " ";
             }
            Console.WriteLine("Your plain text was:");
            Console.WriteLine(plaintext);
            Console.WriteLine("Your cipher text is:");
            Console.WriteLine(ciphertext);

            //The above code is to Encrypt, use it to write the Decrypt code

            //add an option to brute force attack the caesar cipher

            Console.ReadLine();
        }
    }
}
