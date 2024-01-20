using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti numarul cautat: ");
            int a = int.Parse(Console.ReadLine());
            bool nr = false;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                int numar = int.Parse(Console.ReadLine());

                if (numar == a)
                {
                    Console.WriteLine($"pozitia lui a in secventa este {i}");
                    nr = true;
                    break;
                }
            }

            if (!nr)
                Console.WriteLine("numarul nu se afla in secventa");

        }
    }
}
