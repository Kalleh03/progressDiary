
// Övning 1:
// if  (int.TryParse(userInput, out acceptableInput) såhär funkar Parse, om försök( string input, ut intform)

// Övning 2:
// userInput = Console.ReadLine().Trim() ?? string.Empty;  här sparar man input med trim och null direkt! 
// sen går if att snygga till i tre fina rader.
// userInput.Equals(admin, StringComparison.OrdinalIgnoreCase)  här jämför man string mot input. 



string admin = "Administrator";
string manager = "Manager";
string user = "User";
bool correctName = false;
string userInput; 

Console.WriteLine($"Enter your role name. Administrator, Manager, or User");

do
{
    userInput = Console.ReadLine().Trim() ?? string.Empty;
    
    if (userInput.Equals(admin, StringComparison.OrdinalIgnoreCase) || 
        userInput.Equals(manager, StringComparison.OrdinalIgnoreCase)|| 
        userInput.Equals(user, StringComparison.OrdinalIgnoreCase))
    {
        correctName = true;
        Console.WriteLine($"Your input value ({userInput}) hahs been accepted.");
    }
    else
    {
        Console.WriteLine($"The role name that you entered ({userInput}) is not valid. Enter your role name (Administrator, Manager, or User)");
    }
}while (!correctName);


