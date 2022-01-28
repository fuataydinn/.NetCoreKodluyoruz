using System;

namespace OOP_Inheritancee
{
    class Program
    {
        static void Main(string[] args)
        {
            /*                           Canlılar
             *                              | 
                            Bitkiler                         Hayvanlar
                               |                                 |
                Tohumlu             Tohumsuz    Surungenler          Kuslar 

             */

            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
          
            tohumluBitkiler.TohumlaCogalma();

            Console.WriteLine("***************");
            Kuslar kartal = new Kuslar();
          
            kartal.UcarakHareket();
        }
    }
}
