using System;

public static class ConsoleUI
{
    public static void DisplayLogo()
    {
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(@"
╔══════════════════════════════════════════════════════════════════════╗
║                                                                      ║
║ _____          ____        _   
 / ____|        |  _ \      | |  
| (___   ___ ___| |_) | ___ | |_ 
 \___ \ / __/ _ \  _ < / _ \| __|
 ____) | (_|  __/ |_) | (_) | |_ 
|_____/ \___\___|____/ \___/ \__|
║                                                                      ║
╚══════════════════════════════════════════════════════════════════════╝
");

        Console.ResetColor();
    }
} 

