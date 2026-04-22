// this took some tinkering and where parsing goes in and what comes out is still a mystery, but it works! 

// while loop checks a condition at the start, then executes that block of code if the condition is true.
// do while loops always executes a block of code once THEN checks the condition at the bottom.


string? userInput = "";
int acceptableInput = 0;
bool working = false;

Console.WriteLine($"Enter a integer between 5 and 10:");

do  
{   
    userInput = Console.ReadLine();

    if (int.TryParse(userInput, out acceptableInput) && acceptableInput >= 5 && acceptableInput <= 10)
    {   
        working = true;
        Console.WriteLine($"Your input value ({acceptableInput}) has been accepted.");
    }   

    else
    {
        Console.WriteLine("Sorry, you entered a invalid number, please try again.");
    } 

        
        
}while (working == false); 


