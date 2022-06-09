namespace Main.Prototype
{
    public static class PrototypeStructural
    {
        public static void Execute()
        {
            ConcretePrototype1 lConcretePrototype1 = new ConcretePrototype1("1");
            ConcretePrototype1 lCloneConcretePrototype = (ConcretePrototype1)lConcretePrototype1.Clone();
            Console.WriteLine($"Cloned {lConcretePrototype1.GetType().Name}");

            ConcretePrototype2 lConcretePrototype2 = new ConcretePrototype2("2");
            ConcretePrototype2 lCloneConcretePrototype2 = (ConcretePrototype2)lConcretePrototype2.Clone();
            Console.WriteLine($"Cloned {lCloneConcretePrototype2.GetType().Name}");
        }
    }

    public abstract class Prototype
    {
        public string _Id { get; set; }

        public Prototype(string prId)
        {
            _Id = prId;
        }

        public abstract Prototype Clone();
    }

    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string prId)
            : base(prId) { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string prId)
            : base(prId) { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}