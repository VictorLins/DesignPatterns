namespace Main.Memento
{
    public static class MementoStructural
    {
        public static void Execute()
        {
            Originator lOriginator = new Originator();
            lOriginator.State = "On";

            // Store internal state
            Caretaker lCaretaker = new Caretaker();
            lCaretaker._Memento = lOriginator.CreateMemento();

            // Continue changing originator
            lOriginator.State = "Off";

            // Restore saved state
            lOriginator.SetMemento(lCaretaker._Memento);
        }
    }

    public class Originator
    {
        private string _State;

        public string State
        {
            get { return _State; }
            set
            {
                Console.WriteLine($"Originator - Changing state from \"{_State}\" to \"{value}\"");
                _State = value;
            }
        }

        public Memento CreateMemento()
        {
            Console.WriteLine($"Originator - Creating memento of the current state \"{_State}\"");
            return (new Memento(_State));
        }

        public void SetMemento(Memento prMemento)
        {
            Console.WriteLine($"Originator - Restoring state...");
            State = prMemento._State;
        }
    }

    public class Memento
    {
        public string _State { get; set; }

        public Memento(string prState)
        {
            _State = prState;
        }
    }

    public class Caretaker
    {
        public Memento _Memento { get; set; }
    }
}