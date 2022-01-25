using System;

namespace Donguler_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            Console.Write("Sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);

            }

            //1 ile 100 arasındaki tek ve sayıların toplamı 
            int toplamCift = 0;
            int toplamTek = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i%2==1)
                {
                    toplamCift = toplamCift + i;
                }
                else
                {
                    toplamTek = toplamTek + i;
                }

            }
            Console.WriteLine(toplamCift);
            Console.WriteLine(toplamTek);

            //Break,continue

            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }

        }
    }
}
