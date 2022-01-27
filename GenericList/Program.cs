using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //        Koleksiyonlar:
            // Ne kadar veri tutacağımız yada veri türü program akısına göre belli oluyor.
            // Dizilerde sonradan bunlar değişmediği için koleksiyonlar bizim için önemlidir.
            //Koleksiyonlar nesnelerden oluşur.Her nesnenin tipi object’tir.
            //System collection adında çalışırlar.
            //--Deger tip; int , long ,char , bool , byte …
            //--Referans tip: string , object ,class , interface, KOLEKSİYONLAR… 
            //Bir değer tipin referans tipe dönusturulme işlemine boxing denir tersine unboxing denir.
            //*Yukarıda görüldüğü gibi bir değer tipi koleksyona atamak için boxing yapmamız gerekir. Koleksiyondan bişi okurken unboxing yapmamız gerekir.

            //Genel Amaçlı Koleksiyonlar : **List** ArrayList **Dictionary** HashTable *** Queue** Stack Sorted List
            //Özel Amaçlı Koleksiyonlar : ** Hybrit Dictionary ** Name Value Dictionary** String Collection** String Dictionary







            // List<T>
            //System.Collection.Generic
            //T-> object türündedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(5);
            sayiListesi.Add(7);
            sayiListesi.Add(2);
            sayiListesi.Add(8);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("siyah");
            renkListesi.Add("beyaz");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.ForEach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(5);  // 5 ve maviyi sildi
            renkListesi.Remove("mavi");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0); // indisine göre sildi
            renkListesi.RemoveAt(1);

            //Liste içerisinde arama

            if (sayiListesi.Contains(5))
            {
                Console.WriteLine("5 sayısı listede var");
            }

            //Eleman ile index'e erişme  
            Console.WriteLine(renkListesi.BinarySearch("siyah"));

            //Diziyi listeye çevirme

            string[] hayvanlar = { "kedi", "köpek", "kuş" };

            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            //Listeyi temizleme

            hayvanlarListesi.Clear();

            // Liste içerisinde nesne tutmak 
            List<Kullanicilar> kullanıcıListesi = new List<Kullanicilar>(); //buna eleman atayabilmek için kullanılar listesinin nesnelerini olusturcaz asagıda
            Kullanicilar kullanici1 = new Kullanicilar();                 // public olan buyuk Isme erişebildik diğer isim e ulasamayız encapsulation yaptıgımız ıcın
            kullanici1.Isim = "Fuat";
            kullanici1.SoyIsım = "Aydın";
            kullanici1.Yas = 28;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Ayse";
            kullanici2.SoyIsım = "Aydın";
            kullanici2.Yas = 25;

            kullanıcıListesi.Add(kullanici1); // kullanıcılar class'ından olusan 2 adet nesneyi kullanıcılar tipinde listeye ekledik
            kullanıcıListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Murat",
                SoyIsım = "Odabaş",
                Yas = 29
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine(kullanıcı.Isim);
                Console.WriteLine(kullanıcı.SoyIsım);
                Console.WriteLine(kullanıcı.Yas);
            }





        }
    }
    public class Kullanicilar
    {
        private string isim;

        private string soyIsım;

        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsım { get => soyIsım; set => soyIsım = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
