//  I feel like the Microsoft course is complicating the conversions something  terrible and i'm working on a way around it. 





string userInput = "";
int userinputInt = Convert.ToInt32(userInput);
bool validEntry = false;

Console.WriteLine("Write a number between 5 and 10:");

do 
{      
    userInput = Console.ReadLine();
    if (validEntry != null)
    {
        if (userinputInt >= 5 || userinputInt <= 10)
        {
            validEntry = false;
        }    



    }    
    
} while (validEntry == false);

Console.WriteLine($"Your input value {userinputInt} has been accepted!");
