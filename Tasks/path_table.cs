/*

using lab1.Classes;
using System;
using System.Collections.Generic;

namespace lab1
{

    class Path_table
    {
        public static void status(Graph dd)
        {
            Console.WriteLine("okey");
        }


        public static void create_path_tab(Graph graph)
        {
            List<int> list_of_vertex = graph.Get_list_of_vertex();
            (bool, int, bool) path_intedificator = (false, 0, false);

            foreach(int vertex1 in list_of_vertex)
            {
                foreach(int vertex2 in list_of_vertex)
                {
                    if(vertex1!=vertex2)
                    {
                        path_intedificator = graph.Get_weight_of_path((vertex1, vertex2));

                        if(path_intedificator.Item1)
                        {
                            // запись в таблицу пути двумерный массив
                        }
                    }
                }
            }

        }

    }


}
*/