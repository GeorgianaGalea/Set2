using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());

            int neg = 0;
            int poz = 0;
            int zero = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                int nr = int.Parse(Console.ReadLine());

                if (nr < 0)
                {
                    neg++;
                }
                else if (nr == 0)
                {
                    zero++;
                }
                else
                {
                    poz++;
                }
            }
            Console.WriteLine($"in sirul citit sunt {neg} nr negative, {poz} nr pozitive si {zero} numere egale cu 0");

        }
    }
}
