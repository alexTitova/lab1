using lab1.parts;
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


        public void Remove_path(Path_unit unit)  // удоляет первое вхождение unit
        {
            this.paths.Remove(unit);
        }

        public int Get_index_of(Path_unit unit) // возвращает индекс unit в листе, начиная с нулевого
        {
            return this.paths.BinarySearch(unit, new Path_comparer());
        }

        public (char, Path_unit) Get_path(char destination) // возвращает пару (вершина, единица пути) то есть путь от вершины до нужной верщины
        {
            Path_unit unit = new Path_unit(destination, 0);
            int index = this.paths.BinarySearch(unit);

            return (this.vertex, this.paths[index]);
        }

        public int Get_count_of_paths() // возвращает кол-во путей из вершины
        {
            return this.paths.Count();
        }

    }
}

