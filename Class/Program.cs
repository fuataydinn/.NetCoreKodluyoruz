using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             class sinifAdi
            {

             [Erişim Belirleyici] [Veri Tipi] OzellikAdi;  --- property                  -----sınıf metot ve property'den olusur.
             [Erişim belirleyici] [Geri Dönüş Tipi] MetotAdı([Parametre Listesi])  --- Metot
               {
                 Metot komutları
               }

             }

            Sınıflar : Nesne yönelimli programlamanın en temelidir. Tüm metotlar ve özellikler (propertyler) bir sınıf içerisinde tutulur.
            Bütün metotları tek sınıfa yazmak yerine, farklı sınıflara yazmak gerekir.


          */

            //Erişim Belirleyiciler
            /*
             * Public: Heryerden erişebilir
             * Private: Sadece tanımlanılan sınıfın içinde erişilir.
             * Internal: Kendi bulundugu proje içinde erişilir.
             * Protected: Sadece tanımlandıgı sınıfta veya kalıtım alan diğer sınıflardan erişilebilir.    
             
             */
            Calisan calisan1 = new Calisan();
            calisan1.Adi = "Fuat";
            calisan1.Soyad = "Aydın";
            calisan1.No = 18;
            calisan1.Departman = "Yazılım";

            calisan1.CalisanBilgileri();
            Console.WriteLine("*******************************");

            Calisan calisan2 = new Calisan();
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

        public void CalisanBilgileri()
        {
            Console.WriteLine($"Çalışan Adı: {Adi}, Soyadı : {Soyad}, No: {No}, Departmanı: {Departman}" );
        }


    }
}
