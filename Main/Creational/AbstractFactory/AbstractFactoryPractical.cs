namespace Main.AbstractFactory
{
    public static class AbstractFactoryPractical
    {
        public static void Execute()
        {
            LaptopProducer lLaptopProducer = new LaptopProducer(new DellFactory());
            lLaptopProducer.ProduceLaptopParts();

            lLaptopProducer = new LaptopProducer(new AppleFactory());
            lLaptopProducer.ProduceLaptopParts();
        }
    }

    public abstract class Processor { }
    public abstract class Motherboard { }
    public abstract class Storage { }

    public class DellProcessor : Processor { }
    public class AppleProcessor : Processor { }
    public class DellMotherboard : Motherboard { }
    public class AppleMotherboard : Motherboard { }
    public class DellStorage : Storage { }
    public class AppleStorage : Storage { }

    abstract public class LaptopFactory
    {
        public abstract Processor CreateProcessor();
        public abstract Motherboard CreateMotherboard();
        public abstract Storage CreateStorage();
    }

    public class DellFactory : LaptopFactory
    {
        public override Processor CreateProcessor()
        {
            Console.WriteLine(this.GetType().Name + " - Processor created");
            return new DellProcessor();
        }
        public override Motherboard CreateMotherboard()
        {
            Console.WriteLine(this.GetType().Name + " - Motherboard created");
            return new DellMotherboard();
        }
        public override Storage CreateStorage()
        {
            Console.WriteLine(this.GetType().Name + " - Storage created");
            return new DellStorage();
        }
    }

    public class AppleFactory : LaptopFactory
    {
        public override Processor CreateProcessor()
        {
            Console.WriteLine(this.GetType().Name + " - Processor created");
            return new DellProcessor();
        }
        public override Motherboard CreateMotherboard()
        {
            Console.WriteLine(this.GetType().Name + " - Motherboard created");
            return new DellMotherboard();
        }
        public override Storage CreateStorage()
        {
            Console.WriteLine(this.GetType().Name + " - Storage created");
            return new DellStorage();
        }
    }

    public class LaptopProducer
    {
        private LaptopFactory _LaptopFactory;
        private Processor _Processor;
        private Motherboard _Motherboard;
        private Storage _Storage;

        public LaptopProducer(LaptopFactory prLaptopFactory)
        {
            _LaptopFactory = prLaptopFactory;
        }

        public void ProduceLaptopParts()
        {
            _Processor = _LaptopFactory.CreateProcessor();
            _Motherboard = _LaptopFactory.CreateMotherboard();
            _Storage = _LaptopFactory.CreateStorage();
        }
    }
}