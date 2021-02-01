using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Alma";
            double qiymeti = 15;
            string serh = "Quba almasi";

            Urun urun1 = new Urun();
            urun1.Adi = "alma";
            urun1.Qiymeti = 15;
            urun1.serh = "Quba almasi";
            urun1.StokAdedi = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "Qarpiz";
            urun2.Qiymeti = 80;
            urun2.serh = "Xanabad qarpizi";
            Urun[] urunler = new Urun[] { urun1, urun2};
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Qiymeti);
                Console.WriteLine(urun.serh);       
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("-----------Metodlar----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.EkleAlternatif("armut","sari armut",12,3);
            sepetManager.EkleAlternatif("alma","yasil alma",15,4);
            sepetManager.EkleAlternatif("kartof","gedebey kartofu",18,5);
        
           

        }
    }

}
