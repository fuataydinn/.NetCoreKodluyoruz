using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("Imlicit Conversion");

            byte a = 3;
            short b = 2;
            sbyte c = 5;

            int d = a + b + c ;
            Console.WriteLine($"d: {d}");

            long h = d;
            Console.WriteLine($"h: {h}");

            float i = h;
            Console.WriteLine($"i: {i}");

            string j= "fuat";
            char k= 'f';
            object g = j + k + d;
            Console.WriteLine($"g: {g}");

            //Explicit Conversion(Bilinçli Dönüşüm)
            Console.WriteLine("Explicit Conversion");

            int x = 5;
            byte y = (byte)x;
            Console.WriteLine($"y: {y}");

            int s = 100;
            byte t = (byte)s;
            Console.WriteLine($"t: {t}");

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine($"v: {v}");

            //ToString Metodu
            Console.WriteLine("ToString Conversion");

            int xx = 3;
            string yy = xx.ToString();
            Console.WriteLine($"yy: {yy}");

            string zz = 12.5.ToString();
            Console.WriteLine($"zz: {yy}");

            //System.Conver
            Console.WriteLine("SystemConvert sınıfı");

            string s1 ="3", s2 = "5";

            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam: "+toplam);

            //Parse 
            Console.WriteLine("Parse ");

            string metin1 = "10";
            string metin2 = "15";

            int rakam1 ;
            double rakam2;

            rakam1 = int.Parse(metin1);
            rakam2 = double.Parse(metin2);

            Console.WriteLine($"rakam 1 : {rakam1} rakam 2 : {rakam2}");


        }
    }
}
