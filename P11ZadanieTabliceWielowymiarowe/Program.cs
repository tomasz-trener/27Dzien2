using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P11ZadanieTabliceWielowymiarowe
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
            int liczbaKolumn = wiersze[0].Split(';').Length;

            string[,] tab = new string[liczbaWierszy, liczbaKolumn];

            // wczytywanie danych do tablicy 
            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                for (int j = 0; j < komorki.Length; j++)
                    tab[i - 1, j] = komorki[j];
            }

            // wyswietlenie danych 
            Console.WriteLine("--- sposób 1 ---");
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                    Console.Write(tab[i,j] + " " );
                
                Console.WriteLine();
            }

            Console.WriteLine("--- sposób 2 ---");
            for (int i = 0; i < tab.GetLength(1); i++)
            {
                for (int j = 0; j < tab.GetLength(0); j++)
                    Console.Write(tab[j, i] + " ");

                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
