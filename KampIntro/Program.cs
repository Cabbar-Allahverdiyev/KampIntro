using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type saffety-tip guvenliyi
            // do not yourself-ozunu tekrarlama
            //katagoriEtiketi-deyer tutucu,yeniki leqebde demek olar
            string katagoriEtiketi = "katagori";
            int ogrenciSayisi =32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalis butonu goster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artis butonu");
            }
            else
            {
                Console.WriteLine("deyismedi butonu");
            }

            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("Kullanici ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(katagoriEtiketi);

        }
    }
}
