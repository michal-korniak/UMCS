using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class KomendaUmiesc: KomendaInwentaryzacji
    {
        private Ekspozycja _ekspozycja;
        private Eksponat _eksponat;

        public KomendaUmiesc(Ekspozycja ekspozycja, Eksponat eksponat)
        {
            _ekspozycja = ekspozycja;
            _eksponat = eksponat;
        }

        public override void Wykonaj()
        {
            _ekspozycja.Umiesc(_eksponat);
        }
    }
}
