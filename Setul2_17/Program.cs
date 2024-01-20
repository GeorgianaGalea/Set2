using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti secventa de 0 si 1: ");
            string n = Console.ReadLine();

            int parantezeDeschise = 0;
            int lvlMax = 0;
            int lvlCurent = 0;

            foreach (char caracter in n)
            {
                if (caracter == '0')
                { 
                    parantezeDeschise++;
                    lvlCurent++;

                    if (lvlCurent > lvlMax)
                    {
                        lvlMax = lvlCurent;
                    }
                }
                else if (caracter == '1')
                {
                    if (parantezeDeschise == 0)
                    {
                        Console.WriteLine("Secventa nu este corecta.");
                        return;
                    }

                    parantezeDeschise--;
                    lvlCurent--;
                }
            }

            if (parantezeDeschise == 0)
            {
                Console.WriteLine($"Secventa este corecta. Nivelul maxim de incuibare este {lvlMax}.");
            }
            else
            {
                Console.WriteLine("Secventa nu este corecta.");
            }
            Console.ReadLine();
        }
    }
    
}
