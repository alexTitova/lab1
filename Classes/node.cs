using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    class Node
    {
        private char vertex;           // вершина
        private List<Path_unit> paths; // список путей из vertex


        public Node() { }
        public Node(char vertex, List<Path_unit> paths)
        {
            this.vertex = vertex;
            this.paths = paths;
        }

        public char Vertex
        {
            get { return this.vertex; }
            set { this.vertex = value; }
        }
        public List<Path_unit> Paths
        {
            get { return this.paths; }
            set { this.paths = value; }
        }


        public void Add_path(Path_unit unit)
        {
            this.paths.Add(unit);
            this.paths.Sort();
        }


        /* public (char, Path_unit) Get_path()  // возвращает пару( вершину, единицу пути) по 
         {
             int index = this.paths.BinarySearch()

             return (this.vertex, unit);
         }*/



        public int CompareTo(Node obj) // для сортировки узлов
        {
            return this.vertex.CompareTo(obj.vertex);
        }
    }
}
}
