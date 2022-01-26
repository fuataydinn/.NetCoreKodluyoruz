using System;

namespace StringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz C# hos geldiniz!";
            string degisken2 = "Dersimiz ";

            //Length:

            Console.WriteLine(degisken.Length);

            //ToUpper , ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat (iki adet string degeri birleştirir...parametre olarak girmeyi unutma)

            Console.WriteLine(String.Concat(degisken,"merhaba"));

            //CompareTo :
            /* 
             * 1. degisken==2. degisken ise sonuc : 0
             * 1.Degisken > 2. degisken ise sonuc : 1
             * 1. Degisken < 2. degisken ise sonuc: -1
            */

            Console.WriteLine(degisken.CompareTo(degisken2));

            //Contains (degiskenin içinde degisken2 varsa true)
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("geldiniz!"));
            Console.WriteLine(degisken.StartsWith("Dersimiz2"));

            //IndexOf (h ilk nerde gorurse bize ındex'ını verecek)
            Console.WriteLine(degisken.IndexOf("hos"));
            Console.WriteLine(degisken.LastIndexOf("i"));  // sondan ilk nerede i geçiyor

            //Insert (nerden baslayacagını soyle sonra string ekle)

            Console.WriteLine(degisken.Insert(0,"merhaba! "));

            //PadLeft, PadRight
            // PadLeft (degiskenin solunu degiskenle beraber 30'a tamamlayana kadar bosluk veya girilen degeri ekle)

            Console.WriteLine(degisken+degisken2.PadLeft(30));
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50)+degisken2);
            Console.WriteLine(degisken.PadRight(50,'*')+degisken2);

            //Remove (10. indexten başlayarak sonuna kadar siler)

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3)); //5. indexten basla 3 karakter sil

            //Replace (verilen değeri değişir.)

            Console.WriteLine(degisken.Replace("C#","CSharp"));

            //Split (bosluklara göre diziye belirtilen indexteki elemanı getir)
            Console.WriteLine(degisken.Split(' ')[1]);

            //SubString (4. indexten başlayıp sonuna kadar getirir.)
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6)); //4. indexten başlayarak 6 karakter getir.






        }

    }
}
