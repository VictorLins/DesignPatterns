using Main.AbstractFactory;
using Main.Adapter;
using Main.Bridge;
using Main.Builder;
using Main.ChainOfResponsability;
using Main.Command;
using Main.Composite;
using Main.Decorator;
using Main.Facade;
using Main.Factory;
using Main.Interpreter;
using Main.Iterator;
using Main.Mediator;
using Main.Memento;
using Main.Observer;
using Main.Prototype;
using Main.Proxy;
using Main.Singleton;
using Main.State;
using Main.Strategy;
using Main.TemplateMethod;
using Main.Visitor;

bool lShowMenu = true;
while (lShowMenu)
{
    lShowMenu = MainMenu();
}

static bool MainMenu()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("SOFTWARE ARCHITECTURE SIMPLIFIED");
    Console.WriteLine("---------------------------------");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Please Enter Your Choice:");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("TEMPLATE METHOD");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   1. Structural");
    Console.WriteLine("   2. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("SINGLETON");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   3. Structural");
    Console.WriteLine("   4. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("FACADE");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   5. Structural");
    Console.WriteLine("   6. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("FACTORY METHOD");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   7. Structural");
    Console.WriteLine("   8. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("DECORATOR");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   9. Structural");
    Console.WriteLine("   10. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("CHAIN OF RESPONSIBILITY");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   11. Structural");
    Console.WriteLine("   12. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("ADAPTER");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   13. Structural");
    Console.WriteLine("   14. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("BUILDER");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   15. Structural");
    Console.WriteLine("   16. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("STATE");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   17. Structural");
    Console.WriteLine("   18. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("STRATEGY");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   19. Structural");
    Console.WriteLine("   20. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("ABSTRACT FACTORY");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   21. Structural");
    Console.WriteLine("   22. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("OBSERVER");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   23. Structural");
    Console.WriteLine("   24. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("COMPOSITE");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   25. Structural");
    Console.WriteLine("   26. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("MEMENTO");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   27. Structural");
    Console.WriteLine("   28. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("COMMAND");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   29. Structural");
    Console.WriteLine("   30. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("MEDIATOR");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   31. Structural");
    Console.WriteLine("   32. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("INTERPRETER");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   33. Structural");
    Console.WriteLine("   34. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("PROTOTYPE");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   35. Structural");
    Console.WriteLine("   36. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("BRIDGE");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   37. Structural");
    Console.WriteLine("   38. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("ITERATOR");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   39. Structural");
    Console.WriteLine("   40. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("VISITOR");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   41. Structural");
    Console.WriteLine("   42. Practical");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---------------------");
    Console.WriteLine("PROXY");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   43. Structural");
    Console.WriteLine("   44. Practical");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("---------------------");
    Console.WriteLine("EXIT");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   0. Exit");
    Console.WriteLine("\r\n---------------------------------");
    Console.Write("Selected option: ");

    switch (Console.ReadLine())
    {
        case "1":
            ShowHeader("TEMPLATE METHOD - STRUCTURAL");
            TemplateMethodStructural.Execute();
            ShowFooter();
            return true;
        case "2":
            ShowHeader("TEMPLATE METHOD - PRACTICAL");
            TemplateMethodPractical.Execute();
            ShowFooter();
            return true;
        case "3":
            ShowHeader("SINGLETON - STRUCTURAL");
            SingletonStructural.Execute();
            ShowFooter();
            return true;
        case "4":
            ShowHeader("SINGLETON - PRACTICAL");
            SingletonPractical.Execute();
            ShowFooter();
            return true;
        case "5":
            ShowHeader("FACADE - STRUCTURAL");
            FacadeStructural.Execute();
            ShowFooter();
            return true;
        case "6":
            ShowHeader("FACADE - PRACTICAL");
            FacadePractical.Execute();
            ShowFooter();
            return true;
        case "7":
            ShowHeader("FACTORY METHOD - STRUCTURAL");
            FactoryMethodStructural.Execute();
            ShowFooter();
            return true;
        case "8":
            ShowHeader("FACTORY METHOD - PRACTICAL");
            FactoryMethodPractical.Execute();
            ShowFooter();
            return true;
        case "9":
            ShowHeader("DECORATOR - STRUCTURAL");
            DecoratorStructural.Execute();
            ShowFooter();
            return true;
        case "10":
            ShowHeader("DECORATOR - PRACTICAL");
            DecoratorPractical.Execute();
            ShowFooter();
            return true;
        case "11":
            ShowHeader("CHAIN OF RESPONSIBILITY - STRUCTURAL");
            ChainOfResponsibilityStructural.Execute();
            ShowFooter();
            return true;
        case "12":
            ShowHeader("CHAIN OF RESPONSIBILITY - PRACTICAL");
            ChainOfResponsibilityPractical.Execute();
            ShowFooter();
            return true;
        case "13":
            ShowHeader("ADAPTER - STRUCTURAL");
            AdapterStructural.Execute();
            ShowFooter();
            return true;
        case "14":
            ShowHeader("ADAPTER - PRACTICAL");
            AdapterPractical.Execute();
            ShowFooter();
            return true;
        case "15":
            ShowHeader("BUILDER - STRUCTURAL");
            BuilderStructural.Execute();
            ShowFooter();
            return true;
        case "16":
            ShowHeader("BUILDER - PRACTICAL");
            BuilderPractical.Execute();
            ShowFooter();
            return true;
        case "17":
            ShowHeader("STATE - STRUCTURAL");
            StateStructural.Execute();
            ShowFooter();
            return true;
        case "18":
            ShowHeader("STATE - PRACTICAL");
            StatePractical.Execute();
            ShowFooter();
            return true;
        case "19":
            ShowHeader("STRATEGY - STRUCTURAL");
            StrategyStructural.Execute();
            ShowFooter();
            return true;
        case "20":
            ShowHeader("STRATEGY - PRACTICAL");
            StrategyPractical.Execute();
            ShowFooter();
            return true;
        case "21":
            ShowHeader("ABSTRACT FACTORY - STRUCTURAL");
            AbstractFactoryStructural.Execute();
            ShowFooter();
            return true;
        case "22":
            ShowHeader("ABSTRACT FACTORY - PRACTICAL");
            AbstractFactoryPractical.Execute();
            ShowFooter();
            return true;
        case "23":
            ShowHeader("OBSERVER - STRUCTURAL");
            ObserverStructural.Execute();
            ShowFooter();
            return true;
        case "24":
            ShowHeader("OBSERVER - PRACTICAL");
            ObserverPractical.Execute();
            ShowFooter();
            return true;
        case "25":
            ShowHeader("COMPOSITE - STRUCTURAL");
            CompositeStructural.Execute();
            ShowFooter();
            return true;
        case "26":
            ShowHeader("COMPOSITE - PRACTICAL");
            CompositePractical.Execute();
            ShowFooter();
            return true;
        case "27":
            ShowHeader("MEMENTO - STRUCTURAL");
            MementoStructural.Execute();
            ShowFooter();
            return true;
        case "28":
            ShowHeader("MEMENTO - PRACTICAL");
            MementoPractical.Execute();
            ShowFooter();
            return true;
        case "29":
            ShowHeader("COMMAND - STRUCTURAL");
            CommandStructural.Execute();
            ShowFooter();
            return true;
        case "30":
            ShowHeader("COMMAND - PRACTICAL");
            CommandPractical.Execute();
            ShowFooter();
            return true;
        case "31":
            ShowHeader("MEDIATOR - STRUCTURAL");
            MediatorStructural.Execute();
            ShowFooter();
            return true;
        case "32":
            ShowHeader("MEDIATOR - PRACTICAL");
            MediatorPractical.Execute();
            ShowFooter();
            return true;
        case "33":
            ShowHeader("INTERPRETER - STRUCTURAL");
            InterpreterStructural.Execute();
            ShowFooter();
            return true;
        case "34":
            ShowHeader("INTERPRETER - PRACTICAL");
            InterpreterPractical.Execute();
            ShowFooter();
            return true;
        case "35":
            ShowHeader("PROTOTYPE - STRUCTURAL");
            PrototypeStructural.Execute();
            ShowFooter();
            return true;
        case "36":
            ShowHeader("PROTOTYPE - PRACTICAL");
            PrototypePractical.Execute();
            ShowFooter();
            return true;
        case "37":
            ShowHeader("BRIDGE - STRUCTURAL");
            BridgeStructural.Execute();
            ShowFooter();
            return true;
        case "38":
            ShowHeader("BRIDGE - PRACTICAL");
            BridgePractical.Execute();
            ShowFooter();
            return true;
        case "39":
            ShowHeader("ITERATOR - STRUCTURAL");
            IteratorStructural.Execute();
            ShowFooter();
            return true;
        case "40":
            ShowHeader("ITERATOR - PRACTICAL");
            IteratorPractical.Execute();
            ShowFooter();
            return true;
        case "41":
            ShowHeader("VISITOR - STRUCTURAL");
            VisitorStructural.Execute();
            ShowFooter();
            return true;
        case "42":
            ShowHeader("VISITOR - PRACTICAL");
            VisitorPractical.Execute();
            ShowFooter();
            return true;
        case "43":
            ShowHeader("PROXY - STRUCTURAL");
            ProxyStructural.Execute();
            ShowFooter();
            return true;
        case "44":
            ShowHeader("PROXY - PRACTICAL");
            ProxyPractical.Execute();
            ShowFooter();
            return true;
        case "0": return false;
        default: return true;
    }
}

static void ShowHeader(string prDesignPatternTitle)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine(prDesignPatternTitle);
    Console.WriteLine("-----------------------------------------\n\r");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Output:\n\r");
    Console.ForegroundColor = ConsoleColor.Yellow;
}

static void ShowFooter()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\r\n-------------------------------------");
    Console.Write("Press any key to return to main menu...");
    Console.ReadKey();
}