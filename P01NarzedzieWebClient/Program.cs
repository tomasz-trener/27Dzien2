using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P01NarzedzieWebClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
             WebClient wc = new WebClient();

            string dane = wc.DownloadString("https://www.google.com/search?q=pogoda warszawa");

            Console.WriteLine(dane);

            File.WriteAllText("c:\\dane\\strona.html", dane);

            Console.ReadKey();
        }
    }
}
