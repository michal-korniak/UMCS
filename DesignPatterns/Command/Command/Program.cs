//https://drive.google.com/drive/folders/0B0YLRHdBJ9VUQnRPa1dRYV8yMEk



namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            InnySystem system = new InnySystem();
            system.DodajKomende(new KomendaDodaj(system.InnaEkspozycja, new Eksponat("Van Gogh")));
            system.DodajKomende(new KomendaUmiesc(system.InnaEkspozycja, new Eksponat("Van Gogh")));
            system.DodajKomende(new KomendaDodaj(system.InnaEkspozycja, new Eksponat("Picasso")));
            system.DodajKomende(new KomendaDodaj(system.InnaEkspozycja, new Eksponat("Michal Aniol")));
            system.DodajKomende(new KomendaDodaj(system.InnaEkspozycja, new Eksponat("fresk")));
            system.DodajKomende(new KomendaUmiesc(system.InnaEkspozycja, new Eksponat("fresk")));
            system.DodajKomende(new KomendaDodaj(system.InnaEkspozycja, new Eksponat("Malczewski")));
            system.DodajKomende(new KomendaUmiesc(system.InnaEkspozycja, new Eksponat("Malczewski")));
            system.DodajKomende(new KomendaUmiesc(system.InnaEkspozycja, new Eksponat("Picasso")));
            system.DodajKomende(new KomendaUmiesc(system.InnaEkspozycja, new Eksponat("Michal Aniol")));
            system.DodajKomende(new KomendaUsun(system.InnaEkspozycja, new Eksponat("Van Gogh")));
            system.DodajKomende(new KomendaDodaj(system.InnaEkspozycja, new Eksponat("Dali")));
            system.DodajKomende(new KomendaUsun(system.InnaEkspozycja, new Eksponat("Fresk")));
            system.DodajKomende(new KomendaUmiesc(system.InnaEkspozycja, new Eksponat("Dali")));
        }
    }
}
