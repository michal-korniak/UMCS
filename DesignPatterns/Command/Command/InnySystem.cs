using System.Collections.Generic;
using System.Linq;

namespace Command
{
    class InnySystem
    {
        public Ekspozycja InnaEkspozycja { get; set; }
        private List<KomendaInwentaryzacji> _komendy;
        public InnySystem()
        {
            _komendy = new List<KomendaInwentaryzacji>();
            InnaEkspozycja = new Ekspozycja();
        }
        private void Zatwierdz(List<KomendaInwentaryzacji> komendy)
        {
            foreach (var komenda in komendy)
            {
                komenda.Wykonaj();
                
            }
            komendy.Clear();
        }
        public void DodajKomende(KomendaInwentaryzacji komenda)
        {
            _komendy.Add(komenda);
            if (_komendy.Count() == 5)
                Zatwierdz(_komendy);
        }
    }
}
