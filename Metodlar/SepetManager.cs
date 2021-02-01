using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sebete elave edildi" + ":" + urun.Markasi + "-" + urun.Model);
        }
    }
}

