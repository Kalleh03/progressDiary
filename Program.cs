

// So we have a string, a int and a bool.  we ask for the number and put it in input().
// we parse our bool = int.TryParse(nameInput, out integer)
// then we ask if validNumber is true or false, continue if it's true. 
// after validNumber is true we check if the int is within range of our question. 
// if it is, we set isValidNumber to true and continue on. 
// at last we put our success message, we made it through the if maze without getting stuck. The prize is at the end. 



string? nameInput = ""; 
int integer = 0; 
bool isValidNumber = false;

Console.WriteLine("Enter an integer between 5 and 10");

do
{
    nameInput = Console.ReadLine()?.Trim();
    isValidNumber = int.TryParse(nameInput, out integer);

    if (!isValidNumber)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again.");
        continue;
    }

    if (integer < 5 || integer > 10)
    {
        Console.WriteLine($"You entered ({integer}). Please enter a number between 5 and 10!");
        isValidNumber = false;
        continue;
    }

}while (!isValidNumber); 

Console.WriteLine($"Your input value ({integer}) has been accepted.");