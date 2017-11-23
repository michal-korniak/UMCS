namespace CompositAndTemplatePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ISchoolComponent school=new SchoolComposite("Szkola");
            ISchoolComponent directorCabinet=new SchoolComposite("Gabinet Dyrektora");
            ISchoolComponent office=new SchoolComposite("Sekretariat");
            ISchoolComponent accounts=new SchoolComposite("Księgowość");
            ISchoolComponent library=new SchoolComposite("Biblioteka");
            ISchoolComponent gym=new SchoolComposite("Sala gimnastyczna");
            ISchoolComponent teachersRoom=new SchoolComposite("Pokoj nauczycielski");
            ISchoolComponent class1=new SchoolComposite("Klasa");

            SchoolComposite schoolComp = (SchoolComposite)school;
            schoolComp.AddChild(directorCabinet);
            ((SchoolComposite) directorCabinet).AddChild(new SchoolLeaf("Adam Nowak","Dyrektor"));
            schoolComp.AddChild(office);
            ((SchoolComposite)office).AddChild(new SchoolLeaf("Jadwiga Nowak", "Sekretarka"));
            schoolComp.AddChild(accounts);
            ((SchoolComposite)accounts).AddChild(new SchoolLeaf("Wieslawa Kaczor", "Ksiegowa"));
            schoolComp.AddChild(library);
            ((SchoolComposite)library).AddChild(new SchoolLeaf("Jan Nowak", "Bibliotekarz"));
            ((SchoolComposite)library).AddChild(new SchoolLeaf("Grazyna Opala", "Bibliotekarka"));
            schoolComp.AddChild(gym);
            schoolComp.AddChild(teachersRoom);
            ((SchoolComposite)teachersRoom).AddChild(new SchoolLeaf("Katarzyna Krotkiewicz", "Nauczyciel"));
            ((SchoolComposite)teachersRoom).AddChild(new SchoolLeaf("Jarek Grzeszczuk", "Nauczyciel"));
            ((SchoolComposite)teachersRoom).AddChild(new SchoolLeaf("Elzbieta Krygiel", "Nauczyciel"));
            schoolComp.AddChild(class1);
            ((SchoolComposite)class1).AddChild(new SchoolLeaf("Geralt Riv", "Uczen"));
            ((SchoolComposite)class1).AddChild(new SchoolLeaf("Ezio Auditore", "Uczen"));
            ((SchoolComposite)class1).AddChild(new SchoolLeaf("Charlemagne", "Uczen"));

            schoolComp.Print();

            SchoolSerialization jsonSerialization=new JsonSerialization();
            jsonSerialization.SerializeObject(school,"serial");











        }
    }
}