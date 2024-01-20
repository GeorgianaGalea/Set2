using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul 1: ");
            int nrPrecedent = int.Parse(Console.ReadLine());
            int grup;
            if (nrPrecedent != 0)
                 grup = 1;
            else
                 grup = 0;
            for (int i = 2; i <= n; i++)
            {
                Console.Write($"Introduceti numarul {i}: ");
                int numarCurent = int.Parse(Console.ReadLine());

                if (numarCurent != 0)
                {
                    if (nrPrecedent == 0)
                    {
                        grup++;
                    }
                }

                nrPrecedent = numarCurent;
            }
            Console.WriteLine($"Numarul de grupuri consecutive diferite de zero este: {grup}");
        }
    }
}
