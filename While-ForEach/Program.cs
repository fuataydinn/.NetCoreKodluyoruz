using System;

namespace While_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While

            //  1 den başlayarak girilen sayıya kadar sayı dahil ortalama hesaplayan program 

            Console.WriteLine("Lütfen sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);


            // a dan z ye kadar olan tğm harfleri yaz 

            char character = 'a';
            while (character<'z')
            {
                Console.WriteLine(character);
                character++;
            }

            Console.WriteLine("***************ForEach********************");

            string[] Arabalar = {"bmw","audi","tofaş" };

            foreach (var listele in Arabalar)
            {
                Console.WriteLine(listele);
            }

        }
    }
}
