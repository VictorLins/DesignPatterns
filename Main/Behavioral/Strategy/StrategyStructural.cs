namespace Main.Strategy
{
    public static class StrategyStructural
    {
        public static void Execute()
        {
            Context lContext = new Context(new ConcreteStrategyA());
            lContext.ContextOperation();

            lContext = new Context(new ConcreteStrategyB());
            lContext.ContextOperation();
        }

        public abstract class Strategy
        {
            public abstract void StrategyOperation();
        }

        public class ConcreteStrategyA : Strategy
        {
            public override void StrategyOperation()
            {
                Console.WriteLine("Executing Operation Using Strategy A");
            }
        }

        public class ConcreteStrategyB : Strategy
        {
            public override void StrategyOperation()
            {
                Console.WriteLine("Executing Operation Using Strategy B");
            }
        }

        public class Context
        {
            private Strategy _Strategy;

            public Context(Strategy prStrategy)
            {
                this._Strategy = prStrategy;
            }

            public void ContextOperation()
            {
                _Strategy.StrategyOperation();
            }
        }
    }
}