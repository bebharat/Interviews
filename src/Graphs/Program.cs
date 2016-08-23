using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures;

namespace Graphs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var graph = new Graph();
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(2, 5);
            graph.AddEdge(4, 2);

            Console.WriteLine("BFS ");
            var obj = new BFS();
            obj.DoBFS(graph, 1);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("DFS ");
            var obj2 = new DFS();
            obj2.DoDFS(graph, 1);

            Console.ReadLine();
        }
    }
}
