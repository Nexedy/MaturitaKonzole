using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaKonzole
{
    class Program
    {
        private static void Money(int x)
        {
            int a;
            int b;
            int c;
            int d;
            int e;
            int f;
            int g;
            int h;
            

            a = x / 50;
            Console.WriteLine("Suma potřebuje {0} padesátikorun.", a);
            a = x % 50;

            b = a / 20;
            Console.WriteLine("Suma potřebuje {0} dvacetikorun.", b);
            b = a % 20;

            c = b / 10;
            Console.WriteLine("Suma potřebuje {0} desetikorun.", c);
            c = b % 10;

            d = c / 5;
            Console.WriteLine("Suma potřebuje {0} pětikorun.", d);
            d = c % 5;

            e = d / 2;
            Console.WriteLine("Suma potřebuje {0} dvoukorun.", e);
            e = d % 2;

            f = e / 1;
            Console.WriteLine("Suma potřebuje {0} korun.", f);






        }
        static void Main(string[] args)
        {
            //ifrastructure
            Console.WriteLine("Zadejte sumu peněz: ");
            int x = int.Parse(Console.ReadLine());

            Money(x);
            Console.ReadLine();
        }
    }
}
