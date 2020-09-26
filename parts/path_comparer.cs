using lab1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.parts
{
    class Path_comparer : IComparer<Path_unit>
    {

        public int Compare(Path_unit x, Path_unit y)
        {
            if (x.Destination < y.Destination)
                return -1;
            else
            {
                if (x.Destination > y.Destination)
                    return 1;
                else
                    return 0;
            }
        }
    }
}
