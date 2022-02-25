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

            //interface
            Console.WriteLine("Zadejte požadovanou částku od 1-200: ");
            int n = 0;

            while (n != 0)
            {

                if (n % 50 == 0)
                {
                    int x;
                    n / 2 = x;
                    Console.WriteLine("Bude te potřebovat {0} padesátikorun", x);
                }

                else
                {
                    if (n % 20 == 0 )
                    {
                        int y;
                        n % 5 = y;
                        Console.WriteLine("Bude te potřebovat {0} dvacetikorun.", y);
                    }

                    else
                    {
                        if (n % 10 == 0)
                        {
                            int t;
                            n % 10 = t;
                            Console.WriteLine("Budete potřebovat {0} desetikorun.", t);
                        }

                        else
                        {
                            if (n % 5 == 0)
                            {
                                int p;
                                n % 5 = p;
                                Console.WriteLine("Budete potřebovat {0} pětikorun.", p);
                            }

                            else
                            {
                                if (n % 2 == 0)
                                {
                                    int i;
                                    n % 2 = i;
                                    Console.WriteLine("Budete potřebovat {0} dvoukorun.", i);
                                }

                                else
                                {
                                    if (n % 1 == 0)
                                    {
                                        int q;
                                        n % 1 = q;
                                        Console.WriteLine("Budete potřebovat {0} korun.", q);
                                    }
                                }
                            }
                        }
                    }
                }



            }

            Console.Read();

        }
    }
}
