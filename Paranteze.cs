using System;

namespace paranteze
{
    class Program
    {
        static void Main(string[] args)
        {
            string n, l;
            int p , d, c = 0, f = 0;
            n=Console.ReadLine();
            d = Convert.ToInt32(n);
            p = d;

            if (d == 1)
                Console.WriteLine("Sirul este incorect lol.");
            else
             while(d==1 || d==0)
            { n = Console.ReadLine();
                d = Convert.ToInt32(n);
                    if (d == p)
                        c++;
                    else if (f < c)
                    {
                        f = c;
                        c = 0;
                    }
                    else c = 0;
              if (d == 0 || d ==1 )
                        p = d;
                      

              } 
            if (p == 1)
            {
                l = Convert.ToString(f);
                Console.WriteLine("Numarul maxim de incuibare este {0}", l );
            }
              else
                Console.WriteLine("Sirul este incorect lol.");
                       


        }
    }
}
