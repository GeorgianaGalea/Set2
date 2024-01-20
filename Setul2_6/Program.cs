using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_6
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("introduceti numarul 1:");
            int nrpreced = int.Parse(Console.ReadLine());
            bool a = true;
            for (int i = 1; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                int numar = int.Parse(Console.ReadLine());
                if (numar < nrpreced)
                {
                    Console.WriteLine("secventa nu e in ordine crescatoare");
                    a=false;
                    break;
                }
                nrpreced = numar;
            }
            if(a)
            Console.WriteLine("secventa e in ordine crescatoare");
        }

    }
}
