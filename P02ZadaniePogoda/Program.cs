using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadaniePogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adresPodstawowy = "https://www.google.com/search?q=pogoda ";
            string szukanyZnak = "°";
            string znakKoncowy = ">";

            while (true)
            {
                Console.WriteLine("Podaj nazwę miasta");
                string miasto = Console.ReadLine();
                string adres = adresPodstawowy + miasto;

                WebClient wc = new WebClient();
                string dane = wc.DownloadString(adres);

                int indx = dane.IndexOf(szukanyZnak);
                int aktualnaPozycja = indx;

                while (dane.Substring(aktualnaPozycja,1) !=  znakKoncowy)
                    aktualnaPozycja--;

                string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja + 1);
                Console.WriteLine(wynik);

            }
        }
    }
}
