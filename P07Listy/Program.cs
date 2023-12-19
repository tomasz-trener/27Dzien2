using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tablice mają stałą długość 

            string[] tablicaMiast = new string[3] { "warszawa", "kraków", "gdańsk" };

            // listy mają zmienna długość 

            List<string> listaMiast = new List<string>(); // ta lista ma 0 elementów 

            if (listaMiast == null)
            {
                // ta lista nie jest null !
            }

            List<string> listaPusta = null; // lista która jest null 
            //listaPusta.Add("warszawa"); // uzycie dowolnej metody na obiekcie pustym
            // zawse generuje blad 

            listaMiast.Add("Warszawa");
            listaMiast.Add("Gdańsk"); // Add dodaje element na koniec listy 
            listaMiast.Insert(1, "Kraków"); // Insert wstawia na konkretną pozycje a pozostałe elementy 
                                            // przesuwają się w lewo 

            //listaMiast.Insert(4, "Paryż"); // wyjscie poza zakres

            string miasto1 = listaMiast[0]; // pierwszy element 
            string miastoOstatnie = listaMiast[listaMiast.Count - 1];

            listaMiast.RemoveAt(1); // usun drugi element (liczby od 0) 
            listaMiast.Remove("Gdansk"); // usuwa pierwszy znaleziony elment 
            
            //listaMiast.RemoveAll() -- jak to dziala powiemy pózniej 


        }
    }
}
