using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures;

namespace Graphs
{
    public class DFS
    {
        public void DoDFS(Graph graph, int root)
        {
            var visitedNodes = new HashSet<int>();
            var stack = new Stack<int>();

            visitedNodes.Add(root);
            stack.Push(root);

            while (stack.Any())
            {
                var current = stack.Pop();
                Console.WriteLine("Finding neighbors of " + current);

                var neighbors = graph.Vertices[current];

                foreach (var neigbhor in neighbors)
                {
                    if (!visitedNodes.Contains(neigbhor))
                    {
                        visitedNodes.Add(neigbhor);
                        stack.Push(neigbhor);
                        Console.WriteLine(neigbhor + " is a neighbor of " + current);
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
