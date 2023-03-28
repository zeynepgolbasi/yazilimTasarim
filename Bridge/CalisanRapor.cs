using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class CalisanRapor : IRapor
    {
        public void Display(IPlatform platform)
        {
           
            Console.Write("Calisan raporu "); platform.goruntule();
        }
    }
}
