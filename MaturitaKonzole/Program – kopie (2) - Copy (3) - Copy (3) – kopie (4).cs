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

            Console.WriteLine("Zadejte vzdálenost vaší jízdy: ");
            int a = int.Parse(Console.ReadLine());

            if (a <= 3)
            {
                Console.WriteLine("15.kč");
            }

            if (4 <= a )
            {

            }
        }
    }
}
