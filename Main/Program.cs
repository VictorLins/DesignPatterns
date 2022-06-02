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