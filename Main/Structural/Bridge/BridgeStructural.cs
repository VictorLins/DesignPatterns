namespace Main.Bridge
{
    public static class BridgeStructural
    {
        public static void Execute()
        {
            Abstraction lAbstraction = new RefinedAbstraction();

            // Set Implementor to A
            lAbstraction._Implementor = new ConcreteImplementorA();
            lAbstraction.Operation();

            // Set Implementor to B
            lAbstraction._Implementor = new ConcreteImplementorB();
            lAbstraction.Operation();
        }
    }

    public class Abstraction
    {
        public Implementor _Implementor { get; set; }

        public virtual void Operation()
        {
            _Implementor.Operation();
        }
    }

    public abstract class Implementor
    {
        public abstract void Operation();
    }

    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            _Implementor.Operation();
        }
    }

    public class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("Concrete Implementor A - Executing Operation...");
        }
    }

    public class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("Concrete Implementor B - Executing Operation...");
        }
    }
}