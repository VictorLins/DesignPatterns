using System.Collections;

namespace Main.Flyweight
{
    public static class FlyweightStructural
    {
        public static void Execute()
        {
            int lContextVariable = 22;

            FlyweightFactory lFlyweightFactory = new FlyweightFactory();

            Flyweight lFlyweightX = lFlyweightFactory.GetFlyweight("X");
            Flyweight lFlyweightY = lFlyweightFactory.GetFlyweight("Y");
            Flyweight lFlyweightZ = lFlyweightFactory.GetFlyweight("Z");
            Flyweight lFlyweightXAgain = lFlyweightFactory.GetFlyweight("X");

            lFlyweightX.Operation(--lContextVariable);
            lFlyweightY.Operation(--lContextVariable);
            lFlyweightZ.Operation(--lContextVariable);
            lFlyweightZ.Operation(--lContextVariable);

            UnsharedConcreteFlyweight lUnsharedConcreteFlyweight = new UnsharedConcreteFlyweight();
            lUnsharedConcreteFlyweight.Operation(--lContextVariable);
        }
    }

    public class FlyweightFactory
    {
        private Hashtable _Flyweights = new Hashtable();

        public FlyweightFactory()
        {
            _Flyweights.Add("X", new ConcreteFlyweight());
            _Flyweights.Add("Y", new ConcreteFlyweight());
            _Flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string prKey)
        {
            return ((Flyweight)_Flyweights[prKey]);
        }
    }

    public abstract class Flyweight
    {
        public abstract void Operation(int prUniqueState);
    }

    public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int prUniqueState)
        {
            Console.WriteLine("ConcreteFlyweight - Context Property: " + prUniqueState);
        }
    }

    public class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int prUniqueState)
        {
            Console.WriteLine("UnsharedConcreteFlyweight - Context Property: " + prUniqueState);
        }
    }
}