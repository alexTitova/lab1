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
        private int vertex;           // вершина
        private List<Path_unit> paths; // список путей из vertex
        private static int count_of_paths;

        public Node() { }

        public Node(int vertex) 
        {
            this.vertex = vertex;
            this.paths= new List<Path_unit>();
            count_of_paths = 0; 
        }

        public Node(int vertex, List<Path_unit> paths)
        {
            this.vertex = vertex;
            this.paths = paths;
            count_of_paths=paths.Count();
        }

        public int Vertex
        {
            get { return this.vertex; }
            set { this.vertex = value; }
        }
        public List<Path_unit> Paths
        {
            get { return this.paths; }
            set 
            {
                this.paths = value; 
                count_of_paths = this.paths.Count(); 
            }
        }


        public void Add_path(Path_unit unit)
        {
            this.paths.Add(unit);
            count_of_paths++;
            this.paths.Sort(new Path_comparer());
        }


        // удоляет первое вхождение unit
        public void Remove_path(Path_unit unit)  
        {
            this.paths.Remove(unit);
            count_of_paths--;
        }


        // возвращает индекс unit в листе, начиная с нулевого
        public int Get_index_of(Path_unit unit) 
        {
            return this.paths.BinarySearch(unit, new Path_comparer());
        }


        // возвращает удиницу путиа пути) то есть путь от вершины до нужной верщины
        public Path_unit Get_Path_unit(int destination) 
        {
            Path_unit unit = new Path_unit(destination, 0);
            int index = this.paths.BinarySearch(unit, new Path_comparer());
            if (index >= 0)
                return this.paths[index];
            else
                return null;
        }


        // возвращает кол-во путей из вершины
        public int Get_count_of_paths() 
        {
            return count_of_paths;
        }

    }
}

