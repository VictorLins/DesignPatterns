namespace Main.Decorator
{
    public static class DecoratorPractical
    {
        public static void Execute()
        {
            Margherita lMargherita = new Margherita();
            BarbequeDecorator lBarbequeDecorator = new BarbequeDecorator(lMargherita);
            JalapenoDecorator lJalapenoDecorator = new JalapenoDecorator(lBarbequeDecorator);
            Console.WriteLine(lJalapenoDecorator.GetDescription() + " | Cost: " + lJalapenoDecorator.GetCost());

            Pepperoni lPepperoni = new Pepperoni();
            BarbequeDecorator lBarbequeDecoratorPepperoni = new BarbequeDecorator(lPepperoni);
            JalapenoDecorator lJalapenoDecoratorPepperoni = new JalapenoDecorator(lBarbequeDecoratorPepperoni);
            OnionDecorator lOnionDecorator = new OnionDecorator(lJalapenoDecoratorPepperoni);
            Console.WriteLine(lOnionDecorator.GetDescription() + " | Cost: " + lOnionDecorator.GetCost());
        }
    }

    public abstract class PizzaItem
    {
        public string Name = "Unknown Pizza";
        public string Description = "";

        public abstract string GetDescription();
        public abstract int GetCost();
    }

    public class Margherita : PizzaItem
    {
        public override string GetDescription() { return "Marguerita"; }
        public override int GetCost() { return 20; }
    }

    public class Pepperoni : PizzaItem
    {
        public override string GetDescription() { return "Pepperoni"; }
        public override int GetCost() { return 30; }
    }

    public abstract class ToppingDecorator : PizzaItem
    {
        public PizzaItem _PizzaItem;

        public ToppingDecorator(PizzaItem prPizzaItem)
        {
            _PizzaItem = prPizzaItem;
        }
    }

    public class BarbequeDecorator : ToppingDecorator
    {
        public BarbequeDecorator(PizzaItem prPizzaItem) : base(prPizzaItem) { }

        public override string GetDescription() { return _PizzaItem.GetDescription() + ", Barbeque"; }
        public override int GetCost() { return _PizzaItem.GetCost() + 5; }
    }

    public class JalapenoDecorator : ToppingDecorator
    {
        public JalapenoDecorator(PizzaItem prPizzaItem) : base(prPizzaItem) { }

        public override string GetDescription() { return _PizzaItem.GetDescription() + ", Jalapeno"; }
        public override int GetCost() { return _PizzaItem.GetCost() + 5; }
    }

    public class OnionDecorator : ToppingDecorator
    {
        public OnionDecorator(PizzaItem prPizzaItem) : base(prPizzaItem) { }

        public override string GetDescription() { return _PizzaItem.GetDescription() + ", Onion"; }
        public override int GetCost() { return _PizzaItem.GetCost() + 5; }
    }
}