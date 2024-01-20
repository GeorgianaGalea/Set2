using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            bool a = monotona(n);
            if (a)
                Console.WriteLine("Secventa este monotona rotita");
            else
                Console.WriteLine("Secventa nu este monotona rotita");

        }
        static bool monotona(int n)
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

                if (numarCurent > numarPrecedent)
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


            return monotonaRotita(n, Rotire);
        }

        static bool monotonaRotita(int n, int Rotire)
        {

            Console.Write($"Introduceti numarul {Rotire + 1}: ");
            int numarPrecedent = int.Parse(Console.ReadLine());

            for (int i = Rotire + 2; i <= n; i++)
            {
                Console.Write($"Introduceti numarul {i}: ");
                int numarCurent = int.Parse(Console.ReadLine());

                if (numarCurent < numarPrecedent)
                {
                    return false;
                }


                if (numarCurent > numarPrecedent)
                {
                    return false;
                }

                numarPrecedent = numarCurent;
            }


            for (int i = 1; i < Rotire; i++)
            {
                Console.Write($"Introduceti numarul {i}: ");
                int numarCurent = int.Parse(Console.ReadLine());

                if (numarCurent < numarPrecedent)
                {
                    return false;
                }

                if (numarCurent > numarPrecedent)
                {
                    return false;
                }

                numarPrecedent = numarCurent;
            }

            return true;
        }
    }
    
}
