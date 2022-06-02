namespace Main.Facade
{
    public static class FacadeStructural
    {
        public static void Execute()
        {
            Facade lFacade = new Facade();
            lFacade.MethodA();
            lFacade.MethodB();
        }
    }

    public class Facade
    {
        private SubSystemOne _SubSystemOne;
        private SubSystemTwo _SubSystemTwo;
        private SubSystemThree _SubSystemThree;
        private SubSystemFour _SubSystemFour;

        public Facade()
        {
            _SubSystemOne = new SubSystemOne();
            _SubSystemTwo = new SubSystemTwo();
            _SubSystemThree = new SubSystemThree();
            _SubSystemFour = new SubSystemFour();
        }
        public void MethodA()
        {
            Console.WriteLine("Facade - Executing Method A");
            _SubSystemOne.MethodOne();
            _SubSystemFour.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("Facade - Executing Method B");
            _SubSystemTwo.MethodTwo();
            _SubSystemThree.MethodThree();
        }
    }

    public class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("SubSystemOne - Executing Method One");
        }
    }

    public class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("SubSystemTwo - Executing Method Two");
        }
    }

    public class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("SubSystemThree - Executing Method Three");
        }
    }

    public class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("SubSystemFour - Executing Method Four");
        }
    }
}