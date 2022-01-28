using System;

namespace Class_Encapsulation_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation : Bir nesnenin bazı özelliklerini veya metotlarını diğer class'lardan ve diğer nesnelerden korumak anlamına gelir. Bunları erişim belirleyiceler ile
            //bunu yaparız. --- Bir değere atama yaparken istemediğim bir değerse bir hata fırlatsın istiyorsak encapsulation kullanılır.
            //Propertyler yardımıyla encapsulation kullanılarak, sınıfın üyelerini (propertylerini) kapayabiliriz yada istediğimiz değişim yapılmasına izin verebiliriz.
            //GET ve SET--- get sadece okuma --- set -- yazma -- set tanımlamazsak sadece okuma yapılır
            //Encapsule edilen propertyler istediğimiz işlemler sadece yapılsın istiyorsak ona istediğimiz logic verirsek o işlemi yapar sadece.  PUBLİC olanta tanımlanır bu.

            Console.WriteLine("********1. Ogrenci**************");
            Ogrenci ogrenci1 = new Ogrenci("Fuat","Aydın",367,12);
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();

            Console.WriteLine("********2. Ogrenci**************");
            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.Isim = "ayşe";
            ogrenci2.SoyIsım = "yilmaz";
            ogrenci2.OgrNo = 60;
            ogrenci2.Sinif = 10;
            ogrenci2.OgrenciBilgileriniGetir();
            ogrenci2.SinifAtlat();
            ogrenci2.OgrenciBilgileriniGetir();

            Console.WriteLine("********3. Ogrenci**************");

            Ogrenci ogrenci3 = new Ogrenci("Deniz","Arda",256,1);
            ogrenci3.SinifDusur();
            ogrenci3.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim;  //bu propertyleri olusturduk , bide dısardan baska sınıftan kontrollu erısmek ıcın public encapsulation yapalım

        private string soyIsım; //Olusturulan property isminin uzerıne gel ve---- encapsulation use property bas.

        private int ogrNo;   

        private int sinif;

        public string Isim { get => isim; set => isim = value; }  //Get : okuma 
        public string SoyIsım { get => soyIsım; set => soyIsım = value; }  // Set : yazma --- bir verinin sadece okumasını istiyorsak ona sadece GET ver
        public int OgrNo { get => ogrNo; set => ogrNo = value; }
        public int Sinif   //------------------------Burada özel logic durum verdil SET degerine !!!!!!!!!!!!!
        { 
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir !");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }    
            }
        }

        public Ogrenci(string ısim, string soyIsım, int ogrNo, int sinif) //Dolu const -- field uzerıne git --- add Cont
        {
            Isim = ısim;
            SoyIsım = soyIsım;
            OgrNo = ogrNo;
            Sinif = sinif;
        }

        public Ogrenci() // Bos Const
        {
   
        }

        public void OgrenciBilgileriniGetir() //Ogrenci bilgilerini tutan metot
        {
            Console.WriteLine("************* Ogrenci Bilgileri ************************");
            Console.WriteLine($"Ogrenci ad : {this.Isim}, soyad : {this.SoyIsım}, no: {this.OgrNo}, sinif :{this.Sinif}");
        }

        public void SinifAtlat()  //ogrencinin sınıfını atlatan metot
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()  //ogrencinin sınıfını dusuren metot
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}