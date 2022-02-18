using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaKonzole
{
    class Program
    {
        static void Main(string[] args)
        {
            //ifrastruktura
            Console.WriteLine("Zadejte číslo: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Číslo {0} není prvočíslo.", n);
            }

            else if (n == 3)
            {
                Console.WriteLine("Číslo {0} je prvočíslo.", n);
            }
            else if (n % 3 == 0)
            {
                Console.WriteLine("Číslo {0} není prvočíslo.", n);
            }

            else if (n % 5 == 0)
            {
                Console.WriteLine("Číslo {0} není prvočíslo.", n);
            }

            else Console.WriteLine("Číslo {0} je prvočíslo.", n);

            Console.ReadLine();
        }
    }
}
