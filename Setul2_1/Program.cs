using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            int nrpar = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                int nr = int.Parse(Console.ReadLine());

                if (EstePar(nr))
                {
                    nrpar++;
                }
            }

            Console.WriteLine($"Dintre cele {n} numere, {nrpar} sunt pare.");
            Console.Read();
        }

        static bool EstePar(int numar)
        {
            return numar % 2 == 0;
        }
    }
 }

