﻿using Main.Decorator;
using Main.Facade;
using Main.Factory;
using Main.Singleton;
using Main.TemplateMethod;

bool lShowMenu = true;
while (lShowMenu)
{
    lShowMenu = MainMenu();
}

static bool MainMenu()
{
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

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("---------------------");
    Console.WriteLine("EXIT");
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   0. Exit");
    Console.WriteLine("\r\n---------------------------------");
    Console.Write("Selected option: ");

    Console.SetWindowPosition(0, 0);

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
        case "0": return false;
        default: return true;
    }
}

static void ShowHeader(string prDesignPatternTitle)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("---------------------------------");
    Console.WriteLine(prDesignPatternTitle);
    Console.WriteLine("---------------------------------\n\r");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Output:\n\r");
    Console.ForegroundColor = ConsoleColor.Yellow;
}

static void ShowFooter()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\r\n---------------------------------");
    Console.Write("Press any key to return to main menu...");
    Console.ReadKey();
}