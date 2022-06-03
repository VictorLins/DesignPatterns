namespace Main.Decorator
{
    public static class DecoratorStructural
    {
        public static void Execute()
        {
            ConcreteComponent lConcreteComponent = new ConcreteComponent();
            ConcreteDecoratorA lConcreteDecoratorA = new ConcreteDecoratorA();
            ConcreteDecoratorB lConcreteDecoratorB = new ConcreteDecoratorB();

            lConcreteDecoratorA.SetComponent(lConcreteComponent);
            lConcreteDecoratorB.SetComponent(lConcreteDecoratorA);

            lConcreteDecoratorB.Operation();
        }
    }

    public abstract class Component
    {
        public abstract void Operation();
    }

    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent - Executing Operation");
        }
    }

    public abstract class Decorator : Component
    {
        protected Component _Component;

        public void SetComponent(Component prComponent)
        {
            _Component = prComponent;
        }

        public override void Operation()
        {
            if (_Component != null)
                _Component.Operation();
        }
    }

    public class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA - Executing Operation");
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorB - Executing Operation");
        }
    }
}