using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    class Program
    {
        static string[] TheList = new string[20]; // Size of array, can set to any size

        static void OutputList(string[] list) // method to display the list
        {
            Console.WriteLine("The List:");
            for (int i = 0; i < TheList.Length; i++)
            {
                if (list[i] != null)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }

        static void AddItem(string item) // Method to add a value to the end of the list
        {
            for (int i = 0; i < TheList.Length; i++)
            {
                if (TheList[i]==null)
                {
                    TheList[i] = item;
                    break;
                }
            }
        }

        static void RemoveItem(string item) // Method to remove item from the list
        {
            // cycle through each element 
            for (int i = 0; i < TheList.Length; i++)
            {
                // find the item to delete
                if (TheList[i] == item)
                {
                    // cycle from the end of the list to the location
                    for (int j = 0; j < (TheList.Length-(i+1)); j++)
                    {
                        // shift each location up
                        TheList[i+j] = TheList[i+j+1];
                    }
                    
                    break;
                }
            }
        }
        // method to insert into the list
        // if before is true it will be before the other item
        // if not it will be after the other item
        static void InsertItem(string newitem, string otheritem, bool before) 
        {
            // cycle through the list
            for (int i = 0; i < TheList.Length; i++)
            {
                // locate other item
                if (TheList[i] == otheritem)
                {
                    if (before)
                    {
                        // shift each item
                        for (int j = TheList.Length; j > i; j--)
                        {
                            TheList[j - 1] = TheList[j - 2];
                        }

                        // write new item
                        TheList[i] = newitem;
                    }
                    else
                    {
                        // shift each item
                        for (int j = TheList.Length; j > i + 1; j--)
                        {
                            TheList[j - 1] = TheList[j - 2];
                        }

                        // write new item
                        TheList[i + 1] = newitem;
                    }
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            // Output the list
            OutputList(TheList);

            // add items to the list
            AddItem("Wayne");
            AddItem("Bob");
            AddItem("Geoff");
            AddItem("Steve");
            AddItem("Ben");

            OutputList(TheList);

            // remove an item from the list
            RemoveItem("Geoff");

            // insert item dave after bob
            InsertItem("Dave", "Bob",false);

            // insert item mick before steve
            InsertItem("Mick", "Steve", true);

            OutputList(TheList);
            Console.ReadLine();
        }
    }
}
