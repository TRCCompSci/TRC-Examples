using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    class Program
    {
        static void Main(string[] args)
        {
            // the graph from the spreadsheet
            int[,] graph = new[,] 
            {
                //graph col 0, col1, col2, col3, col4
                 {-1,1,6,-1,-1}, //row 0
                 {1,-1,4,3,1}, //row 1
                 {6,4,-1,1,-1}, //row 2
                 {-1,3,1,-1,1}, //row 3
                 {-1,1,-1,1,-1} //row 4
            };

            // the call from the spreadsheet
            Dijkstra(graph, 0, 3);

            Console.ReadLine();
        }

        static void Dijkstra(int[,] adjMatrix, int start, int dest)
        {
            // set arrays and dimension of adjmatrix
            int dim = adjMatrix.GetLength(1));
            int[] distance = new int[dim];
            string[] visited = new string[dim];
            int[] previous = new int[dim];

            // set default / rouge values
            for (int i = 0; i < dim; i++)
            {
                distance[i] = 999;
                visited[i] = "F";
                previous[i] = -1;
            }

            //set distance to start node as 0
            distance[start]=0;

            /* finish the coding from the spreadsheet
              

                  for u  = 0 to 4
                       Visted[u] = T

                       for v  = 0 to 4  
                            if adjMatrix[u,v] <> inf then
                                alt ← Distance[u] + AdjMatrix(u, v)
                                if alt < Distance[v] then               
                                       Distance[v] ← alt 
                                       Previous[v] ← u
                                end if
                             end if
                       end for

                   end for

                  path= dest
                  while path< > start
                           path= Previous[Path]
                  end while

                */

        }      
    }
}
