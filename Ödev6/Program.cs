using System;

namespace Ödev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunAdi = "Redmi Telefon";
            urun1.urunResmi = "Resmini Yüklendi.";
            urun1.urunfiyati = 3189.91;
    
            Urun urun2 = new Urun();
            urun2.urunAdi = "Kondisyon Bisikleti";
            urun2.urunResmi = "Resmi Yok";
            urun2.urunfiyati = 1379.00;

            //tanımladığım urunleri urun dizisine ekledim.
            Urun[] urunler = new Urun[] {urun1,urun2};
            //for ile
            for (int i = 0; i < urunler.Length; i++)
            {
                
               Console.WriteLine(urunler[i].urunAdi + " : " + urunler[i].urunResmi + " : " + urunler[i].urunfiyati);
                
            }
            Console.WriteLine("For bitti.");
            //foreach ile
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + " : " + urun.urunResmi + " : " + urun.urunfiyati);
            }
            Console.WriteLine("Foreach bitti.");
            //while ile
            int a = 0;
            while (a<urunler.Length)
            {
                Console.WriteLine(urunler[a].urunAdi + " : " + urunler[a].urunResmi + " : " + urunler[a].urunfiyati);
                a= a + 1;
            }
            Console.WriteLine("While bitti.");
        }
    }
    //Urun clası tanımladım.
    class Urun
    {
        public string urunAdi { get; set; }
        public string urunResmi { get; set; }
        public double urunfiyati { get; set; }

    }
}
