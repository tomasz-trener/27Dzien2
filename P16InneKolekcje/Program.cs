using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16InneKolekcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Queue (Kolejka)
            // koleja typu FIFO (First-In-First-Out) - oznacza, że pierwszy element, który zostanie
            // dodany będzie też pierwszym elementem, który zostanie usunięty 

            Queue<int> kolejka = new Queue<int>();
            kolejka.Enqueue(1); // dodaje na koniec kolejki 
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);

            int pierwszy = kolejka.Dequeue(); // usuwa i zwraca pierwszy element kolejki 

            //2. Stack (stos) - kolejka typu LIFO (Last-In-Frist-Out) co oznacza, że ostatni 
            // dodany do kolejkcji element będzie pierwszym, który zsotanie usunięty 

            Stack<int> stos = new Stack<int>();
            stos.Push(1); // dodaje element na wierzch stosu 
            stos.Push(2);
            stos.Push(3);

            int ostatni = stos.Pop(); // usuwa i zwraca ostatni element ze stosu 

            foreach (var item in stos) // kolejnosc zgodna z typem kolekcji czyli dla stosu bedzie 3,2,1
            {
                Console.WriteLine(item);
            }
             

            // zastosowanie: np obsługa magazynu aby produkty nie leżały w magazynie zbyt długo 

            // 3. HasSet (Zbiór)

            // zbiór to kolekcja, która przechowuje unikatowe elementy w nieuporządkowanej formie 
            HashSet<int> zbior = new HashSet<int>();
            zbior.Add(1); // dodaje element do zbioru 
            zbior.Add(2);
            zbior.Add(2); // Nie zostanie dodane bo już istnieje (ignoruje go)

            bool czyIstnieje = zbior.Contains(2); // sprawdza czy element istnieje 

            // 4. Dictionary (Słownik) 
            Dictionary<int, string> slownik = new Dictionary<int, string>();
            slownik.Add(1, "Adam");
            slownik.Add(4, "Ola");
            slownik.Add(2, "Tomasz");

            string osoba = slownik[2]; // Tomasz

            // 5. SortedDictionary (słownik posortowany) 
            SortedDictionary<string, string> slownikPosortowany = new SortedDictionary<string, string>();
            slownikPosortowany.Add("Kowalski", "Adam");
            slownikPosortowany.Add("Nowak", "Ola");
            slownikPosortowany.Add("Anowacki", "Tomasz");

            foreach (var o in slownikPosortowany)
            {
                Console.WriteLine(o.Value);
            }
            Console.ReadKey();
        }
    }
}
