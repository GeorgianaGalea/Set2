using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            bool esteCrescatoareRotita = crescatoare(n);

            if (esteCrescatoareRotita)
            {
                Console.WriteLine("Secventa este crescatoare rotita.");
            }
            else
            {
                Console.WriteLine("Secventa nu crescatoare rotita.");
            }
        }

        static bool crescatoare(int n)
        {
            Console.Write("Introduceti numarul 1: ");
            int numarPrecedent = int.Parse(Console.ReadLine());

            int Rotire = -1;

            for (int i = 2; i <= n; i++)
            {
                Console.Write($"Introduceti numarul {i}: ");
                int numarCurent = int.Parse(Console.ReadLine());

                if (numarCurent < numarPrecedent)
                { 
                    Rotire = i - 1;
                    break;
                }

                numarPrecedent = numarCurent;
            }

            if (Rotire == -1)
            {
                return true;
            }
            return crescatoareRotita(n, Rotire);
        }

        static bool crescatoareRotita(int n, int indexRotire)
        {
            Console.Write($"Introduceti numarul {indexRotire + 1}: ");
            int numarPrecedent = int.Parse(Console.ReadLine());

            for (int i = indexRotire + 2; i <= n; i++)
            {
                Console.Write($"Introduceti numarul {i}: ");
                int numarCurent = int.Parse(Console.ReadLine());

                if (numarCurent < numarPrecedent)
                {
                    return false; 
                }

                numarPrecedent = numarCurent;
            }

            for (int i = 1; i < indexRotire; i++)
            {
                Console.Write($"Introduceti numarul {i}: ");
                int numarCurent = int.Parse(Console.ReadLine());

                if (numarCurent < numarPrecedent)
                {
                    return false; 
                }

                numarPrecedent = numarCurent;
            }

            return true; 
        }
    }
}
