using System;

namespace Memento
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Caretaker caretaker=new Caretaker();
            Originator originator=new Originator();
            originator.Text = "xXXD";
            caretaker.AddMemento(originator.CreateMemento());
            originator.Text = "aaa";
            Console.WriteLine(originator.Text);
            originator.RestoreMemento(caretaker.GetMemento(0));
            Console.WriteLine(originator.Text);
        }
    }
}