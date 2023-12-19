using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10TabliceWielowymiarowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tablicaJednowymiarowa = new string[3];

            string[,] tablicaDwuwymiarowa = new string[4, 2];

            string[,,] tablicaTrzywymiarowa = new string[4, 2, 2];

            tablicaTrzywymiarowa[0, 0, 0] = "a";
            tablicaTrzywymiarowa[0, 0, 1] = "b";

            int dlugosc = tablicaTrzywymiarowa.Length; // 16
            int wielkoscWymiaruPierwszegoZKolei = tablicaTrzywymiarowa.GetLength(0); // 4

            tablicaDwuwymiarowa[0, 0] = "A";
            tablicaDwuwymiarowa[0, 1] = "B";

            tablicaDwuwymiarowa[1, 0] = "C";
            tablicaDwuwymiarowa[1, 1] = "D";

            tablicaDwuwymiarowa[2, 0] = "E";
            tablicaDwuwymiarowa[2, 1] = "F";

            tablicaDwuwymiarowa[3, 0] = "G";
            tablicaDwuwymiarowa[3, 1] = "H";

            // teraz wyswietlamy tablice w konsoli 

            Console.WriteLine("--- sposób 1 --- wymiar 0 to wiersze a wymiar 1 to kolumny");
            
            for (int i = 0; i < tablicaDwuwymiarowa.GetLength(0); i++)
            {
                for (int j = 0; j < tablicaDwuwymiarowa.GetLength(1); j++)
                    Console.Write(tablicaDwuwymiarowa[i,j] + " ");

                Console.WriteLine();
            }

            Console.WriteLine("--- sposób 2 --- wymiar 1 to wiersze a wymiar 0 to kolumny");

            for (int i = 0; i < tablicaDwuwymiarowa.GetLength(1); i++)
            {
                for (int j = 0; j < tablicaDwuwymiarowa.GetLength(0); j++)
                    Console.Write(tablicaDwuwymiarowa[j,i] + " ");

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
