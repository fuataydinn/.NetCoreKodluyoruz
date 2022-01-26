using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out : Bir fonksiyone bir iş yaptırıp ve yapılan iş sonucunda değerin setlenip o değeri kullanmak istiyorsak bu kullanılır.

            string sayi = "999";
            int outSayi;
            bool sonuc = int.TryParse(sayi, out outSayi);

            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //Metot Aşırı Yükleme -Overloading
            // Bir fonksiyonun imzası değişerek birden fazla kez kullanılabilir. (metodAdı + parametreSayısı + Parametre)

            int ifade = 999;
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Fuat", "Aydın");
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}
