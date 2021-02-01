using System;
using System.Collections.Generic;
using System.Text;

namespace Numuneler
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sebete elave edildi"+":"+urun.Markasi+"-"+urun.Model);
        }
    }
}
