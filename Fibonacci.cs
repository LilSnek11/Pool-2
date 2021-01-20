using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string c, d;
            int n, f1 = 0, f2 = 1, aux=0;
            c = Console.ReadLine();
            n = Convert.ToInt32(c);
            for(int i=3;i<=n;i++)
            { aux = f2;
                f2 = f2 + f1;
                f1 = aux;
            }
            d = Convert.ToString(f2);
            Console.WriteLine("Numarul este {0}", d);

        }
    }
}
