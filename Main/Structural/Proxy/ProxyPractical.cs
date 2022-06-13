namespace Main.Proxy
{
    public static class ProxyPractical
    {
        public static void Execute()
        {
            Calculator lCalculator = new ProxyCalculator();

            Console.WriteLine($"Proxy Calculator - Calling method \"Add\" in the Real Calculator... Result: 5 + 7 = {lCalculator.Add(5,7)}");
            Console.WriteLine($"Proxy Calculator - Calling method \"Add\" in the Real Calculator... Result: 5 - 7 = {lCalculator.Subtract(5, 7)}");
            Console.WriteLine($"Proxy Calculator - Calling method \"Add\" in the Real Calculator... Result: 5 * 7 = {lCalculator.Multiply(5, 7)}");
            Console.WriteLine($"Proxy Calculator - Calling method \"Add\" in the Real Calculator... Result: 5 / 7 = {lCalculator.Divide(5, 7)}");
        }
    }

    public abstract class Calculator
    {
        public abstract float Add(float prNumber1, float prNumber2);
        public abstract float Subtract(float prNumber1, float prNumber2);
        public abstract float Multiply(float prNumber1, float prNumber2);
        public abstract float Divide(float prNumber1, float prNumber2);
    }

    public class RealCalculator : Calculator
    {
        public override float Add(float prNumber1, float prNumber2)
        {
            return prNumber1 + prNumber2;
        }

        public override float Divide(float prNumber1, float prNumber2)
        {
            return prNumber1 / prNumber2;
        }

        public override float Multiply(float prNumber1, float prNumber2)
        {
            return prNumber1 * prNumber2;
        }

        public override float Subtract(float prNumber1, float prNumber2)
        {
            return prNumber1 - prNumber2;
        }
    }

    public class ProxyCalculator : Calculator
    {
        private RealCalculator _RealCalculator;

        public ProxyCalculator()
        {
            _RealCalculator = new RealCalculator();
        }

        public override float Add(float prNumber1, float prNumber2)
        {
            return _RealCalculator.Add(prNumber1, prNumber2);
        }

        public override float Divide(float prNumber1, float prNumber2)
        {
            return _RealCalculator.Divide(prNumber1, prNumber2);
        }

        public override float Multiply(float prNumber1, float prNumber2)
        {
            return _RealCalculator.Multiply(prNumber1, prNumber2);
        }

        public override float Subtract(float prNumber1, float prNumber2)
        {
            return _RealCalculator.Subtract(prNumber1, prNumber2);
        }
    }
}