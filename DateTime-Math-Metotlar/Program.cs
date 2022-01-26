using System;

namespace DateTime_Math_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(2));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(2));

            //DateTime Format  (Tarihi istediğimiz formatta yazmak için kullanılır)
            Console.WriteLine(DateTime.Now.ToString("dd")); //24 --- integer olarak ayın 24 unu getirir.
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat --- string olarak 3 karakter seklınde getırır
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday 

            Console.WriteLine(DateTime.Now.ToString("mm")); //04
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

            Console.WriteLine("***********************math*************************************");
            //Math 

            Console.WriteLine(Math.Abs(-1));  //mutlak deger
            Console.WriteLine(Math.Sin(10));  // sinus

            Console.WriteLine(Math.Ceiling(22.3)); //22.3 ten buyuk en kucuk tam sayı -- 23
            Console.WriteLine(Math.Round(22.3)); // en yakın -- 22 
            Console.WriteLine(Math.Floor(22.7)); // 22.7 den kucuk en buyuk tam sayı --- 22 


            Console.WriteLine(Math.Min(2,6));
            Console.WriteLine(Math.Min(2,6));


            Console.WriteLine(Math.Pow(3, 4));  // Us alma  --- 81 
            Console.WriteLine(Math.Sqrt(9));    // Karekok --- 3 
            Console.WriteLine(Math.Log(9));    // Logaritma 
            Console.WriteLine(Math.Exp(3));    // e^3


        }
    }
}
