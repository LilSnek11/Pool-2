using System;

namespace Secventa_nr_pare
{
    class Program
    {
        static void Main(string[] args)
        {
            string n,o;
            int m, p, nr;
            p = 0;
            n = Console.ReadLine();
            m = Convert.ToInt32(n);
            for (int i = 1; i <= m; i++)
            {
                o = Console.ReadLine();
                nr = Convert.ToInt32(o);
                if (nr % 2 == 0)
                    p++;
            }
                        n=Convert.ToString(p);
            Console.Write("{0} sunt pare",n );

        }
    }
}
