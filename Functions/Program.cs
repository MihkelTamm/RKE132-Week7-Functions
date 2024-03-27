Console.WriteLine("Are you coming or leving? (in/out):");
string userChoice = Console.ReadLine();

if (userChoice == "In")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}


static void PrintHello() //function / method
{
    Console.WriteLine("Hello, world");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator.");
}