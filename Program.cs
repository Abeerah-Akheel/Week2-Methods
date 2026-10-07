CreateMenu();

void CreateMenu()
{
    try
    {
        //Construct the menu
        Console.Clear();
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. Say Hello");
        Console.WriteLine("2. Add Numbers");
        Console.WriteLine("3. Exit");
        Console.WriteLine("Choose an option: ");

        //Accept the user choice
        string choice = Console.ReadLine();

        switch(choice)
        {
            case "1":
                SayHello();
                break;
            case "2":
                AddNumbers();
                break;
            case "3":
                break;
            default:
                Console.WriteLine("Invalid choice.Please try again.");
                break;
        }
    }

    //Add exception
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}

//Create SayHello method
static void SayHello()
{
    Console.WriteLine("Hello, world!");
}

//Create AddNumbers method
static void AddNumbers()
{
    Console.WriteLine("Enter first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    int result = firstNumber + secondNumber;
    Console.WriteLine($"The result is: {result}");
}