using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    //hataya neden olabilecek kod buraya yazılır
            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata : "+ex.Message.ToString());
               
            //}
            //finally
            //{
            //    //bir kod bloğu hata alsın almasın çalıstırılmasını istediğimiz başka kod varsa buraya yaz
            //    Console.WriteLine("İşlem tamamlandı.");
            //}

            // Diğer özel exceptionlara bakalım...

            try
            {
                // int a = int.Parse(null);
              //  int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("Boş değer girdiniz!");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz!");
                Console.WriteLine(ex);
            }
           
        }
    }
}
