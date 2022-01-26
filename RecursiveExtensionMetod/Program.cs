using System;

namespace RecursiveExtensionMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif --- Öz Yinelemeli (kendi kendini çağıran fonksiyon)
            //faktöriyel ve üs alma gibi işlemler bunla yapılabilir. For döngüsü ve Rekürsif aynı işlemi yapar

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);
            Islemler instance = new Islemler();
            Console.WriteLine(instance.Expo(3, 4));

            //Extension Metodlar (Mevcut olan fonksiyonu daha kolay yazabilmek, veya cok kullanılan bir fonksiyon varsa onun için kullanılır)
            //cümlede boşluk var mı bakmak için bir extension fonk olusturcaz
            string ifade = "Fuat Aydın";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLoverCase());

            int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };  // bunu sıralayan extension metod yazalım
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());

        }
    }
    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
            {
                return sayi;
            }
            return Expo(sayi, us - 1) * sayi;
        }
        //Expo(3,4)
        //Expo(3,3)*3
        //Expo(3,2)*3*3
        //Expo(3,1)*3*3*3
        //3*3*3*3=3^4

    }
    //Extension class'lar ve metotlar static olmalı !
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        //bosluk varsa silen metod
        public static string RemoveWhiteSpaces(this string param)
        {
            string [] dizi=param.Split(" "); // bu stringi boşluklara göre ayır ve bir diziye at
            return string.Join("*", dizi); // string dizisini boş olmayanla birleştir

        }
        //verilen string ifadeyi buyuk harfe çeviren metod

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLoverCase(this string param)
        {
            return param.ToLower();

        }

        public static int[] SortArray(this int [] param)
        {
            Array.Sort(param);
            return param;

        }
        //int diziyi ekrana yazdırmaya yarıyan ext metot
        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }
        //verilen sayı çift mi ? 
        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;

        }
        //Verilen string degerin ilk karakterini veren metot
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }

    }
}
