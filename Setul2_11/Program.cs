using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            double sInvers = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Introduceti numarul {i}: ");
                double numar = double.Parse(Console.ReadLine());
                if (numar != 0)
                    sInvers += 1 / numar;
                else

                    Console.WriteLine("Numarul introdus este zero. Inversul sau nu poate fi calculat.");
            }
            Console.WriteLine($"Suma inverselor secventei este: {sInvers}");
        }
    }
}
