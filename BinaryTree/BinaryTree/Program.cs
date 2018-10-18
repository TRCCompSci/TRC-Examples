using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        public struct Vertex
        {
            public string data;
            public int left;
            public int right;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter Maximum number of vertices: ");
            int maxVertices = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many node do you want to enter: ");
            int noOfVertices = Convert.ToInt32(Console.ReadLine());

            Vertex[] binaryTree = new Vertex[maxVertices];

            for (int i = 0; i < noOfVertices; i++)
            {
                if (binaryTree[0].data==null)
                {
                    Console.WriteLine("Enter the data:");
                    binaryTree[0].data = Console.ReadLine();
                    binaryTree[0].left = 0;
                    binaryTree[0].right = 0;
                }
                else 
                {
                    Console.WriteLine("Enter the data:");
                    string data = Console.ReadLine();
                    int newspace = -1;

                    //find empty space
                    for (int j = 0; j < maxVertices; j++)
                    {
                        if(binaryTree[j].data == null)
                        {
                            newspace = j;
                            break;
                        }
                    }

                    //add data to empty space
                    binaryTree[newspace].data = data;

                    //set left and right pointers for appropriate vertices
                    int current = 0;
                    do
                    {
                        if (String.CompareOrdinal(binaryTree[current].data, data)<0)
                        {
                            if (binaryTree[current].right == 0)
                            {
                                binaryTree[current].right = newspace;
                                break;
                            }
                            else
                            {
                                current = binaryTree[current].right;
                                
                            }
                        }
                        else if (String.CompareOrdinal(binaryTree[current].data, data) > 0)
                        {
                            if (binaryTree[current].left == 0)
                            {
                                binaryTree[current].left = newspace;
                                break;
                            }
                            else
                            {
                                current = binaryTree[current].left;
                            }
                        }
                    }
                    while (true);
                }
            }

            //print binaryTree array
            foreach (Vertex v in binaryTree)
            {
                Console.WriteLine(v.data +" "+ v.left +" " + v.right);
            }
            Console.ReadLine();

        }
    }
}
