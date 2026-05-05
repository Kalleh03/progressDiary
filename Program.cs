
// So i started a new problem, i think i got the start at least. 


string userInput = "";
string admin = "Administrator";
string manager = "Manager";
string user = "User";
bool validEntry = false;


Console.WriteLine($"Enter your role name (Administrator, Manager, or User)");


while (validEntry == false)
{

    userInput = Console.ReadLine()?.Trim().ToLower();

    if (userInput == user)
    {
        Console.WriteLine($"Your input value ({user}) has been accepted. ");
        validEntry = true;
    }

    else if (userInput == manager)
    {
        Console.WriteLine($"Your input value ({manager}) has been accepted.");
        validEntry = true;
    }

    else if (userInput == admin)
    {
        Console.WriteLine($"Your input value ({manager}) has been accepted.");
        validEntry = true;
    }

    else
    {
        Console.WriteLine($"Invalid role. Please enter Administrator, Manager, or User.");
    }
    
} 

Console.WriteLine($"Role accepted, Continuing...");
Console.ReadLine();
