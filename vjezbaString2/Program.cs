using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaString2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst;

            Console.WriteLine("Napišite neki tekst.");
            
            tekst = Console.ReadLine();

            Console.WriteLine(tekst.Replace(" ", "_"));

            Console.ReadKey();
        }
    }
}
