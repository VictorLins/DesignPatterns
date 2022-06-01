AbstractClass lAbstractClassA = new ConcreteClassA();
lAbstractClassA.TemplateMethod();

AbstractClass lAbstractClassB = new ConcreteClassB();
lAbstractClassB.TemplateMethod();
 
public abstract class AbstractClass
{
    public void TemplateMethod()
    {
        Step1();
        Step2();
    }
    protected abstract void Step1();
    protected abstract void Step2();
}

public class ConcreteClassA : AbstractClass
{
    protected override void Step1()
    {
        Console.WriteLine("ConcreteClassA - Step1");
    }

    protected override void Step2()
    {
        Console.WriteLine("ConcreteClassA - Step2");
    }
}

public class ConcreteClassB : AbstractClass
{
    protected override void Step1()
    {
        Console.WriteLine("ConcreteClassB - Step1");
    }

    protected override void Step2()
    {
        Console.WriteLine("ConcreteClassB - Step2");
    }
}