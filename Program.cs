using lab1.Classes;
using lab1.parts;
//using lab1.Tasks;
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
            List<Path_unit> paths1 = new List<Path_unit>() { new Path_unit(102, 7), new Path_unit(104, 1), new Path_unit(105, 3) };
            Node a1 = new Node(101, paths1);

            List<Path_unit> paths2 = new List<Path_unit>() { new Path_unit(103, 2) };
            Node b1 = new Node(102, paths2);

            List<Path_unit> paths3 = new List<Path_unit>() { new Path_unit(101, 20), new Path_unit(104, 1) };
            Node c1 = new Node(103, paths3);

            List<Path_unit> paths4 = new List<Path_unit>() { new Path_unit(103, 1), new Path_unit(105, 10) };
            Node d1 = new Node(104, paths4);

            List<Path_unit> paths5 = new List<Path_unit>() { new Path_unit(101, 3) };
            Node e1 = new Node(105, paths5);

            Node h1 = new Node(106);

            Graph graph = new Graph();
            graph.Add(d1);
            graph.Add(a1);
            graph.Add(e1);
            graph.Add(b1);
            graph.Add(c1);
            graph.Add(h1);

            Node x = graph.Get_Node_for_vertex(103);

            (bool, int, bool) pp = graph.Get_weight_of_path((103, 101));

            int[] vertexes = graph.Get_array_of_vertex();

            foreach(int a in vertexes)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("ok");

           
            Console.ReadKey();
        }

   }
}
