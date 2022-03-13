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

            Console.WriteLine("Vyberte jakou vzdálenost chcete urazit: ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. 1-3 km");
            Console.WriteLine("2. 4-5 km");
            Console.WriteLine("3. 5-7 km");
            Console.WriteLine("4. >8 km");
            Console.WriteLine("-----------------------------------------");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");

            int b = Convert.ToInt32(a);

            switch (b)
            {
                case 1:
                    Console.WriteLine("Jízdenka");
                    Console.WriteLine("----------");
                    Console.WriteLine("Pásmo: 1");
                    Console.WriteLine("Cena: 15.KČ");
                    break;

                case 2:
                    Console.WriteLine("Jízdenka");
                    Console.WriteLine("----------");
                    Console.WriteLine("Pásmo: 2");
                    Console.WriteLine("Cena: 13.KČ");
                    break;

                case 3:
                    Console.WriteLine("Jízdenka");
                    Console.WriteLine("----------");
                    Console.WriteLine("Pásmo: 3");
                    Console.WriteLine("Cena: 11.KČ");
                    break;

                case 4:
                    Console.WriteLine("Jízdenka");
                    Console.WriteLine("----------");
                    Console.WriteLine("Pásmo: 4");
                    Console.WriteLine("Cena: 10.KČ");
                    break;

                default:
                    Console.WriteLine("Nezadali jste hodnotu.");
                    break;
            }

            Console.Read();


        }
    }
}
