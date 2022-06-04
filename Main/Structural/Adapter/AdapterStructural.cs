namespace Main.Adapter
{
    public static class AdapterStructural
    {
        public static void Execute()
        {
            Target lTarget = new Adapter();
            lTarget.Request();
        }
    }

    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Target - Executing Default Request");
        }
    }

    public class Adapter : Target
    {
        private Adaptee _Adaptee = new Adaptee();

        public override void Request()
        {
            // Possibly execute some other code
            _Adaptee.SpecificRequest();
        }
    }

    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee - Executing Specific Requirement");
        }
    }
}