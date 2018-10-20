using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListArray
{
    class Program
    {
        public struct Node
        {
            public string data;
            public int next;
        }
        
        static Node[] listarray = new Node[20];

        static int front = -1;

        static void AddAfter(string data, string after)
        {
            // find the after string in the list array and set position
            // value of -1 if after string not in the list array
            int pos = -1;
            for (int i = 0; i < listarray.Length; i++)
            {
                if (listarray[i].data == after)
                {
                    pos = i;
                    break;
                }
            }

            // check if after string is found
            if (pos != -1)
            {
                // record the next of the after node
                int temp = listarray[pos].next;

                // find a empty slot
                for (int count = 0; count < listarray.Length; count++)
                {
                    if (listarray[count].data == "")
                    {
                        //when empty slot found
                        //set the data to the data passed into method
                        //set the next value to the temp value above
                        listarray[count].data = data;
                        listarray[count].next = temp;
                        //now set the next value of the after node to the space used
                        listarray[pos].next = count;
                        break;
                    }
                }
            }

        }

        static void AddToFront(string data)
        {
            //find an empty space
            for (int count = 0; count < listarray.Length; count++)
            {
                if (listarray[count].data=="")
                {
                    //empty space found
                    //set data of empty space to data passed into method
                    //set the next to the current front of the list
                    listarray[count].data = data;
                    listarray[count].next = front;
                    //set the new front to the space used
                    front = count;
                    break;
                }
            }
        }

        static void DisplayArray()
        {
            //method to display the underlying array in element order
            Console.WriteLine("front:" + front);
            foreach(Node n in listarray)
            {
                Console.WriteLine(n.data + " " + n.next);
            }
        }

        static void DisplayList()
        {
            //method to display the list in list order
            //start with the front
            int node = front;
            // loop to cycle through the nodes until the next value is equal to -1
            do
            {
                if (node != -1)
                {
                    Console.WriteLine(listarray[node].data + " " + node);
                    if (listarray[node].next != -1)
                    {
                        node = listarray[node].next;
                    }
                    else
                    {
                        node = -1;
                    }
                }
            }
            while (node!=-1);
        }

        static void InitList()
        {
            //method to setup the list with starting values
            for (int i = 0; i < listarray.Length; i++)
            {
                listarray[i].data = "";
                listarray[i].next = -1;
            }
        }

        static void Main(string[] args)
        {
            InitList();
            AddToFront("wayne");
            AddToFront("fred");
            AddToFront("dave");
            AddAfter("mike", "fred");
            DisplayArray();
            DisplayList();
            Console.ReadLine();
            
        }
    }
}
