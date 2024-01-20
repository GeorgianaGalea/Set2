using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti nr n");
            int n= int.Parse(Console.ReadLine());
            int s = (n * (n + 1)) / 2;
            Console.WriteLine($"suma numerelor de la 1 la n este {s}");
            int p = 1;
            for (int i = 2; i <= n; i++)
            {
                p *= i;
            }
            Console.WriteLine($"produsul numerelor de la 1 la n este {p}");
        }
    }
}
