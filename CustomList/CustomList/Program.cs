using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> x = new CustomList<int>();
            x.Add(3);
            x.Add(4);
            x.Add(5);
            x.Add(6);
            x.Add(7);
        }
    }
}
