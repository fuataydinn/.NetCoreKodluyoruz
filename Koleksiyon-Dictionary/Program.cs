using System;
using System.Collections.Generic;

namespace Koleksiyon_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictonery -- anahtar ve veri olarak tutar verileri. Dictonary tanımlarken bunlar belirtmemiz gerekir.
            // Dizilere eklenen elemanlarına deger , onlara ulasmak istedigimiz indexkleri de key olarak düşünebiliriz. 
            //System.Collection.generic
            // KEY DEGERİ UNİQ OLAMALİİ !!!

            Dictionary<int, string> kullanicilar = new Dictionary<int, string>(); //key int, value string dedik...
            kullanicilar.Add(10,"Fuat Aydın");
            kullanicilar.Add(12, "Ahmet Kaya");
            kullanicilar.Add(13, "Ufuk Yılmaz");
            kullanicilar.Add(20, "Ayşe Demir");
          //  kullanicilar.Add(12, "Murat");  -------------------hata verir , uniq olmalı key

            //Dizinin elemanlarına erişim

            Console.WriteLine("********* Elemanlara Erişim*****");
            Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Count 
            Console.WriteLine("*****Count*********");
            Console.WriteLine(kullanicilar.Count);

            // Contains 
            Console.WriteLine("*****Contains*********");
            Console.WriteLine(kullanicilar.ContainsKey(12));  // 12 key'ine sahip eleman var mı 
            Console.WriteLine(kullanicilar.ContainsValue("FuatAydın"));

            //Remove 

            Console.WriteLine("***********Remove*********");
            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Keys 
            Console.WriteLine("***********Keys*********");
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("***********Values*********");

            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }



        }
    }
}
