using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyon_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.collection namespace

            ArrayList liste = new ArrayList();
            //liste.Add("fuat");
            //liste.Add(2);
            //liste.Add('c');
            //liste.Add(false);

            //içerisinde verilere erişim
            //Console.WriteLine(liste[1]);

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}

            //AddRange (birden fazla elamanı toplu halde ekleme)
            Console.WriteLine("*******Add Range***********");

            //Collection tipinde herşey eklenebilir. Aşağıda olusturalım-- dizi falan collection
            //string[] renkler = new string[] {"kırmızı","sarı","yeşil" };
            List<int> sayilar = new List<int>() {1,3,12,25,10 };

            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort --Sıralama  // içerisinde string oldugu için çalıstırma esnasında sıralama yaparken patlar bu dikkat edilmeli !-- stringleri commentle sonra asagdaki koc calıstır

            Console.WriteLine("**********Sort************");
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Binary Search (once sırala sonra binary searce index'ine erişilir.)

            Console.WriteLine("*******Binart Search**************");

            Console.WriteLine(liste.BinarySearch(25)); //25 -- 4. indexte


            //Reverse (tersine çeviriyor)

            Console.WriteLine("******* Reverse **************");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Clear 

            Console.WriteLine("****** Clear **********");
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

        }
    }
}
