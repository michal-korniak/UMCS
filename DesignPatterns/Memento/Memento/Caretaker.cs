using System.Collections.Generic;

namespace Memento
{
    public class Caretaker
    {
        private readonly List<Memento> _mementoes;

        public Caretaker()
        {
            _mementoes = new List<Memento>();
        }


        public void AddMemento(Memento memento)
        {
            _mementoes.Add(memento);
        }

        public Memento GetMemento(int index)
        {
            return _mementoes[index];
        }

        public int Count()
        {
            return _mementoes.Count;
        }
    }
}