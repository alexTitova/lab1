

using lab1.Classes;
using lab1.parts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Resources;
using System.Runtime.CompilerServices;

namespace lab1
{

    class Path_table
    {
        private static List<(int,int,int)> Func_see(int line, int column, int[,] matrix)
        {
            List<(int, int, int)> result = new List<(int, int, int)>();

            for(int j=0;j<matrix.GetLength(0);j++)
            {
                if(matrix[column,j]!=-1 && j!=line)
                   result.Add((column, j, matrix[column, j]));
            }

            return result;
        }



        private static int[,] Rewrite_path_tab(int line, int[,] rewrite_tab, List<(int,int,int)> vals)
        {
            foreach ((int,int,int) unit in vals)
            {
                if (rewrite_tab[line, unit.Item2] == -1)
                    rewrite_tab[line, unit.Item2] = rewrite_tab[line, unit.Item1] + unit.Item3;
                else
                {
                    if (rewrite_tab[line, unit.Item2] > rewrite_tab[line, unit.Item1] +unit.Item3)
                        rewrite_tab[line, unit.Item2] = rewrite_tab[line, unit.Item1] + unit.Item3;
                }
            }

            return rewrite_tab;
        }


        // приводит таблицу расстояний приводит к стандартному виду если нет пути то ставит 0
        private static void Normalization_path_tab(int[,] path_tab) 
        {
            for(int i=0;i<path_tab.GetLength(0);i++)
            {
                for(int j=0;j<path_tab.GetLength(0);j++)
                {
                    if (path_tab[i, j] == -1)
                        path_tab[i, j] = 0;
                }
            }
        }


        public static int[,] Path_matrix(Graph graph)
        {
            int n = graph.Get_count_of_vertex();
            List<(int, int,int)> values = new List<(int, int,int)>();
            int[,] mat_avg = graph.Get_matrix_adjacency();
            int[,] path_tab= mat_avg; 
            bool flag = false;

            while(!flag) // пока матрица будет меняться этот цикл будет крутиться
            {
                mat_avg = path_tab;

                // здесь будет делиться на два потока
                for (int i=0;i<n; i++)
                {
                    for(int j=0;j<n;j++)
                    {
                        if(mat_avg[i,j]!=-1 && i!=j)
                            values = Func_see(i, j, mat_avg); // смотрит есть ли в j-ой строке что изменить

                        if (values != null)
                        {
                            path_tab = Rewrite_path_tab(i, mat_avg, values); 
                            values = null;
                        }
                    }
                }

                // сделать объединение потоков 
                flag = path_tab.Equals(mat_avg); // есть ли изменения в прпомежуточной матрицы и финальной
            }

            Normalization_path_tab(path_tab);

            return path_tab;
        }
    }
    

}
