using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashing
{
    class Program
    {
        static void Main(string[] args)
        {
           // declaration for hashtable and bool to control loop
            Hashtable hashtable = new Hashtable();
            bool check = true;

            // keep adding strings until -1 is entered
            while (check)
            {
                // read in the data
                Console.WriteLine("enter a value");
                string valueEntered = Console.ReadLine();
                // check for -1
                if (valueEntered == "-1") check = false;
                else
                {
                    // data value is entered
                    // add value into the hash table
                    addToHashTable(ref hashtable, valueEntered);
                }
            }

            // print out the current hash table
            displayHashTable(hashtable);

            Console.ReadLine();


        }

        // method to display the hash table
        static void displayHashTable(Hashtable hashtable) 
        {
            // for each entry in the hash table
            foreach (DictionaryEntry entry in hashtable)
            {
                // print the key (position) and the value
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }
        }

        // the method to add to the hash table
        // it uses the hashing function to calculate position
        // it checks the position is empty
        // if it is the value is written to that position
        static void addToHashTable(ref Hashtable hashtable, string valueEntered) 
        {
            int pos = hashFunction(valueEntered);
            if (hashtable[pos] != null)
            {
                Console.WriteLine("hashing collision!!!!");
            }
            else
            {
                hashtable[pos] = valueEntered;
            }
        }

        // the hash function
        // this is used to calculate the position using the value entered
        // you can use the built in "GetHashCode" with any string
        static int hashFunction(string entry)
        {
            // return the hash code
            return (entry.GetHashCode());
        }
    }
}
