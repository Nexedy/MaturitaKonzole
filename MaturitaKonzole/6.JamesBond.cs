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
            char x = Convert.ToChar(92); // obrácené lomítko
            char y = Convert.ToChar(34); // uvozovky

            Console.WriteLine("James Bond {0} {1} Agent 007 {1} {0} # 150%záruka # \n / Spol. s ručením neomezeným ", x, y);
            Console.ReadLine();
        }
    }
}
