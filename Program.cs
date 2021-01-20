using System;

namespace Poz_lui_a
{
    
    class Program
    {
     

        static void Main(string[] args)
        {
            string n, a, b, pz;
            int nr, val_a, i = 0, poz, bg;
            poz = 0;
            Console.Write("Lungimea secventei=");
            n = Console.ReadLine();
            Console.Write("Numarul cautat=");
            a = Console.ReadLine();
            nr = Convert.ToInt32(n);
            val_a = Convert.ToInt32(a);
            while (i<nr)
            {
                b = Console.ReadLine();
                bg = Convert.ToInt32(b);
               if (bg == val_a)
                    poz = i;
              i++;
            }if (poz == 0)
                Console.WriteLine("-1");
            else
            {
                pz = Convert.ToString(poz);
                Console.WriteLine("Pozitia numarului cautat este {0}", pz);
            }
        }
    }
}
