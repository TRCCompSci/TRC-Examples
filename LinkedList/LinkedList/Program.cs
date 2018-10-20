using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new linked list using class definition below
            LinkedList myList = new LinkedList();

            // add items to the list & print the list
            myList.AddFirst("Magical");
            myList.AddFirst("Hello");
            myList.AddLast("World");
            Console.WriteLine("\nPrint List:");
            myList.printAllNodes();

            // add a new item to the list after a given node & print the list
            myList.AddMidAfter("End","Hello");
            Console.WriteLine("\nPrint List:");
            myList.printAllNodes();

            // add a new item to the list before a given node & print the list
            myList.AddMidBefore("Now", "Magical");
            Console.WriteLine("\nPrint List:");
            myList.printAllNodes();

            // remove a node from the list and print the list
            myList.RemoveNode("End");
            Console.WriteLine("\nPrint List:");
            myList.printAllNodes();

            Console.ReadLine();

        }
    }
    // class definition for a node
    public class Node
    {
        public Node next;
        public Object data;
    }

    // class definition for a linked list
    public class LinkedList
    {
        // the linked list will have a head node (start of the list)
        private Node head;

        // RemoveNode will find the specified node and Remove it
        public void RemoveNode(Object data)
        {

            /*
             * You need to create a method for removing a node from the list:
             * 
             * You will need to delcare both the current and previous nodes.
             * You can set them both to the head at the start
             * 
             * While the next value of the current node is not null (ie end of list)
             * 
             *      Check the data in the current node to see if it matches what you want to remove
             *        
             *           if false 
             *             set temp to current
             *             set current = next node
             *             set previous = temp
             *           else
             *             correct node is selected as current
             *          
             * Check the current node is the node to be removed
             * 
             *      To remove the node you can set the Next value of the previous to the Next value of the current
             *      
             */               
        }
  
        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        // AddFirst will add a new node onto the start of the list
        public void AddFirst(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        // AddLast will find the end of the list and add the new node onto the end
        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }

        // AddMidAfter will add a node after a specific node
        public void AddMidAfter(Object data, Object after)
        {
            // this will check if the list is empty
            if (head == null)
            {
                // if it is create a new head node
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                // the list currently has values to reach here

                // create a new node and set the data to the data passed
                Node toAdd = new Node();
                toAdd.data = data;

                // the parameter after is passed at the start of this function (ie insert node after the after node) 
                // therefore we need to find the after node

                // set the current to the head (start of list)
                Node current = head;

                // while not at the end of the list
                while (current.next != null)
                {
                    // check the data in the current node with the after value passed
                    if (current.data != after)
                    {
                        // stil not the right node
                        // so set current to the next node
                        current = current.next;
                    }
                    // the current node is the after node
                    else break;
                }

                // set the next value of the new node to the current next value
                // set the current next value to point to the new node
                toAdd.next = current.next;
                current.next = toAdd;
            }
        }

        // AddMidBefore will add a node before a specific node
        public void AddMidBefore(Object data, Object before)
        {
            /*
             * AddMidAfter is a method to add the new node after a specific node
             * You should use AddMidAfter as a guide to create this method
             * I have commented AddMidAfter to explain what each line is for
             * 
             */

        }
    }

}
