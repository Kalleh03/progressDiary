
// working on if statements!  
// still having a hard time building these correctly.

string permission = "Torsten";
int level = 10;

// ett if statement med permission först för att se om man är admin eller inte. 
// sen ett if statement med level för admin och else
// sen en likadan för "inte admin" och sist "fakk jo"


if (permission.Contains ("Admin"))
{
    if (level >= 55)
    {
        Console.WriteLine("Welcome Admin super user!");
    }

    else
    {
        Console.WriteLine("Welcome Admin!");
    }
}
else
{
    if (permission.Contains("Manager"))
    {   
        if (level >= 20)
        {
        Console.WriteLine("Talk to an Admin for permissions");
        }
        else
        {
            Console.WriteLine("You don't have the permission to view this.");
        }
    }
    else
    {
        Console.WriteLine("U got nothin");
    }


}