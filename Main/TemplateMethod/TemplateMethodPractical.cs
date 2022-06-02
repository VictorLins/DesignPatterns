namespace Main.TemplateMethod
{
    public static class TemplateMethodPractical
    {
        public static void Execute()
        {
            Person lJohn = new John();
            lJohn.DisplayDailyActivityTime();

            Person lSimon = new Simon();
            lSimon.DisplayDailyActivityTime();
        }
    }

    public abstract class Person
    {
        public void DisplayDailyActivityTime()
        {
            WakeUp();

            EatBreakFast();

            if (HasJob())
                GoToWork();

            HaveLunch();

            HaveDinner();

            GoToSleep();
        }

        protected abstract void WakeUp();
        protected abstract void EatBreakFast();
        protected abstract bool HasJob();
        protected virtual void GoToWork() { } // This action will not be mandatory as it depends if the person has job
        protected abstract void HaveLunch();
        protected abstract void HaveDinner();
        protected abstract void GoToSleep();
    }

    public class John : Person
    {
        protected override void EatBreakFast()
        {
            Console.WriteLine("John - EatBreakFast - 06:30:00");
        }

        protected override void GoToSleep()
        {
            Console.WriteLine("John - GoToSleep - 22:00:00");
        }

        protected override void GoToWork()
        {
            Console.WriteLine("John - GoToWork - 07:00:00");
        }

        protected override bool HasJob()
        {
            return true;
        }

        protected override void HaveDinner()
        {
            Console.WriteLine("John - HaveDinner - 20:00:00");
        }

        protected override void HaveLunch()
        {
            Console.WriteLine("John - HaveLunch - 12:00:00");
        }

        protected override void WakeUp()
        {
            Console.WriteLine("John - WakeUp - 06:00:00");
        }
    }

    public class Simon : Person
    {
        protected override void EatBreakFast()
        {
            Console.WriteLine("Simon - EatBreakFast - 09:00:00");
        }

        protected override void GoToSleep()
        {
            Console.WriteLine("Simon - GoToSleep - 23:00:00");
        }

        protected override bool HasJob()
        {
            return false;
        }

        protected override void HaveDinner()
        {
            Console.WriteLine("Simon - HaveDinner - 21:00:00");
        }

        protected override void HaveLunch()
        {
            Console.WriteLine("Simon - HaveLunch - 13:00:00");
        }

        protected override void WakeUp()
        {
            Console.WriteLine("Simon - WakeUp - 08:00:00");
        }
    }
}