using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class KomendaDodaj: KomendaInwentaryzacji
    {
        private Ekspozycja _ekspozycja;
        private Eksponat _eksponat;

        public KomendaDodaj(Ekspozycja ekspozycja, Eksponat eksponat)
        {
            _ekspozycja = ekspozycja;
            _eksponat = eksponat;
        }

        public override void Wykonaj()
        {
            _ekspozycja.Dodaj(_eksponat);
        }
    }
}
