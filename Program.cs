// this shit doesn't work at all and i don't know why... 






string? readResult;
string roleName = "";
bool validEntry = false;

do
{
    Console.WriteLine($"Enter your role name (Administrator, Manager or User)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "Administrator" || roleName.ToLower() == "Manager" || roleName.ToLower() == "user")
    {
        validEntry = true; 
    }
    else
    {
        Console.Write($"The role name you entered, \"{roleName}\" is not valid. ");
    }
}while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();

