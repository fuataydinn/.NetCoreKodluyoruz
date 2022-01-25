using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            //Expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayındasınız");
                    break;
               
                default:
                    Console.WriteLine("Yanlış veri girişi yaptınız");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındasınız");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlk Bahar ayındasınız");
                    break;

                default:
                    break;
            }
        }
    }
}
