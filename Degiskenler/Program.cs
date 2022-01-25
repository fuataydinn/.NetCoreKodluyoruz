using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;   // 1 byte
            sbyte c = 5;  // 1 byte

            short s = 5;  // 2 byte
            ushort us = 5; // 2 byte

            Int16 i16 = 2; // 2 byte
            int i = 2;     // 4 byte
            Int32 i32 = 2; // 4 byte
            Int64 i64 = 2;  // 8 byte

            uint ui = 2;  //4 byte
            long l = 4;    //8 byte
            ulong ul = 4;  //8 byte

            // Reel Sayılar

            float f = 5;  //4 byte
            double d = 5; // 8 byte
            decimal de = 5; // 16 byte

            char ch = '2';  // 2 byte
            string str = "fuat"; //sınırsız

            bool bl = true;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = 'x';
            object o2 = "y";
            object o3 = 5;
            object o4 = 5.2;

            //String ifadeler 

            string strn = string.Empty;
            strn = "fuat";
            string ad = "fu";
            string soyad = "ay";
            string tam = ($"{ad}   {soyad}");
            Console.WriteLine(tam);


            //boolean

            bool bol1 = 10 > 2;

            //değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;

            string yeni = str20 + int20.ToString();

            Console.WriteLine(yeni);

            int int21 = int20 + Convert.ToInt32(str20);

            int int22 = int20 + int.Parse(str20);

            //datetime

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);


            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);





        }
    }
}
