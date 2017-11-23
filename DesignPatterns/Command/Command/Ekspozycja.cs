using System;

namespace Command
{
    class Ekspozycja
    {
        public void Dodaj(Eksponat eksponat)
        {
            Console.WriteLine($"dodaj {eksponat.Nazwa}");
        }
        public void Usun(Eksponat eksponat)
        {
            Console.WriteLine($"usun {eksponat.Nazwa} z ekspozycji");
        }
        public void Umiesc(Eksponat eksponat)
        {
            Console.WriteLine($"umiesc {eksponat.Nazwa} do ekspozycji");
        }

    }

}