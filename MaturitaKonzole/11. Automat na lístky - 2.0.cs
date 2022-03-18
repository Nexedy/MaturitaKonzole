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

            if (a <= 3)
            {
                Console.WriteLine("Jízdenka:");
                Console.WriteLine("Km: {0}", a);
                Console.WriteLine("Cena: {0}",a * 15);
            }

            if (a > 3 && a <= 5)
            {
                Console.WriteLine("Jízdenka:");
                Console.WriteLine("Km: {0}", a);
                Console.WriteLine("Cena: {0}", a * 13);
            }

            if (a > 5 && a <= 7)
            {
                Console.WriteLine("Jízdenka:");
                Console.WriteLine("Km: {0}", a);
                Console.WriteLine("Cena: {0}", a * 11);
            }

            if (a >= 8)
            {
                Console.WriteLine("Jízdenka:");
                Console.WriteLine("Km: {0}", a);
                Console.WriteLine("Cena: {0}", a * 10);
            }

            Console.Read();
        }
    }
}
