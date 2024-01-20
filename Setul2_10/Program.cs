using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti numarul 1: ");
            int numarPrecedent = int.Parse(Console.ReadLine());
            int consec = 1;
            int maxConsec = 0;
            for(int i = 2; i<=n; i++)
            {
                Console.Write($"Introduceti numarul {i}:");
                int numarCurent = int.Parse(Console.ReadLine());
                if (numarCurent == numarPrecedent)
                    consec++;
                else
                    consec = 1;
                if(consec>maxConsec) 
                    maxConsec = consec;
                numarPrecedent=numarCurent;
            }
            Console.WriteLine($"numarul de elemente egale consecutive este {maxConsec}");
        }
    }
}
