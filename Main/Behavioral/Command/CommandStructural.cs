namespace Main.Command
{
    public static class CommandStructural
    {
        public static void Execute()
        {
            Receiver lReceiver = new Receiver();
            Command lCommand = new ConcreteCommand(lReceiver);
            Invoker lInvoker = new Invoker();

            lInvoker.SetCommand(lCommand);
            lInvoker.ExecuteCommand();
        }
    }

    public abstract class Command
    {
        protected Receiver _Receiver;

        public Command(Receiver prReceiver)
        {
            _Receiver = prReceiver;
        }

        public abstract void Execute();
    }

    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver prReceiver) :
            base(prReceiver)
        {
        }

        public override void Execute()
        {
            _Receiver.Action();
        }
    }

    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }
    }

    public class Invoker
    {
        private Command _Command;

        public void SetCommand(Command prCommand)
        {
            _Command = prCommand;
        }

        public void ExecuteCommand()
        {
            _Command.Execute();
        }
    }
}