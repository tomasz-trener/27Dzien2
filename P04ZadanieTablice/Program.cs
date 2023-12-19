using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieTablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adresPodstawowy = "https://www.google.com/search?q=pogoda ";
            string szukanyZnak = "°";
            string znakKoncowy = ">";

            string[] miastaZPliku = null;

            try
            {
                miastaZPliku = File.ReadAllLines(@"c:\dane\miasta.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("Nie udało wczytać pliku");
                Console.ReadKey();
            }
            

            if (miastaZPliku != null)
            {

                Console.WriteLine("Dostępne miasta:");
                for (int i = 0; i < miastaZPliku.Length; i++)
                    Console.WriteLine($"[{i + 1}] {miastaZPliku[i]}");

                while (true)
                {
                    Console.WriteLine("Wybierz miasto (podaj numer)");

                    try
                    {
                        int nrMiasta = Convert.ToInt32(Console.ReadLine());
                        string miasto = miastaZPliku[nrMiasta - 1];
                        string adres = adresPodstawowy + miasto;

                        WebClient wc = new WebClient();
                        string dane = wc.DownloadString(adres);

                        int indx = dane.IndexOf(szukanyZnak);
                        int aktualnaPozycja = indx;

                        while (dane.Substring(aktualnaPozycja, 1) != znakKoncowy)
                            aktualnaPozycja--;

                        string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja + 1);

                        Console.WriteLine($"Temperatura dla miasta {miasto} wynosi: {wynik}");
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText(@"c:\dane\errors\errorlog.txt", Environment.NewLine + DateTime.Now + " " + ex.Message);
                        Console.WriteLine("Nie udało się pobrać temperatury");
                    }
                   
                }
            }
            
        }
    }
}
