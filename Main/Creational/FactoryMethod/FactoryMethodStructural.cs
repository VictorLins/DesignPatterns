namespace Main.Factory
{
    public static class FactoryMethodStructural
    {
        public static void Execute()
        {
            IFactory lFactory = new FactoryA();
            IProduct lProduct = lFactory.FactoryMethod("One");
            lProduct.MethodTest();
            lProduct = lFactory.FactoryMethod("Two");
            lProduct.MethodTest();

            lFactory = new FactoryB();
            lProduct = lFactory.FactoryMethod("One");
            lProduct.MethodTest();
            lProduct = lFactory.FactoryMethod("Two");
            lProduct.MethodTest();
        }
    }

    public interface IProduct
    {
        void MethodTest();
    }

    public class ProductAOne : IProduct
    {
        public void MethodTest() { Console.WriteLine("Product A One - Executing MethodTest"); }
    }

    public class ProductATwo : IProduct
    {
        public void MethodTest() { Console.WriteLine("Product A Two - Executing MethodTest"); }
    }

    public class ProductBOne : IProduct
    {
        public void MethodTest() { Console.WriteLine("Product B One - Executing MethodTest"); }
    }

    public class ProductBTwo : IProduct
    {
        public void MethodTest() { Console.WriteLine("Product B Two - Executing MethodTest"); }
    }

    public interface IFactory
    {
        IProduct FactoryMethod(String prType);
    }

    public class FactoryA : IFactory
    {
        public IProduct FactoryMethod(String prType)
        {
            if (prType == "One")
                return new ProductAOne();
            else
                return new ProductATwo();
        }
    }

    public class FactoryB : IFactory
    {
        public IProduct FactoryMethod(String prType)
        {
            if (prType == "One")
                return new ProductBOne();
            else
                return new ProductBTwo();
        }
    }
}