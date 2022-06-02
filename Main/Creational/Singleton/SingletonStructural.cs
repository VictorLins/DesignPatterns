namespace Main.Singleton
{
    public static class SingletonStructural
    {
        public static void Execute()
        {
            Singleton lSingleton1 = Singleton.GetInstance();
            Singleton lSingleton2 = Singleton.GetInstance();

            if(lSingleton1 == lSingleton2)
            {
                Console.WriteLine("Objects are the same instance");
                Console.WriteLine("Singleton1 HashCode: " + lSingleton1.GetHashCode());
                Console.WriteLine("Singleton2 HashCode: " + lSingleton2.GetHashCode());
            }
        }
    }

    public class Singleton
    {
        private static Singleton _Instance;

        protected Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (_Instance == null)
                _Instance = new Singleton();

            return _Instance;
        }
    }
}