using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritancee
{
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurar");
        }
    }

    public class Surungenler : Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        public void SurunerekHareket()
        {
            Console.WriteLine("Sürünerek hareket ederler");
        }
    }

    public class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        public void UcarakHareket()
        {
            Console.WriteLine("Kuslar ucarlar");
        }
    }
}
