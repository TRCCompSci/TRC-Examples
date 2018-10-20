using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStackProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			// declare variables
			const int MaxStackSize = 10;
			int StackPointer = 0;
			string[] Stack = new string[MaxStackSize+1];
			string MenuItem;  
			// program loop
			do {
				MenuItem = GetMenuChoice ();
				// do something with the menu choice
				switch (MenuItem) {
				case "1":
					PushNameToStack (ref Stack, ref StackPointer, MaxStackSize);
					break;
				case "2":
					PopNameFromStack (ref Stack, ref StackPointer, MaxStackSize);
					break;
				case "3":
					PrintStack (ref Stack, StackPointer);
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

		public static void PushNameToStack(ref string[] TheStack, ref int StackPointer, int MaxStackSize)
		{
			// add your code here
			// you will need to know and understand this algorithm
		}

		public static void PopNameFromStack(ref string[] TheStack, ref int StackPointer, int MaxStackSize)
		{
			// add your code here
			// you will need to know and understand this algorithm
		}

		public static void PrintStack(ref string[] TheStack, int StackSize)
		{
			Console.WriteLine();
			Console.WriteLine("The current Stack:");
			for (int i = 0; i < StackSize+1; i++)
			{
				if (TheStack[i] != null) Console.WriteLine(TheStack[i]);
			}
		}

		public static int OutputNumberOfNamesInStack(ref string[] TheStack, int StackSize)
		{
			int count = 0;
			for (int i = 0; i < StackSize; i++)
			{
				if (TheStack[i] != null) count++;
			}
			return count;
		}

		public static string GetMenuChoice()
		{
			//display menu
			Console.WriteLine();
			Console.WriteLine("1) Push a name onto the stack");
			Console.WriteLine("2) Pop a name from the stack");
			Console.WriteLine("3) Display stack");
			Console.WriteLine("4) Exit program");
			Console.WriteLine();
			Console.WriteLine("Enter your menu choice number");
			// get choice and return the value
			return Console.ReadLine();
		}
	}
}
