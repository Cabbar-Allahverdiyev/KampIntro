using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Cabbar";
            int yas = 21;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Eyitmen = "Cuma muellim";
            kurs1.IzlenmePayi = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eyitmen = "Pervin muellime";
            kurs2.IzlenmePayi = 64;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python ";
            kurs3.Eyitmen = "Arzu muellime";
            kurs3.IzlenmePayi = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = " c++";
            kurs4.Eyitmen = " Aide muellime";
            kurs4.IzlenmePayi = 100;

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3,kurs4};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Eyitmen);
                Console.WriteLine("********");
            }

            //Console.WriteLine(kurs1.KursAdi+":"+kurs1.Eyitmen);


        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eyitmen { get; set; }
        public int IzlenmePayi { get; set; }
    }
}
