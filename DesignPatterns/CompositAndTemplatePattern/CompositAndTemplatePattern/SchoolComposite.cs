using System;
using System.Collections.Generic;

namespace CompositAndTemplatePattern
{
    internal class SchoolComposite : ISchoolComponent
    {
        private readonly List<ISchoolComponent> _schoolComponents;

        public SchoolComposite(string name)
        {
            _schoolComponents = new List<ISchoolComponent>();
            Name = name;
        }

        public string Name { get; set; }


        public void Print()
        {
            Console.WriteLine("-------");
            Console.WriteLine(Name);
            foreach (var schoolComponent in _schoolComponents)
                schoolComponent.Print();
        }

        public void AddChild(ISchoolComponent schoolComponent)
        {
            _schoolComponents.Add(schoolComponent);
        }

        public bool RemoveChild(ISchoolComponent schoolComponent)
        {
            return _schoolComponents.Remove(schoolComponent);
        }

        public ISchoolComponent GetChild(int i)
        {
            return _schoolComponents[i];
        }

        public int CountChild()
        {
            return _schoolComponents.Count;
        }
    }
}