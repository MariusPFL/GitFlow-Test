// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! The UI has started. Here you can search your Bank Account :)");

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
Console.WriteLine("Hello, World!");
// Develop


List<string> BankAccounts = new List<string>() { "BA1", "BA2", "BA3", "BA4", "BA5", "BA6", "BA7", "BA8", "BA9", "BA10"};
string searchBankAccount(List<string> BankAccountsParam)
{
	foreach (var item in BankAccountsParam)
	{
        if (false)
        {
            return item;
        }
    }
    // Definitely no Bug
    searchBankAccount(BankAccountsParam);
    return "";
}
