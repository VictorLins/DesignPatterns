namespace Main.Builder
{
    public static class BuilderStructural
    {
        public static void Execute()
        {
            Director lDirector = new Director();

            // Using Builder 1
            Builder lConcreteBuilder1 = new ConcreteBuilder1(); // Define Builder
            lDirector.Construct(lConcreteBuilder1);             // Build Product
            Product lProduct1 = lConcreteBuilder1.GetResult();  // Get Product
            Console.WriteLine("Builder 1 - Product Result: ");
            lProduct1.Show();

            // Using Builder 2
            Builder lConcreteBuilder2 = new ConcreteBuilder2(); // Define Builder
            lDirector.Construct(lConcreteBuilder2);             // Build Product
            Product lProduct2 = lConcreteBuilder2.GetResult();  // Get Product
            Console.WriteLine("\n\rBuilder 2 - Product Result: ");
            lProduct2.Show();
        }
    }

    public class Director
    {
        public void Construct(Builder prBuilder)
        {
            // Builder can use a complex series of steps
            prBuilder.BuildPartOne();
            prBuilder.BuildPartTwo();
        }
    }

    public abstract class Builder
    {
        protected Product _Product = new Product();
        public abstract void BuildPartOne();
        public abstract void BuildPartTwo();
        public abstract Product GetResult();
    }

    public class ConcreteBuilder1 : Builder
    {
        public override void BuildPartOne()
        {
            _Product.Add("Part A");
        }

        public override void BuildPartTwo()
        {
            _Product.Add("Part B");
        }

        public override Product GetResult()
        {
            return _Product;
        }
    }

    public class ConcreteBuilder2 : Builder
    {
        public override void BuildPartOne()
        {
            _Product.Add("Part C");
        }

        public override void BuildPartTwo()
        {
            _Product.Add("Part D");
        }

        public override Product GetResult()
        {
            return _Product;
        }
    }

    public class Product
    {
        public List<string> _Parts = new List<string>();

        public void Add(string prPart)
        {
            _Parts.Add(prPart);
        }

        public void Show()
        {
            Console.WriteLine("Product created with the following parts: " + String.Join(", ", _Parts));
        }
    }
}