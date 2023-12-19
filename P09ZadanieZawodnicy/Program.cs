using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P09ZadanieZawodnicy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj kraj");
            string kraj = Console.ReadLine().ToLower();

            const string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            //sciezka = "x"; zabezpieczenie dla innych programistów przed próba nadpisania tej wartości 

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(sciezka);

            string[] separatorWierszy = { "\r\n" };
            string[] wiersze = dane.Split(separatorWierszy, StringSplitOptions.RemoveEmptyEntries);

            List<string> zawodnicy = new List<string>();
            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                if (komorki[4].ToLower() == kraj)
                    zawodnicy.Add(komorki[2] + " " + komorki[3]);
            }

            const string sciezkaWynik = @"c:\dane\kraje";
            if (!Directory.Exists(sciezkaWynik))
                Directory.CreateDirectory(sciezkaWynik);

            if (!File.Exists(sciezkaWynik + $"\\{kraj}.txt"))
                File.WriteAllLines(sciezkaWynik + $"\\{kraj}.txt", zawodnicy);

        }
    }
}
