using System;

namespace Nr_pare_si_neg
{
    class Program
    {
        static void Main(string[] args)
        {
            string n, o, p, d;
            int m, nr, neg, poz, zero;
            neg = 0;
            poz = 0;
            zero = 0;
            n = Console.ReadLine();
            m = Convert.ToInt32(n);
            for(int i = 1; i <= m; i++)
                { o = Console.ReadLine();
                nr = Convert.ToInt32(o);
                if (nr == 0)
                    zero++;
                else if (nr > 0)
                    poz++;
                else neg++;
            }
            o = Convert.ToString(zero);
            p = Convert.ToString(poz);
            d = Convert.ToString(neg);
            Console.WriteLine("{0} numere sunt zero",o);
            Console.WriteLine("{0} numere sunt pozititve",p);
            Console.WriteLine("{0} numere sunt negative",d);



        }
    }
}
