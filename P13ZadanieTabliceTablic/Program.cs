using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P13ZadanieTabliceTablic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(sciezka);

            string[] tabSep = { Environment.NewLine };
            string[] wiersze = dane.Split(tabSep, StringSplitOptions.RemoveEmptyEntries);

            int liczbaWierszy = wiersze.Length - 1;

            string[][] tab = new string[liczbaWierszy][];

            for (int i = 1; i <= liczbaWierszy; i++)
                tab[i - 1] = wiersze[i].Split(';');

            // wyswietlanie z zastosowaniem join 
            foreach (var zw in tab)
                Console.WriteLine(string.Join(" ", zw));

            // wyswietalnie bez join 
            foreach (var zw in tab)
            {
                foreach (var k in zw)
                    Console.Write(k+ " ");

                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
