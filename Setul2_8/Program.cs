using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea lui n: ");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
                Console.WriteLine($"al {n}-lea numar din sirul lui fibonacci este 0");
            else if (n == 2)
                Console.WriteLine($"al {n}-lea numar din sirul lui fibonacci este 1");
            else
            {
                int nrPreced = 0;
                int nrCurent = 1;

                for (int i = 3; i <= n; i++)
                {
                    int k = nrCurent;
                    nrCurent = nrCurent + nrPreced;
                    nrPreced = k;
                }
                Console.WriteLine($"al {n}-lea numar din sirul lui fibonacci este {nrCurent}");
            }
        }
    }
}
