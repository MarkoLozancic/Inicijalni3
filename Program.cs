using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int a, b;
            double c, d;
            a = 10;
            b = 7;
            c = 12.5;
            d = 16.7;
            Console.WriteLine("Prosjecna vrijednost je: " + ((a + b + c + d) / 4));
            Console.ReadKey();
        }
    }
}
