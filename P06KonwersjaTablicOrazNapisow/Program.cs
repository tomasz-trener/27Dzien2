using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06KonwersjaTablicOrazNapisow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zdanie = "ala ma kota";

            // SPLIT - rozdzielenie 

            string[] wyrazy = zdanie.Split(' ');

            string zdanie2 = "ala!$ma**kota";

            string[] separatory = { "!$", "**" };

            string[] wyrazy2 = zdanie2.Split(separatory,StringSplitOptions.RemoveEmptyEntries);

            // JOIN - łaczenie 

            string[] tablica = { "jan", "ola", "adam" };

            string wynik = string.Join(" - ", tablica);
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
