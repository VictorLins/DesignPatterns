namespace Main.State
{
    public static class StateStructural
    {
        public static void Execute()
        {
            Context lContext = new Context(new ConcreteStateA());
            lContext.Request(); // State A > State B
            lContext.Request(); // State B > State C
            lContext.Request(); // State C > State A
        }
    }
    public abstract class State
    {
        public abstract void Handle(Context prContext);
    }

    public class ConcreteStateA : State
    {
        public override void Handle(Context prContext)
        {
            Console.WriteLine("Concrete State A - Executing method \"Handle\" and changing state to \"B\"");
            prContext._State = new ConcreteStateB();
        }
    }

    public class ConcreteStateB : State
    {
        public override void Handle(Context prContext)
        {
            Console.WriteLine("Concrete State B - Executing method \"Handle\" and changing state to \"C\"");
            prContext._State = new ConcreteStateC();
        }
    }

    public class ConcreteStateC : State
    {
        public override void Handle(Context prContext)
        {
            Console.WriteLine("Concrete State C - Executing method \"Handle\" and changing state back to \"A\"");
            prContext._State = new ConcreteStateA();
        }
    }

    public class Context
    {
        public State _State;

        public Context(State prState)
        {
            _State = prState;
        }

        public void Request()
        {
            _State.Handle(this);
        }
    }
}