using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    class Path_unit //  это единица списка пути
    {
        private int destination; // ключ
        private int weight;
  

        public Path_unit() { }

        public Path_unit(int vertex, int weight_of_path)
        {
            destination = vertex;
            weight = weight_of_path;
        }


        public int Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

    }
}
