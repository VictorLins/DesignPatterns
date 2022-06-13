using System.Collections;

namespace Main.Flyweight
{
    public static class FlyweightPractical
    {
        public static void Execute()
        {
            ShapeFactory lShapeFactory = new ShapeFactory();

            Circle lCircle1 = (Circle)lShapeFactory.GetShape("Circle", "Red");
            lCircle1.Draw(40, 65);
            Circle lCircle2 = (Circle)lShapeFactory.GetShape("Circle", "Blue");
            lCircle2.Draw(78,32);
            Circle lCircle3 = (Circle)lShapeFactory.GetShape("Circle", "Blue");
            lCircle3.Draw(15,67);

            Square lSquare1 = (Square)lShapeFactory.GetShape("Square", "Red");
            lSquare1.Draw(99,44);
            Square lSquare2 = (Square)lShapeFactory.GetShape("Square", "Red");
            lSquare2.Draw(88,42);

            Triangle lTriangle1 = (Triangle)lShapeFactory.GetShape("Triangle", "Yellow");
            lTriangle1.Draw(89,34);
            Triangle lTriangle2 = (Triangle)lShapeFactory.GetShape("Triangle", "White");
            lTriangle2.Draw(64,24);
        }
    }

    public class ShapeFactory
    {
        private Hashtable _Shapes = new Hashtable();

        public Shape GetShape(string prShape, string prColor)
        {
            string lUniqueKey = prShape + prColor;
            Shape lResult = ((Shape)_Shapes[lUniqueKey]);

            if (lResult == null)
            {
                switch (prShape)
                {
                    case ("Circle"): _Shapes.Add(lUniqueKey, new Circle()); Console.WriteLine($"Creating Shape \"{prColor} {prShape}\""); break;
                    case ("Square"): _Shapes.Add(lUniqueKey, new Square()); Console.WriteLine($"Creating Shape \"{prColor} {prShape}\""); break;
                    case ("Triangle"): _Shapes.Add(lUniqueKey, new Triangle()); Console.WriteLine($"Creating Shape \"{prColor} {prShape}\""); break;
                    default: break;
                }

                return ((Shape)_Shapes[lUniqueKey]);
            }
            else
            {
                Console.WriteLine($"Shape \"{prColor} {prShape}\" already created, retrieving from cache");
                return lResult;
            }
        }
    }

    public abstract class Shape
    {
        public string _Color { get; set; }
        public abstract void Draw(int prX, int prY);
    }

    public class Circle : Shape
    {
        public override void Draw(int prX, int prY)
        {
            Console.WriteLine($"---Drawing {this._Color} Circle in position: X = {prX}, Y = {prY}");
        }
    }

    public class Square : Shape
    {
        public override void Draw(int prX, int prY)
        {
            Console.WriteLine($"---Drawing {this._Color} Square in position: X = {prX}, Y = {prY}");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw(int prX, int prY)
        {
            Console.WriteLine($"---Drawing {this._Color} Triangle in position: X = {prX}, Y = {prY}");
        }
    }
}