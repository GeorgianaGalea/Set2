using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul 1: ");
            int nrpreced= int.Parse(Console.ReadLine());
            bool crescator = true;
            bool descrescator= true;
            for (int i = 2; i <= n; i++)
            {
                Console.Write($"Introduceti numarul {i}: ");
                int nrcurent = int.Parse(Console.ReadLine());
                if (nrcurent > nrpreced)
                    descrescator = false;
                if (nrpreced > nrcurent)
                    crescator = false;
                nrpreced = nrcurent;
            }

            if(crescator)
            {
                Console.WriteLine("secventa este monotona crescatoare");
            }
            if(descrescator)
                Console.WriteLine("secventa este monotona descrescatoare");
           Console.ReadKey();
        }
        
    }
}
