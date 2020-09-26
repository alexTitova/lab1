using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    class Path_unit //  это единица списка пути
    {
        private char destination; // ключ
    private int weight;
    private bool flag; // пройдена ли данная вершина или нет


    public Path_unit() { }

    public Path_unit(char vertex, int weight_of_path)
    {
        destination = vertex;
        weight = weight_of_path;
        flag = false;
    }


    public char Destination
    {
        get { return destination; }
        set { destination = value; }
    }
    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }
    public bool Flag
    {
        get { return flag; }
        set { flag = value; }
    }




    // Переопределение операторов сравнения
    public static bool operator ==(Path_unit a1, Path_unit a2)
    {
        if (a1.destination == a2.destination)
            return true;
        else
            return false;
    }

    public static bool operator !=(Path_unit a1, Path_unit a2)
    {
        if (a1.destination != a2.destination)
            return true;
        else
            return false;
    }

    public static bool operator <(Path_unit a1, Path_unit a2)
    {
        if (a1.destination < a2.destination)
            return true;
        else
            return false;
    }

    public static bool operator >(Path_unit a1, Path_unit a2)
    {
        if (a1.destination != a2.destination)
            return true;
        else
            return false;
    }

    public static bool operator <=(Path_unit a1, Path_unit a2)
    {
        if (a1.destination <= a2.destination)
            return true;
        else
            return false;
    }

    public static bool operator >=(Path_unit a1, Path_unit a2)
    {
        if (a1.destination >= a2.destination)
            return true;
        else
            return false;
    }
}


}
