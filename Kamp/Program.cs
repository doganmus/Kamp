using System;

namespace Kamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama
            String kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun >dolarBugun)
            {
                Console.WriteLine("Aşağı Ok");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Yukarı Ok");
            }


            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
