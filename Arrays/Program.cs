using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];

            string[] hayvanlar = new string[] { "Kedi","kopek" };

            int[] dizi;

            dizi = new int[5];

            // Dizilere deger atama ve erisim

            renkler[0] = "siyah";
            
            dizi[3] = 11;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[3]);

            //Dongulerle dizi kullanımı
            // klavyeden girilen n tane sayının ortalamasını alan program

            Console.Write("Lütfen dizinin eleman sayısını giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.WriteLine($"Lütfen {i+1}. sayıyı giriniz");
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam = toplam + sayi;
            }
            int ortalama;

            ortalama = toplam / diziUzunlugu;

            Console.WriteLine("Ortalama: {0}",ortalama);

        }
    }
}
