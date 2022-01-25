using System;

namespace If_Else_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
           
            
            if (time>6 && time<11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time<18)
            {
                Console.WriteLine("İyi günler");
            }
            else
            {
                Console.WriteLine("İyi akşamlar");
            }

            string sonuc ;

            sonuc = time >= 6 && time <= 11 ? "Günaydın" : time < 18 ? "iyi günler" : "iyi gececler";

            Console.WriteLine(sonuc);
        }
    }
}
