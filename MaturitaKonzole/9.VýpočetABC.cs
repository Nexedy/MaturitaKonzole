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
            int a = 2;
            int b = 2;
            int c = 1;
            int d = 0;
            int e = 4;

            int A = a++ / ++c * --e;
            int B = --b * c++ - a;
            int C = -b - --c;
            int D = ++a - --e;
            int E = e / --a * b++ / c++;
            int F = a %= b = d = 1 + e / 2;

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.WriteLine(D);
            Console.WriteLine(E);
            Console.WriteLine(F);

            Console.ReadKey();
        }
    }
}
