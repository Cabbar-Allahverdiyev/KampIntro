using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{ 
    
    
        
        class Praduct
        {
            public string praductName { get; set; }
            public int praductId { get; set; }
            public double praductQiymet { get; set; }
            public double praductEndirim { get; set; }
        }

        class Urun
        {
            public int Id { get; set; }
            public string Markasi { get; set; }
            public string Model { get; set; }
            public int Qiymeti { get; set; }
            public string UrunAciklamasi { get; set; }
        }
   
}
