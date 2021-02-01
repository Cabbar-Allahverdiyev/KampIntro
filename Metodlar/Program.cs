using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id =0001;
            urun1.Markasi = "LAda";
            urun1.Model = "2107";
            urun1.UrunAciklamasi = "Gozel avtomobildir";
            urun1.Qiymeti = 3500;

            Urun urun2 = new Urun();
            urun2.Id =0002;
            urun2.Markasi = "Mercedes";
            urun2.Model = "C-Klas";
            urun2.UrunAciklamasi = "Rahat avtomobildir";
            urun2.Qiymeti = 11200;

            Urun urun3 = new Urun();
            urun3.Id =0003;
            urun3.Markasi = "BMW";
            urun3.Model = "520-d";
            urun3.UrunAciklamasi = "Suretli avtomobildir";
            urun3.Qiymeti = 15900;

            Urun[] uruns = new Urun[] { urun1 };
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun3);
            sepetManager.Ekle(urun2);

        }
    }
}
