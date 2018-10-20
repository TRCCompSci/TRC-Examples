using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProgram
{
    class Program
    {
         static void Main(string[] args)
        {
            // declare variables
            const int MaxListSize = 1000;
            string MenuItem;
            int[] NumList = new int[MaxListSize];
            // program loop
            do
            {
                // display menu and get menu choice
                MenuItem = GetMenuChoice();
                // do something with the menu choice
                switch (MenuItem)
                {
                    case "1":
                        Array.Clear(NumList,0,0);
                        Random RanNum = new Random();
                        for (int i = 0; i < MaxListSize; i++) {
                            NumList[i] = RanNum.Next(1,10000);
                        } 
                        break;
                    case "2":
                        for (int i = 0; i < MaxListSize; i++)
                        {
                            Console.WriteLine(NumList[i]);
                        }
                        break;
                    case "3":
                        SortList(ref NumList);
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("invalid selection");
                        break;
                }
            }
            while (MenuItem != "4");
            Console.WriteLine("end of program");
            Console.ReadLine();
        }

        public static void SortList(ref int[] TheList)
        {

        }

        public static string GetMenuChoice()
        {
            //display menu
            Console.WriteLine();
            Console.WriteLine("1) Generate List");
            Console.WriteLine("2) Display List");
            Console.WriteLine("3) Sort List");
            Console.WriteLine("4) Exit program");
            Console.WriteLine();
            Console.WriteLine("Enter your menu choice number");
            // get choice and return the value
            return Console.ReadLine();
        }
    }
    }

