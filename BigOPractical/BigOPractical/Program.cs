using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BigOPractical
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Welcome to the Big O testing program");
                Console.WriteLine();
                Console.WriteLine("1: Constant - O(1)");
                Console.WriteLine("2: Logarithmic - O(log n) **pre coded**");
                Console.WriteLine("3: Linear - O(n)");
                Console.WriteLine("4: Linearithmic - O(n log n)");
                Console.WriteLine("5: Polynomial - O(n^2) or O(n^3)");
                Console.WriteLine("6: Exponential - O(k^n)");
                Console.WriteLine("7: Factorial - O(n!) **pre coded**");
                Console.WriteLine("8: Quit");
                Console.WriteLine();
                Console.Write("Please make a selection: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        constantC();
                        break;
                    case 2:
                        logarithmicC();
                        break;
                    case 3:
                        linearC();
                        break;
                    case 4:
                        linearithmicC();
                        break;
                    case 5:
                        polynomialC();
                        break;
                    case 6:
                        exponentialC();
                        break;
                    case 7:
                        factorialC();
                        break;

                }
            }
            while (choice != 8);
        }

        static void constantC()
        {
            Console.WriteLine("\nLets test Constant complexity ");

            //this bit is for the input required to run the test
            Console.Write("\nPlease enter an integer: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("press enter to run the test!!");
            Console.ReadLine();

            // set up the stopwatch
            long elapsed_time;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //this is the bit which is tested

            // YOUR CODE GOES HERE
            // this should be a single calculation to calculate the some of natural numbers from 0 to value

            //stop the stopwatch and show the result
            stopwatch.Stop();
            elapsed_time = stopwatch.ElapsedTicks;

            Console.WriteLine("this took " + elapsed_time + " ticks.");
            Console.WriteLine("\nPress enter to return to the menu!!");
            Console.ReadLine();
        }

        static void polynomialC()
        {
            Console.WriteLine("\nLets test Polynomial complexity ");

            //this bit is for the input required to run the test
            Console.Write("\nPlease enter an integer for the number of random numbers: ");
            int value = Convert.ToInt32(Console.ReadLine());

            // setup for an array to bubble sort
            int[] NumList = new int[value];
            Random RanNum = new Random();
            for (int i = 0; i < value; i++)
            {
                NumList[i] = RanNum.Next(1, value * 2);
                Console.WriteLine(NumList[i]);
            }

            Console.Write("Your list will now be sorted.");

            //ready for the test
            Console.WriteLine("press enter to run the test!!");
            Console.ReadLine();

            // set up the stopwatch
            long elapsed_time;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // YOUR CODE GOES HERE
            // a bubble sort is of polynomial complexity (ie n^2)
            // add or write a bubble sort here

            //stop the stopwatch and show the result
            stopwatch.Stop();
            elapsed_time = stopwatch.ElapsedTicks;

            // output messages
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine(NumList[i]);
            }

            Console.WriteLine("this took " + elapsed_time + " ticks.");
            Console.WriteLine("\nPress enter to return to the menu!!");
            Console.ReadLine();
        }

        static void linearithmicC()
        {
            Console.WriteLine("\nLets test Linearithmic complexity ");

            //this bit is for the input required to run the test
            Console.Write("\nPlease enter an integer for the number of random numbers: ");
            int value = Convert.ToInt32(Console.ReadLine());

            // setup for an array to comb sort
            int[] NumList = new int[value];
            Random RanNum = new Random();
            for (int i = 0; i < value; i++)
            {
                NumList[i] = RanNum.Next(1, value * 2);
                Console.WriteLine(NumList[i]);
            }

            Console.Write("Your list will now be sorted.");

            Console.WriteLine("press enter to run the test!!");
            Console.ReadLine();

            // set up the stopwatch
            long elapsed_time;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // YOUR CODE GOES HERE
            // a Comb sort is a linearithmic algorithm
            // add or write a comb sort here

            //stop the stopwatch and show the result
            stopwatch.Stop();
            elapsed_time = stopwatch.ElapsedTicks;

            // output messages
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine(NumList[i]);
            }

            Console.WriteLine("this took " + elapsed_time + " ticks.");
            Console.WriteLine("\nPress enter to return to the menu!!");
            Console.ReadLine();
        }

        static void linearC()
        {
            Console.WriteLine("\nLets test Linear complexity ");

            //this bit is for the input required to run the test
            Console.Write("\nPlease enter an integer for the number of random numbers: ");
            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("choose one of the following random numbers to search for");
            Console.ReadLine();

            // setup for an array to linear search
            int[] NumList = new int[value];
            Random RanNum = new Random();
            for (int i = 0; i < value; i++)
            {
                NumList[i] = RanNum.Next(1, value * 2);
                Console.WriteLine(NumList[i]);
            }

            //get the number to search for
            Console.Write("please enter a number to search for: ");
            int search = Convert.ToInt32(Console.ReadLine());

            //ready for the test
            Console.WriteLine("press enter to run the test!!");
            Console.ReadLine();
            Array.Sort(NumList); //sort array - not really needed for linear search

            // set up the stopwatch
            long elapsed_time;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();


            // YOUR CODE GOES HERE
            // a linear search is of linear time complexity
            // create a for loop to start at 0 and finish at value-1
            // check if numlist[i] is equal to search
            // output if it was found and at which position

            //stop the stopwatch and show the result
            stopwatch.Stop();
            elapsed_time = stopwatch.ElapsedTicks;

            // output messages
            Console.WriteLine("this took " + elapsed_time + " ticks.");
            Console.WriteLine("\nPress enter to return to the menu!!");
            Console.ReadLine();
        }

        static void exponentialC()
        {
            Console.WriteLine("\nLets test exponential complexity ");

            //this bit is for the input required to run the test
            Console.Write("\nPlease enter an integer: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("press enter to run the test!!");
            Console.ReadLine();

            // set up the stopwatch
            long elapsed_time;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //the exponential code to run

            // YOUR CODE GOES HERE
            // your towers of hanoi program is of exponential complexity
            // look up the algorithm in C# and copy here

            //stop the stopwatch and show the result
            stopwatch.Stop();
            elapsed_time = stopwatch.ElapsedTicks;
            Console.WriteLine("this took" + elapsed_time + " ticks.");
            Console.WriteLine();
            Console.WriteLine("\nPress enter to return to the menu!!");
            Console.ReadLine();
        }

        static void logarithmicC()
        {
            Console.WriteLine("\nLets test Logarithmic complexity ");

            //this bit is for the input required to run the test
            Console.Write("\nPlease enter an integer for the number of random numbers: ");
            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("choose one of the following random numbers to search for");
            Console.ReadLine();

            // setup for an array to binary search
            int[] NumList = new int[value];
            Random RanNum = new Random();
            for (int i = 0; i < value; i++)
            {
                NumList[i] = RanNum.Next(1, value * 2);
                Console.WriteLine(NumList[i]);
            }

            //get the number to search for
            Console.Write("please enter a number to search for: ");
            int search = Convert.ToInt32(Console.ReadLine());

            //ready for the test
            Console.WriteLine("press enter to run the test!!");
            Console.ReadLine();
            Array.Sort(NumList); //binary search list must be sorted

            // set up the stopwatch
            long elapsed_time;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //this is the bit which is tested
            int pos = BinarySearch(NumList, search, 0, value); //calls the method below to perform the binary search

            //stop the stopwatch and show the result
            stopwatch.Stop();
            elapsed_time = stopwatch.ElapsedTicks;

            Console.WriteLine("item found at element " + pos);

            // output messages
            Console.WriteLine("this took " + elapsed_time + " ticks.");
            Console.WriteLine("\nPress enter to return to the menu!!");
            Console.ReadLine();
        }

        public static int BinarySearch(int[] inputArray, int key, int min, int max)
        {
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        static void factorialC()
        {
            Console.WriteLine("\nLets test factorial complexity ");

            //this bit is for the input required to run the test
            Console.Write("Please enter a sentence to show all permutations: ");
            string value = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("press enter to run the test!!");
            Console.ReadLine();

            // set up the stopwatch
            long elapsed_time;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //this is the bit which is tested

            char[] charArry = value.ToCharArray();
            foreach (char val in charArry)
            {
                Console.WriteLine(val);
            }
            permute("", value); //runs the recursive method below

            //stop the stopwatch and show the result
            stopwatch.Stop();
            elapsed_time = stopwatch.ElapsedTicks;

            // output messages
            Console.WriteLine("this took " + elapsed_time + " ticks.");
            Console.WriteLine("\nPress enter to return to the menu!!");
            Console.ReadLine();
        }

        static void permute(string prefix, string word)
        {
            int n = word.Length;
            if (n == 0) { Console.WriteLine(prefix); }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    permute(prefix + word[i], word.Substring(0, i) + word.Substring(i + 1, n - (i + 1)));
                }
            }
        }
    }
}
