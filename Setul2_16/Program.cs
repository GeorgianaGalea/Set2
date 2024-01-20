using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            if (EsteBitonicRot(n))
            {
                Console.WriteLine("Secventa este bitonica rotita.");
            }
            else
            {
                Console.WriteLine("Secventa nu este bitonica rotita.");
            }
        }
        static bool EsteBitonicRot(int n)
        {
            if (n < 3)
            {
                return false;
            }
            Console.Write("Introduceti numarul 1: ");
            int numarPreced = int.Parse(Console.ReadLine());
            bool cresc = true;
            bool descresc = false;
            for (int i = 1; i < n; i++)
            {
                Console.Write("Introduceti urmatorul element: ");
                int numarCurent = int.Parse(Console.ReadLine());
                if (numarCurent == numarPreced)
                {
                    return false;
                }
                if (numarCurent > numarPreced)
                {
                    if (descresc)
                    {
                        return false;
                    }
                    cresc = true;
                }
                else
                {
                    cresc = true;
                }
                if (descresc && numarCurent > numarPreced)
                {
                    return true;
                }
                numarPreced = numarCurent;
            }
            return false;
        }
    }
    
}
