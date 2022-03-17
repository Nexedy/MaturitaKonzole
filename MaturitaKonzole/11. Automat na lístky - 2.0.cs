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

            Console.WriteLine("Zadejte vzdálenost");
            int a = int.Parse(Console.ReadLine());

            if (a < 8)
            {
                if (a < 7)
                {
                    if (a < 5)
                    {
                        if (a < 3)
                        {
                            Console.WriteLine("Jízdenka" +
                             "---------------------" +
                                "Vzdálenost: 1-3 km" +
                                 "Cena: 15.KČ");
                        }


                    }
                    else Console.WriteLine("Jízdenka" +
                    "---------------------" +
                    "Vzdálenost: 4-5 km" +
                    "Cena: 13.KČ");
                }

                else Console.WriteLine("Jízdenka" +
                        "---------------------" +
                        "Vzdálenost: 6-7 km " +
                        "Cena: 11.KČ");
            }

            else Console.WriteLine("Jízdenka" +
                         "---------------------" +
                         "Vzdálenost: 8+ km" +
                         "Cena: 10.KČ"); ;

            Console.Read();
        }
    }
}
