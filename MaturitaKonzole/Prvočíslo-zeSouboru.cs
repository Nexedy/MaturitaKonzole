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
            //streamReader
            string cesta = @"C:\Users\frand\source\repos\MaturitaKonzole\Pokus.txt";
            string imput = "";
            using (StreamReader sr = File.OpenText(cesta))
            {
                while ((imput = sr.ReadLine()) != null)
                {
                    Console.WriteLine(imput);
                }
                Console.WriteLine();
            }

            //string to int
            int cisla = Convert.ToInt32(imput);

            //pravidla pro prvočísla
           
            

                if (cisla % 2 == 0)
                {
                    Console.WriteLine("Číslo není prvočíslo.");
                }

                else if (cisla == 3)
                {
                    Console.WriteLine("Číslo je prvočíslo.");
                }

                else if (cisla % 3 == 0)
                {
                    Console.WriteLine("Cislo není prvočíslo.");
                }

                else if (cisla % 5 == 0)
                {
                    Console.WriteLine("Cislo není prvočíslo.");
                }

                else Console.WriteLine("Číslo je prvočíslo.");

            

            //čtení do konzole
            Console.Read();
        }
    }
}
