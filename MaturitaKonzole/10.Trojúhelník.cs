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
           Console.WriteLine("Zadejte hodnotu a: ");
            int a = int.Parse(Console.ReadLine());

           Console.WriteLine("Zadejte hodnotu b: ");
            int b = int.Parse(Console.ReadLine());

           Console.WriteLine("Zadejte hodnotu c: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (a + b >= c)
            {
                Console.WriteLine("Trojúhleník existuje!");
            }

            else Console.WriteLine("Trojúhelník neexistuje!");

            if (a > b)
            {
                a = c;
                c = a;
            }

            else if (b > a)
            {
                b = c;
                c = b;
            }

            else if (a > c)
            {
                a = c;
                c = a;
            }

            else if (b > c)
            {
                b = c;
                c = b;
            }

            int d = a * a;
            int e = b * b;
            int f = c * c;


            //pravouhly kokotko
            if (d + e = f)
            {

            }

        }
    }
}
