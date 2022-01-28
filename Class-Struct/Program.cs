using System;

namespace Class_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            // Struct (Yapılar) : Class'lar gibidir kendi field, property, fonksiyonları vardır.
            //Class'tan farkı ise, DEGER TİPTİR ! 
            //Classlar ve structların consttructar kullanımı farklıdır..! Structta içi dolu Constructar'a izin verir sadece !!!! 

            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;
            Console.WriteLine($"Class alan hesapla : {dikdortgen.AlanHesapla()}");

            Dikdortgen_Struct dikdortgen_Struct;  // new ile nesnesini olusturmasakta olur
            dikdortgen_Struct.KisaKenar = 3;
            dikdortgen_Struct.UzunKenar = 4;
            Console.WriteLine($"Struct alan hesapla : {dikdortgen_Struct.AlanHesapla()}");

            Dikdortgen_Struct dikdortgen_Struct2 = new Dikdortgen_Struct(5, 6);
            Console.WriteLine($"Struct alan hesapla : {dikdortgen_Struct2.AlanHesapla()}");




        }

        class Dikdortgen
        {
            public int KisaKenar;
            public int UzunKenar;

            public Dikdortgen()
            {
                this.KisaKenar = 4;
                this.UzunKenar = 3;
            }

            public long AlanHesapla()
            {
                return this.KisaKenar * this.UzunKenar;
            }
        }

        struct Dikdortgen_Struct
        {
            public int KisaKenar;
            public int UzunKenar;

            public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
            {

                KisaKenar = kisaKenar;
                UzunKenar = uzunKenar;
            }
            public long AlanHesapla()
            {
                return this.KisaKenar * this.UzunKenar;
            }

        }
}

}
