using lab1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.parts
{
    class Node_comparer : IComparer<Node>
    {

        public int Compare(Node x, Node y)
        {
            if (x.Vertex < y.Vertex)
                return -1;
            else
            {
                if (x.Vertex > y.Vertex)
                    return 1;
                else
                    return 0;
            }
        }
    }
}