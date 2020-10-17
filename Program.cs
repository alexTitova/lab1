using lab1.Classes;
using lab1.parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Path_unit> paths1 = new List<Path_unit>() { new Path_unit('b', 7), new Path_unit('d', 1), new Path_unit('e', 3) };
            Node a1 = new Node('a', paths1);

            List<Path_unit> paths2 = new List<Path_unit>() { new Path_unit('c', 2) };
            Node b1 = new Node('b', paths2);

            List<Path_unit> paths3 = new List<Path_unit>() { new Path_unit('a', 20), new Path_unit('d', 1) };
            Node c1 = new Node('c', paths3);

            List<Path_unit> paths4 = new List<Path_unit>() { new Path_unit('c', 1), new Path_unit('e', 10) };
            Node d1 = new Node('d', paths4);

            List<Path_unit> paths5 = new List<Path_unit>() { new Path_unit('a', 3) };
            Node e1 = new Node('e', paths5);

            Node h1 = new Node('h');

            Graph graph = new Graph();
            graph.Add(d1);
            graph.Add(a1);
            graph.Add(e1);
            graph.Add(b1);
            graph.Add(c1);
            graph.Add(h1);

            Node x = graph.Get_Node_for_vertex('c');

            (bool, int, bool) pp = graph.Get_weight_of_path(('c', 'a'));

            Console.WriteLine("ok");

            Console.ReadKey();
        }
    }
}
