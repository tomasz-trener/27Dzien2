using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieListy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adresPodstawowy = "https://www.google.com/search?q=pogoda ";
            string szukanyZnak = "°";
            string znakKoncowy = ">";

            List<int> listaTempertur = new List<int>();
            List<string> listaMiast = new List<string>();


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

                        // ddodajemy opcje liczenia średniej temperatury 
                        listaMiast.Add(miasto);
                        listaTempertur.Add(Convert.ToInt32(wynik.Substring(0,wynik.Length-2))); // usuwamy znaki °C
                        // teraz liczymy srednia temperatura 
                        double sredniaTemp = 0;
                        foreach (var t in listaTempertur)
                            sredniaTemp += t;

                       // sredniaTemp = sredniaTemp / listaTempertur.Count;
                        sredniaTemp /= listaTempertur.Count;

                        string raport = string.Format("Średnia temperatura z listy ({0}) to: {1}",
                            string.Join(", ", listaMiast), sredniaTemp);
                        Console.WriteLine(raport);
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
