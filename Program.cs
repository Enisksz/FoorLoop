using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoorLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* //Ekrana girilen sayıya kadar olan sayıları ekrana bastır.

            int sayac = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayac; i++)
            {
                if(i%2==1)
                    Console.WriteLine(i);
            }


            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını yaz.

            int tekToplam = 0;
            int ciftToplam = 0;

            for(int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i;
                else
                    ciftToplam += i;

                Console.WriteLine(tekToplam);
                Console.WriteLine(ciftToplam);
           */
                //break continue

                for (int i = 0; i < 10 ; i++)
                {
                    if (i == 4)
                        break;
                    Console.WriteLine(i);
                }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }

        }

        }
    }
}
