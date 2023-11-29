// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! The UI has started");

Console.WriteLine("Type something in to continue.");
Console.ReadKey(true);
if (!answerYN("Do you wanna access your Bank Account ?"))
{
    throw new Exception("Application ended");   
}

Boolean answerYN(string displayText)
{
    Console.WriteLine(displayText);
    while (true)
    {
        String answer = Console.ReadLine().ToLower().Trim(' ');
        if (answer == "y")
        {
            return true;
        }
        if (answer == "n")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Sorry didn't understand that");
        }
    }
}