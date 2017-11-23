namespace Memento
{
    public class Originator
    {
        public string Text { get; set; }

        public Memento CreateMemento()
        {
            return new Memento(Text);
        }

        public void RestoreMemento(Memento memento)
        {
            Text = memento.State;
        }
    }
}