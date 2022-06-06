namespace Main.AbstractFactory
{
    public static class AbstractFactoryStructural
    {
        public static void Execute()
        {
            AbstractFactory lAbstractFactory = new ConcreteFactory1();
            Client lClient = new Client(lAbstractFactory);
            lClient.Execute();

            lAbstractFactory = new ConcreteFactory2();
            lClient = new Client(lAbstractFactory);
            lClient.Execute();
        }
    }

    public abstract class AbstractProductA
    {
    }

    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA prAbstractProductA);
    }

    public class ProductA1 : AbstractProductA
    {
    }

    public class ProductA2 : AbstractProductA
    {
    }

    public class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA prAbstractProductA)
        {
            Console.WriteLine(this.GetType().Name + " is interacting with " + prAbstractProductA.GetType().Name);
        }
    }

    public class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA prAbstractProductA)
        {
            Console.WriteLine(this.GetType().Name + " is interacting with " + prAbstractProductA.GetType().Name);
        }
    }

    abstract public class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    public class ConcreteFactory1 : AbstractFactory
    {
        public override ProductA1 CreateProductA()
        {
            return new ProductA1();
        }
        public override ProductB1 CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactory2 : AbstractFactory
    {
        public override ProductA2 CreateProductA()
        {
            return new ProductA2();
        }
        public override ProductB2 CreateProductB()
        {
            return new ProductB2();
        }
    }

    public class Client
    {
        private AbstractFactory _AbstractFactory;
        private AbstractProductA _AbstractProductA;
        private AbstractProductB _AbstractProductB;

        public Client(AbstractFactory prAbstractFactory)
        {
            _AbstractFactory = prAbstractFactory;
        }

        public void Execute()
        {
            _AbstractProductA = _AbstractFactory.CreateProductA();
            Console.WriteLine(_AbstractFactory.GetType().Name + " created Product " + _AbstractProductA.GetType().Name);
            _AbstractProductB = _AbstractFactory.CreateProductB();
            Console.WriteLine(_AbstractFactory.GetType().Name + " created Product " + _AbstractProductB.GetType().Name);
            _AbstractProductB.Interact(_AbstractProductA);
        }
    }
}