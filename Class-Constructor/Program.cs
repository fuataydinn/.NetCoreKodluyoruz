using System;

namespace Class_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructar : Bir sınıfın new ile nesnesi olustugunda arka planda çalıştırılan metotlardır.
            //Bir nesne oluşturuldugunda otomatik olarak arkada yapılmasını istediğimiz bir şey varsa bu kullanılır.
            //Sınıf ismi ile AYNI olmak zorunda ! 
            //PUBLİC olmak zorunda 
            // Geri döüş tipi yazılmaz !!!

            Calisan calisan1 = new Calisan("Fuat","Aydın",18,"Yazılım");  //İçi dolu Constructer
            calisan1.CalisanBilgileri();
            Console.WriteLine("*************İçi Boş Const*************");

            Calisan calisan2 = new Calisan(); //İçi boş constructar
            calisan2.Adi = "Selman";
            calisan2.Soyad = "Bilgen";
            calisan2.No = 25;
            calisan2.Departman = "Gemici";

            calisan2.CalisanBilgileri();

        }
    }

    class Calisan
    {
        //Bu verilere başka sınıfta erişmek için instance(örnek) yaratmak zorunlu ! Mainde yapalım

        public string Adi { get; set; }
        public string Soyad { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }

        public Calisan(string ad, string soyad, int no, string departman) //4 tane dışarıdan deger alan ve bu class'ın propertylerini set eden bir constructor yaptık
        {
            this.Adi = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan()  
        {

        }
        public void CalisanBilgileri()
        {
            Console.WriteLine($"Çalışan Adı: {Adi}, Soyadı : {Soyad}, No: {No}, Departmanı: {Departman}");
        }


    }
}
