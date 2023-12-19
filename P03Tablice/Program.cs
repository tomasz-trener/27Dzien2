using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string miasto1 = "warszawa";
            string miasto2 = "kraków";
            string miasto3 = "wrocław";

            string[] miasta = new string[4];
            miasta[0] = miasto1;
            miasta[1] = miasto2;
            //...
            miasta[3] = "gdańsk";

            //miasta[4] = "gdynia"; bład programu : wyjscie poza zakres tablicy 

            int dlugoscTablicy = miasta.Length; // 4

            Console.WriteLine(miasta[0]); // warszawa
            Console.WriteLine(miasta[2]); // ? możemy sprawdzić w trybie debugowania 

            int[] temperatury = new int[2];
            int?[] liczbyNullable = new int?[2];

            // inne sposoby tworzenia tablic : 
            int[] liczby = new int[3] { 4, 6, 3 }; // tablica z odrazu uzupełnionymi wartościami 
            int[] liczby2 = new int[] { 4, 6, 4, 6, 9 }; // inny sposób na tworzenie tablicy 
            int[] liczby3 = { 4, 6, 4, 6, 9 }; // jeszcze inny sposób na tworzenie tablicy 

            liczby2[1] = 9; // w tablicy moge podmienić wartość komórki 
            // tablice mają ustaloną, niezmienna długość 

            // tablice mogą być dowolnego typu 
            bool[] tablicaWartosciLogicznych = { true, true, false };
            char[] znaki = { 'a', 'b', 'c' };

            Console.ReadKey();
        }
    }
}
