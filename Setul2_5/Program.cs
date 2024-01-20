using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            int egalpoz = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                int nr = int.Parse(Console.ReadLine());

                if (nr == i)
                {
                    egalpoz++;
                }
            }
                Console.WriteLine($"in secventa sunt {egalpoz} numere egale cu pozitia lor");
        }
    }
}
