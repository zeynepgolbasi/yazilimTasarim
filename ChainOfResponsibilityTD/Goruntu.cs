using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityTD
{
    public class Goruntu
    {

        private AGoruntuKaynagi _goruntuKaynagi;

        List<AGoruntuKaynagi> goruntuler = new List<AGoruntuKaynagi>();

        public Goruntu(AGoruntuKaynagi goruntuKaynagi)
        {
            _goruntuKaynagi = goruntuKaynagi;
        }

        public void Ekle()
        {
            goruntuler.Add(_goruntuKaynagi);
        }

        public void Goster()
        {
            _goruntuKaynagi.goster();
        }


    }
}
