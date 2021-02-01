using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : "+ urun.Adi);


        }
        public void EkleAlternatif(string urunAdi,string serh,double qiymet,int stokSayi)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }

    }
}
