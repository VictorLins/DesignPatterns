namespace Main.Singleton
{
    public static class SingletonPractical
    {
        public static void Execute()
        {
            LogManager lLogManager1 = LogManager.GetInstance();
            LogManager lLogManager2 = LogManager.GetInstance();

            if (lLogManager1 == lLogManager2)
            {
                Console.WriteLine("Objects are the same instance");
                Console.WriteLine("LogManager1 HashCode: " + lLogManager1.GetHashCode());
                Console.WriteLine("LogManager2 HashCode: " + lLogManager2.GetHashCode());
            }
        }
    }

    public class LogManager
    {
        private static LogManager _Instance;

        protected LogManager()
        {
        }

        public static LogManager GetInstance()
        {
            if (_Instance == null)
                _Instance = new LogManager();

            return _Instance;
        }

        public void WriteLog(string prLogMessage)
        {
            Console.WriteLine(prLogMessage);
        }
    }
}