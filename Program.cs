//  do loops haunt me. 





string? readResult;
bool correctOutput;

Console.WriteLine("Enter a number between 5 and 10:");
readResult = Console.ReadLine();    
int intResult = Convert.ToInt32(readResult);

do
{   
    Console.WriteLine("Enter a valid number!");
    do 
    {

        if (intResult >= 5 || intResult <= 10)
        {
            Console.WriteLine($"correct result {intResult}");
            correctOutput = true;
        }    

        else
        {
        Console.WriteLine("");    
        }

    }while (correctOutput == false);
} while (readResult == null);


