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
            Path_unit aa = new Path_unit('a', 3);
            Path_unit cc = new Path_unit('c', 3);
            Path_unit dd = new Path_unit('d', 3);
            Path_unit bb = new Path_unit('b', 3);

            List<Path_unit> arr = new List<Path_unit>();
            arr.Add(bb);
            arr.Add(aa);
            arr.Add(dd);
            arr.Add(cc);

            arr.Sort(new Path_comparer());

            foreach (Path_unit path in arr)
                Console.WriteLine(path.Destination);

            Path_unit unit = new Path_unit('c', 0);
            int index = arr.BinarySearch(unit, new Path_comparer());
            Console.WriteLine(index);

            Console.ReadKey();
        }
    }
}
