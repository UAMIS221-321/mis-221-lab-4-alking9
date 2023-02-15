// Welcome message
System.Console.WriteLine("Hello! Select one of the options below to start the program.");

// Call display menu

// Menu Method
static void DisplayMainMenu()
{
    System.Console.WriteLine("Enter 1 to display the full triangle");
    System.Console.WriteLine("Enter 2 to display the partial triangle"); 
    System.Console.WriteLine("Enter 3 to exit");
}



// Exit method
static void Exit()
{
    System.Console.WriteLine("Thank you for experiencing our app!");
    System.Environment.Exit(1);
}

// Display Main menu method
{
    DisplayMainMenu();
    string userInput = Console.ReadLine();

    if(userInput == "1")
    {
        GetFull();  // Call full triangle method
    }
    else if(userInput == "2")
    {
        GetPartial(); // Call partial triangle method
    }
    else if(userInput == "3")
    {
        Exit(); // Call exit method
    }
    else if(userInput != "1" || userInput != "2" || userInput != "3")
    {
        System.Console.WriteLine("Invalid input. Enter 1, 2, or 3.");
        DisplayMainMenu(); // Call Main Menu
    }

    // Full Triangle method
    static void GetFull()
    {
        for(int v = 0; v < 10; v++)
        {
            for(int k = 10; k > v; k--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        System.Console.WriteLine("To display the partial triangle, enter 2.");
        string userInput = Console.ReadLine();
        if(userInput == "2")
        {
            GetPartial();
        }

        else if(userInput != "2")
        {
            System.Console.WriteLine("Invalid input.");
            DisplayMainMenu();
        }

    }

    static void GetPartial()
    {
        for(int v = 0; v < 10; v++)
        {
            for(int k = 10; k > v; k--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
        System.Console.WriteLine();

        System.Console.WriteLine(" To exit please enter 3.");
        string userInput = Console.ReadLine();
        if(userInput == "3")
        {
            Exit();
        }

        else if(userInput != "3")
        {
            System.Console.WriteLine("Invalid Input.");
            DisplayMainMenu();
        }
    }
}