using lab1.parts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    class Graph
    {
        private List<Node> data;

        private static int count_of_vertex;

        public Graph() 
        {
            this.data = new List<Node>();
            count_of_vertex = 0;
        }

        public Graph (List<Node> data)
        {
            this.data = data;
            count_of_vertex = data.Count();
        }

        public List<Node> Data
        {
            get { return this.data; }
            set
            {
                this.data = value;
                count_of_vertex = data.Count();
            }
        }


        public int Get_count_of_vertex()
        {
            return count_of_vertex;
        }


        public void Add(Node unit)
        {
            data.Add(unit);
            data.Sort(new Node_comparer());
            count_of_vertex++;
        }

        public void Add_vertex (int vertex) // добавляем вершину без связей 
        {
            List<Path_unit> paths = new List<Path_unit>();
            Node unit = new Node(vertex, paths);
            data.Add(unit);
            data.Sort(new Node_comparer());
            count_of_vertex++;
        }


        public int Get_index_of(int vertex)
        {
            Node elem = new Node(vertex, new List<Path_unit>());
            return this.data.BinarySearch(elem, new Node_comparer());
        }

        public Node Get_Node_for_vertex(int vertex)
        {
            int index = this.Get_index_of(vertex);

            if (index>=0)
                return this.data[this.Get_index_of(vertex)];
            else
             return null;
        }

        public (bool, int, bool) Get_weight_of_path((int,int) path) // возвращает кортеж (есть путь или нет, вес пути, пройден путь или нет)
        {
            Node elem = this.Get_Node_for_vertex(path.Item1);

            if (elem != null)
            {
                Path_unit unit = elem.Get_Path_unit(path.Item2);

                if (unit != null)
                    return (true, unit.Weight, unit.Flag);
                else
                    return (false, 0, false);
            }
            else
                return(false, 0, false);
        }

        public int[] Get_array_of_vertex()
        {
            int[] result = new int[count_of_vertex];
            int i = 0;

            foreach (Node unit in this.data)
            {
                if (i < count_of_vertex)
                    result[i] = unit.Vertex;
                else
                    throw new IndexOutOfRangeException();

                i++;
            }

            return result;
        }


    }
}
