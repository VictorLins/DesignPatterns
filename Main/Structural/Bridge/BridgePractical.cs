namespace Main.Bridge
{
    public static class BridgePractical
    {
        public static void Execute()
        {
            Shape lShape = new Square();

            // Set Implementor to Blue
            lShape._ColorImplementor = new BlueImplementor();
            lShape.Draw();

            // Set Implementor to Red
            lShape._ColorImplementor = new RedImplementor();
            lShape.Draw();
        }
    }

    public class Shape
    {
        public ColorImplementor _ColorImplementor { get; set; }

        public virtual void Draw()
        {
            _ColorImplementor.Draw();
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            _ColorImplementor.Draw();
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            _ColorImplementor.Draw();
        }
    }

    public abstract class ColorImplementor
    {
        public abstract void Draw();
    }

    public class BlueImplementor : ColorImplementor
    {
        public override void Draw()
        {
            Console.WriteLine("Blue Implementor - Drawing a blue component...");
        }
    }

    public class RedImplementor : ColorImplementor
    {
        public override void Draw()
        {
            Console.WriteLine("Red Implementor - Drawing a red component...");
        }
    }
}