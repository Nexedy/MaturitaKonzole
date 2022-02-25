using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaturitaKonzole
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamWriter sw = new StreamWriter(@"název souboru"))
            {
                int n;

                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }

                Console.WriteLine("Tohle jsou prvočísla ze souboru: {0} ", n);
            }

        }
    }
}
