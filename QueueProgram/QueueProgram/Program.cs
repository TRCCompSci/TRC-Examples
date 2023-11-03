using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			// declare variables
			const int MaxQueueSize = 10;
			int QueueSize=0;
			int QueueStart=0, QueueEnd = -1;
			string[] Queue = new string[MaxQueueSize];
			string MenuItem;  
			// program loop
			do {
				// get size of the stack
				QueueSize = OutputNumberOfNamesInQueue (ref Queue, MaxQueueSize);
				// display menu and get menu choice
				MenuItem = GetMenuChoice ();
				// do something with the menu choice
				switch (MenuItem) {
				case "1":
					AddToQueue (ref Queue, ref QueueStart, ref QueueEnd, MaxQueueSize, QueueSize);
					break;
				case "2":
					RemoveFromQueue (ref Queue, ref QueueStart, ref QueueEnd, MaxQueueSize, QueueSize);
					break;
				case "3":
					PrintQueue (ref Queue, MaxQueueSize);
					break;
				case "4":
					break;
				default:
					Console.WriteLine ("invalid selection");
					break;
				}
			}
			while (MenuItem != "4");
			Console.WriteLine ("end of program");
			Console.ReadLine ();
		}

		public static void AddToQueue(ref string[] Queue, ref int QueueStart, ref int QueueEnd, int MaxQueueSize, int QueueSize)
		{
			// add your code here
			// you will need to know and understand this algorithm
		}

		public static void RemoveFromQueue(ref string[] Queue,ref int QueueStart, ref int QueueEnd, int MaxQueueSize, int QueueSize)
		{
			// add your code here
			// you will need to know and understand this algorithm
			// use Queue[QueueFront]=null; to remove the value
		}

		public static void PrintQueue(ref string[] TheQueue, int QueueSize)
		{
			Console.WriteLine();
			Console.WriteLine("The current Queue:");
			for (int i = 0; i < QueueSize; i++)
			{
				if (TheQueue[i] != null) Console.WriteLine(TheQueue[i]);
			}
		}

		public static int OutputNumberOfNamesInQueue(ref string[] TheQueue, int QueueSize)
		{
			int count = 0;
			for (int i = 0; i < QueueSize; i++)
			{
				if (TheQueue[i] != null) count++;
			}
			return count;
		}

		public static string GetMenuChoice()
		{
			//display menu
			Console.WriteLine();
			Console.WriteLine("1) Add a name to the queue");
			Console.WriteLine("2) Remove a name from the queue");
			Console.WriteLine("3) Display queue");
			Console.WriteLine("4) Exit program");
			Console.WriteLine();
			Console.WriteLine("Enter your menu choice number");
			// get choice and return the value
			return Console.ReadLine();
		}
	}
}
