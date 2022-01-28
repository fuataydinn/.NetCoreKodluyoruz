using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritancee
{
    public class Bitkiler : Canlilar
    {
        protected void Fotosentez()  //prptected : sadece kendisinden kalıtım alan nesnelere erişim izni verir
        {
            Console.WriteLine("Bitkiler fotosentez yapar");
        }
    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()   //Constractar olustur !
        {
            base.Fotosentez();  //------base: kalıtım alınan üst sınıfa erişmek için kullanılan anahtar kelime 
            base.Beslenme();    //kalıtım aldığım sınıfın, kalıtım aldıgı sınıflara da erişebiliriz base ile 
            base.Bosaltım();
            base.Solunum();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumla çogalırlar");
        }

    }

    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        public void TohumsuzBitki()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çogalırlar");
        }
    }   

}

