using System;

namespace CompositAndTemplatePattern
{
    internal class SchoolLeaf : ISchoolComponent
    {
        public SchoolLeaf(string name, string title)
        {
            Name = name;
            Title = title;
        }

        public string Title { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Title}: {Name}");
        }

    }
}