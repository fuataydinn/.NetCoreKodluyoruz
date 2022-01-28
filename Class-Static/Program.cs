using System;

namespace Class_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static metoda o metodun adı ile erişilir, nesne oluşturulamaz.
            //Bir sınıfı static yaparsak, onun içindeki tüm fieldlar, propertyler, metotlar static olmak zorunda. Hersey static olmak zorunda 


            Console.WriteLine($"Calısan sayısı: {Calisan.CalisanSayisi}");

            Calisan calisan = new Calisan("Fuat","Aydın","IK");
            Console.WriteLine($"Calısan sayısı: {Calisan.CalisanSayisi}");
            Calisan calisan1 = new Calisan("Selman", "Bilgen", "IK");
            Calisan calisan2 = new Calisan("Barış", "Çakan", "IK");

            Console.WriteLine($"Calısan sayısı: {Calisan.CalisanSayisi}");

            //Islemler ıslemler = new Islemler();
            //ıslemler.   -------------------------static olanların nesnesi olusturulamaz !!!

            Console.WriteLine("Toplama islemi sonucu:" + Islemler.Topla(23, 3));  //static metodlara direk metod adı ile nesne olusturmadan erişilir.
            Console.WriteLine("Cıkarma islemi sonucu:" + Islemler.Cikar(50, 3)); 
           
        }
    }

    class Calisan  //static olmayan elemanlar nesneye özgü iken (static olmayan classlar için)
    {             //static olan elemanlar sınıf bazında atanır
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;  // Bunlar sadece sınıf içinde calisan field'lar private oldugu için
        private string SoyIsim;
        private string Departman;

        static Calisan()  //static constructarların erişim belirteci yoktur.
        {
            calisanSayisi = 0;  //calisan sayısını sadece calisan sınıfı içerisinde degistirmek istiyorum.
        }

        public Calisan(string isim, string soyIsim, string departman)
        {
            this.Isim = isim;
            this.SoyIsim = soyIsim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
