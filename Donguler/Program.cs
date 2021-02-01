using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "kodlama orgedici kurs";
            string kurs2 = "proqramlamaya baslamaq ucun kurs";
            string kurs3 = "java";
            // array- siralamalar
            string[] kurslar = new string[] { "kodlama orgedici kurs",
                "proqramlamaya baslamaq ucun kurs" ,"java","c++","c#"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            for (int i = 1; i < 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sehifenin sonu-footter");


           
           
            
        }

    }
}
