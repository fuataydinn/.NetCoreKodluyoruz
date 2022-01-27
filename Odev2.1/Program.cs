using System;
using System.Collections;

namespace Odev2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            string input;
            int sayi;
            ArrayList asallar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Lüften {i}. sayıyı giriniz:");
                input = Console.ReadLine();
                if (!int.TryParse(input, out sayi))
                {
                    Console.WriteLine("Lüffen geçerli sayı giriniz!");
                    i = i - 1;
                    continue;
                }
                else if (sayi <= 0)
                {
                    Console.WriteLine("Lüffen geçerli sayı giriniz!");
                    i = i - 1;
                    continue;
                }
                else
                {
                    if (asalSayi(sayi) && sayi != 1)
                    {
                        asallar.Add(sayi);
                        asallar.Sort();
                    }
                    else
                    {
                        asalOlmayanlar.Add(sayi);
                        asalOlmayanlar.Sort();
                    }
                }
            }
            Console.WriteLine("Asal sayılar");
            foreach (var asal in asallar)
            {
                Console.WriteLine($" {asal} ");
               
            }
            Console.WriteLine("Asal Olmayan sayılar");
            foreach (var asalOlmayan in asalOlmayanlar)
            {
                Console.WriteLine($"{asalOlmayan} ");
               
            }

            Console.WriteLine("Asal sayısı: "+asallar.Count);
            Console.WriteLine("Asal olmayan sayısı: "+asalOlmayanlar.Count);
        }

        private static bool asalSayi(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

    }


}
