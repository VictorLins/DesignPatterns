namespace Main.Mediator
{
    public static class MediatorStructural
    {
        public static void Execute()
        {
            ConcreteMediator lConcreteMediator = new ConcreteMediator();

            ConcreteColleague1 lConcreteColleague1 = new ConcreteColleague1(lConcreteMediator);
            ConcreteColleague2 lConcreteColleague2 = new ConcreteColleague2(lConcreteMediator);

            lConcreteMediator.Colleague1 = lConcreteColleague1;
            lConcreteMediator.Colleague2 = lConcreteColleague2;

            lConcreteColleague1.Send("How are you?");
            lConcreteColleague2.Send("Fine, thanks");
        }
    }

    public abstract class Mediator
    {
        public abstract void Send(string message,
            Colleague colleague);
    }

    public class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 _ConcreteColleague1;
        private ConcreteColleague2 _ConcreteColleague2;

        public ConcreteColleague1 Colleague1
        {
            set { _ConcreteColleague1 = value; }
        }

        public ConcreteColleague2 Colleague2
        {
            set { _ConcreteColleague2 = value; }
        }

        public override void Send(string prMessage, Colleague prColleague)
        {
            if (prColleague == _ConcreteColleague1)
            {
                Console.WriteLine("Mediator is sending message to Colleague2");
                _ConcreteColleague2.Notify(prMessage);
            }
            else
            {
                Console.WriteLine("Mediator is sending message to Colleague1");
                _ConcreteColleague1.Notify(prMessage);
            }
        }
    }

    public abstract class Colleague
    {
        protected Mediator _Mediator;

        public Colleague(Mediator prMediator)
        {
            _Mediator = prMediator;
        }
    }

    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator prMediator)
            : base(prMediator) { }

        public void Send(string prMessage)
        {
            _Mediator.Send(prMessage, this);
        }

        public void Notify(string prMessage)
        {
            Console.WriteLine("Colleague1 gets message \"" + prMessage + "\"");
        }
    }

    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator prMediator)
            : base(prMediator) { }

        public void Send(string prMessage)
        {
            _Mediator.Send(prMessage, this);
        }

        public void Notify(string prMessage)
        {
            Console.WriteLine("Colleague2 gets message: " + prMessage);
        }
    }
}