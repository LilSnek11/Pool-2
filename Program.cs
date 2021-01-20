using System;

namespace Suma_si_prod_a_n_nr
{
    class Program
    {
        static void Main(string[] args)
        {
            string c, s, p;
            int n, suma, produs, i;
            suma = 0;
            produs = 1;
            i = 1;
            c = Console.ReadLine();
            n = Convert.ToInt32(c);
            while(i<=n)
            {
                
                suma = suma + i;
                produs = produs * i;
                i++;
            }
            s = Convert.ToString(suma);
            p = Convert.ToString(produs);
            Console.WriteLine("Suma este {0}", s);
            Console.WriteLine("Produsul este {0}", p);
        }
    }
}
