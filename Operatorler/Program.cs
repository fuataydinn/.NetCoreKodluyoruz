using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve işlemli atama

            int x = 3;
            int y = 5;
            y = y + 2;

            Console.WriteLine(y);
            y += 3;
            Console.WriteLine(y);
            y /= 2;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            //Mantıksal operatorler || , && , ! 

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess&&isCompleted)
            {
                Console.WriteLine("perfect");
            }

            if (isSuccess || isCompleted)
            {
                Console.WriteLine("great");
            }

            if (isSuccess && ! isCompleted)
            {
                Console.WriteLine("fine!");
            }


            // ilişkisel operatorler    <,>, <=, >=, == , ! 

            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);

            sonuc = a >= b;

            Console.WriteLine(sonuc);

            // aritmetik operatorler * , + , - , / , %

            int sayi = 10;
            int sayi2 = 5;

            int sonuc1 = sayi / sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi++;

            Console.WriteLine(sonuc1);

           
        }
    }
}
