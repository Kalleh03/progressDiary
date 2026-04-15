


// So here we read a console line in int32 and then try to get the correct output if it's between 5 and 10.
// It works, it really does!  It looks like shit though. 


Console.WriteLine("Gimme a number between 5 and 10.");

int readResult = Convert.ToInt32(Console.ReadLine());
bool validEntry = false;

do
{
    if (readResult != null)
    {
        if (readResult < 5)
        {
            Console.WriteLine("Number too small, go bigger!");
        }
        else if (readResult >=5 && readResult <= 10)
        {
            validEntry = true;
            Console.WriteLine($"Yay you wrote {readResult}");
        }
        else
        {
            Console.WriteLine("Invalid input, please write a number between 5 and 10.");
        }
    }

} while (validEntry = false);