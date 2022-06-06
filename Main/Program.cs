using Main.AbstractFactory;
using Main.Adapter;
using Main.Builder;
using Main.ChainOfResponsability;
using Main.Decorator;
using Main.Facade;
using Main.Factory;
using Main.Singleton;
using Main.State;
using Main.Strategy;
using Main.TemplateMethod;

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