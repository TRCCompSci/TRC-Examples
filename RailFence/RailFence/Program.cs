    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailFence
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfRailFence = 3;
            int count1, count2 = 0;

            // add choice of encrypt or decrypt

            // allow user to enter their own plaintext
            string plainText = "hello world";

            // allow user to enter the size of the rail fence

            string cipherText = "";

            for (count1 = 0; count1 < sizeOfRailFence; count1++)
            {
                count2 = count1;
                while(count2<plainText.Length)
                {
                    cipherText += plainText[count2];
                    count2 += sizeOfRailFence;
                }
            }
            Console.WriteLine(cipherText);

            // add the code to decrypt with given rail fence size

            // You should find the length of the cipherText (ie cipherText.Length)

            // You should divide this by the original key (ie cipherText.Length / 3)
            // this should be stored as a double

            // round up the value from the above calculation (YOU ALWAYS NEED TO ROUND UP)
            // try Math.Ceiling() (Math.Round won't work)

            // now use this value as the sizeOfRailFence (you will need to convert it to an integer

            // copy the whole for loop above
            // now swap references to plainText to cipherText & vice versa

            // output the plainText

            // add a feature to enter some cipher text and try different rail fence sizes

            Console.ReadLine();
        }
    }
}
