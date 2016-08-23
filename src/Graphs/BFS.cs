using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures;

namespace Graphs
{
    public class BFS
    {
        public void DoBFS(Graph graph, int root)
        {
            var visitedNodes = new HashSet<int>();
            var queue = new Queue<int>();

            visitedNodes.Add(root);
            queue.Enqueue(root);

            while(queue.Any())
            {
                
                var current = queue.Dequeue();
                Console.WriteLine("Finding neighbors of " + current);

                var neighbors = graph.Vertices[current];

                foreach(var neigbhor in neighbors)
                {
                    if(!visitedNodes.Contains(neigbhor))
                    {
                        visitedNodes.Add(neigbhor);
                        queue.Enqueue(neigbhor);
                        Console.WriteLine(neigbhor + " is a neighbor of " + current);
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
