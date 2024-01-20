using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max= int.MinValue;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                int numar = int.Parse(Console.ReadLine());

                if (numar < min)
                {
                    min = numar;
                }

                if (numar > max)
                {
                    max = numar;
                }
            }

            Console.WriteLine($"Cea mai mica valoare din secventa este: {min}");
            Console.WriteLine($"Cea mai mare valoare din secventa este: {max}");
            Console.ReadLine();
        }
    }
}
