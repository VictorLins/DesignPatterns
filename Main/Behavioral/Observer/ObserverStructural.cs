namespace Main.Observer
{
    public static class ObserverStructural
    {
        public static void Execute()
        {
            ConcreteSubject lConcreteSubject = new ConcreteSubject();
            lConcreteSubject.Attach(new ConcreteObserver1(lConcreteSubject));
            lConcreteSubject.Attach(new ConcreteObserver2(lConcreteSubject));

            lConcreteSubject.SubjectState = "State2";
            lConcreteSubject.SubjectState = "State3";
        }
    }

    public abstract class Subject
    {
        private List<Observer> _Observers = new List<Observer>();

        public void Attach(Observer prObserver)
        {
            _Observers.Add(prObserver);
        }

        public void Detach(Observer prObserver)
        {
            _Observers.Remove(prObserver);
        }

        protected void NotifyObservers()
        {
            foreach (Observer lObserverCurrent in _Observers)
            {
                lObserverCurrent.Update();
            }
        }
    }

    public abstract class Observer
    {
        public ConcreteSubject _ConcreteSubject;

        public string _Name { get; set; }
        public string _ObserverState { get; set; }

        public Observer(ConcreteSubject prConcreteSubject)
        {
            _ConcreteSubject = prConcreteSubject;
        }

        public abstract void Update();
    }

    public class ConcreteObserver1 : Observer
    {
        public ConcreteObserver1(ConcreteSubject prConcreteSubject) : base(prConcreteSubject) { }

        public override void Update()
        {
            Console.WriteLine("Concrete Observer 1 Triggered");
        }
    }

    public class ConcreteObserver2 : Observer
    {
        public ConcreteObserver2(ConcreteSubject prConcreteSubject) : base(prConcreteSubject) { }

        public override void Update()
        {
            Console.WriteLine("Concrete Observer 2 Triggered");
        }
    }

    public class ConcreteSubject : Subject
    {
        private string _SubjectState = "State1";
        public string SubjectState
        {
            get { return _SubjectState; }
            set
            {
                Console.WriteLine($"Changing Subject's State from {_SubjectState} to {value}");
                _SubjectState = value;
                NotifyObservers();
            }
        }
    }
}