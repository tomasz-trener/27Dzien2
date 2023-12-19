using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15KonwersjaTablicIList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tab = { "a", "b", "c" };
            List<string> list = tab.ToList();

            string[] tab2 = list.ToArray();
        }
    }
}
