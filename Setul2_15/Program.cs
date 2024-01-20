using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            bool bitonica = VerificaBitonica(n);

            if (bitonica)
            {
                Console.WriteLine("Secventa este bitonica.");
            }
            else
            {
                Console.WriteLine("Secventa nu este bitonica.");
            }
        }
        static bool VerificaBitonica(int n)
        {
            Console.Write("Introduceti numarul 1: ");
            int numarPrecedent = int.Parse(Console.ReadLine());

            bool cresc = false;
            bool descresc = false;

            for (int i = 2; i <= n; i++)
            {
                Console.Write($"Introduceti numarul {i}: ");
                int numarCurent = int.Parse(Console.ReadLine());

                if (numarCurent > numarPrecedent)
                {
                    cresc = true;
                }
                else if (numarCurent < numarPrecedent)
                {
                    descresc = true;
                }

                if (cresc && descresc)
                {
                    return true; 
                }

                numarPrecedent = numarCurent;
            }

            return false; 
        }
    }
}
