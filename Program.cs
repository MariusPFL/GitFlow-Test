// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Here you can search your Bank Account :)");
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
