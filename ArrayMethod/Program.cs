using System;

namespace ArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort - Sıralama

            int[] sayiDizisi = { 23, 12, 86, 72, 3, 11, 17 };

            Console.WriteLine("Sırasız Dizi Elamanları");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("Sıralı Dizi Elemanları");
            Array.Sort(sayiDizisi); //Direk verilen diziyi sıralar
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //clear - verilen dizi içerisinde verilen  verilen indexten başlayarak verilen eleman sayısı kadar sıfırlar.
            Console.WriteLine("Clear Array");
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse - Tersine çevirme işlemi
            Console.WriteLine("Reverse Array");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf  - Verilen dizi üzerinde verilen elemanın eğer içerisinde varsa kaçıncı index'te oldugunu soyler
            Console.WriteLine("IndexOf Array");
        
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //Resize  - Diziyi yeniden boyutlandırırız

            Console.WriteLine("Array Resize");

            Array.Resize<int>(ref sayiDizisi, 9);  // 7 elemanlı diziyi 9 elemanlı yap dedik
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

        }
    }
}
