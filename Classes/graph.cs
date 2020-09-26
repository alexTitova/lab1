using System;
using System.Collections.Generic;
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
            data.Sort(0);
            count_of_vertex++;
        }

        public void Add_vertex (char vertex) // добавляем вершину без связей 
        {
            List<Path_unit> paths = new List<Path_unit>();
            Node unit = new Node(vertex, paths);
            data.Add(unit);
            data.Sort();
            count_of_vertex++;
        }





    }
}
