namespace Main.Proxy
{
    public static class ProxyStructural
    {
        public static void Execute()
        {
            Proxy lProxy = new Proxy();
            lProxy.Request();
        }
    }

    internal abstract class Subject
    {
        public abstract void Request();
    }

    internal class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }

    internal class Proxy : Subject
    {
        private RealSubject _RealSubject;

        public override void Request()
        {
            if (_RealSubject == null)
                _RealSubject = new RealSubject();

            _RealSubject.Request();
        }
    }
}