using System;

namespace Class_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enum : Sıralı olan verilerde , birden fazla değeri belli olan değişkenlerde kullanılabilirler.
            //Programda değişkenleri tek tek tanımlamak yerine enum kullanılabilir.
            //Numeric olan veriyi anlamlı olarak tutmamıza yarar.

            Console.WriteLine(Gunler.Cuma);
            Console.WriteLine((int)Gunler.Pazar); //numeric degerine erişmek için int yaptık turunu

            int sicaklik = 32;

            if (sicaklik<=(int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekleyelim.");
            }
            else if (sicaklik>=(int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün!");
            }
            else if (sicaklik>=(int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSıcak)
            {
                Console.WriteLine("Hadi dışarıya çıkalım");
            }

        }
    }

    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi=23,  //her zaman 1 ardışık gider
        Pazar         //24
    }

    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sıcak=25,
        CokSıcak=35
    }
}
