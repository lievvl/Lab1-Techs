using System;
using System.Collections.Generic;
using System.Linq;
using Task3Sharp;

namespace Task3Sharp2 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Graph g = new Graph(5);
            g.AddEdge(0, 1);
            g.AddEdge(1, 2);
            g.AddEdge(2, 3);
            g.AddEdge(3, 4);
            g.AddEdge(4, 0);
            List<int> order = g.BFS(0);
            foreach (var i in order)
                Console.Write($"{i} ");
            Console.WriteLine("");
            order = g.DFS(0);
            foreach (var i in order)
                Console.Write($"{i} ");
        }
    }
}