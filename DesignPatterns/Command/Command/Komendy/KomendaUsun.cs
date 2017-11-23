using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class KomendaUsun: KomendaInwentaryzacji
    {
        private Ekspozycja _ekspozycja;
        private Eksponat _eksponat;

        public KomendaUsun(Ekspozycja ekspozycja, Eksponat eksponat)
        {
            _ekspozycja = ekspozycja;
            _eksponat = eksponat;
        }

        public override void Wykonaj()
        {
            _ekspozycja.Usun(_eksponat);
        }
    }
}
