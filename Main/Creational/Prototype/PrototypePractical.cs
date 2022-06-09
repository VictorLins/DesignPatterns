using System.Linq;
namespace Main.Prototype
{
    public static class PrototypePractical
    {
        public static void Execute()
        {
            ShapeHelper lShapeHelper = new ShapeHelper();
            lShapeHelper.CreateShapes("Square", 2);
            lShapeHelper.CreateShapes("Circle", 3);
            lShapeHelper.CreateShapes("Triangle", 4);

            Console.WriteLine($"\n\rCreated {lShapeHelper._Shapes.Count} objects in total");
        }
    }

    public class ShapeHelper
    {
        public List<Shape> _Shapes = new List<Shape>();

        public void CreateShapes(string prType, int prQuantity)
        {
            Shape lOriginalShape = null;
            switch (prType)
            {
                case ("Circle"): lOriginalShape = new Circle("#1"); break;
                case ("Square"): lOriginalShape = new Square("#1"); break;
                case ("Triangle"): lOriginalShape = new Triangle("#1"); break;
                default: break;
            }

            if (lOriginalShape != null)
            {
                Console.WriteLine($"• Creating {prQuantity} {lOriginalShape.GetType().Name}s...");
                Console.WriteLine($"    Created object {lOriginalShape.GetType().Name} - Id: {lOriginalShape._Id}");

                _Shapes.Add(lOriginalShape);
                for (int i = 1; i < prQuantity; i++)
                {
                    _Shapes.Add(lOriginalShape.Clone());
                    Console.WriteLine($"      Clonned object {lOriginalShape.GetType().Name} - Id: {lOriginalShape._Id}");
                }
            }
        }
    }

    public abstract class Shape
    {
        public string _Id { get; set; }
        public string _Type { get; set; }

        public Shape(string prId, string prType)
        {
            _Id = prId;
            _Type = prType;
        }

        public virtual Shape Clone()
        {
            // To "Clone" an object can be done either by using Shallow Copy or Deep Copy approach
            // In the below example Shallow Copy approach is used
            return (Shape)this.MemberwiseClone();
        }
    }

    public class Circle : Shape
    {
        public Circle(string prId)
            : base(prId, "Circle") { }

    }

    public class Square : Shape
    {
        public Square(string prId)
            : base(prId, "Square") { }

    }

    public class Triangle : Shape
    {
        public Triangle(string prId)
            : base(prId, "Triangle") { }

    }
}