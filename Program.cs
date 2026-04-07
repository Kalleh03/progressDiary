
// working on if statements!  
// still having a hard time building these correctly.

string permission = "Admin|Manager";
int level = 10;

// ett if statement med permission först för att se om man är admin eller inte. 
// sen ett if statement med level för admin och else
// sen fortsätta så ner i listan med level.

if (permission.Contains ("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, super user Admin");
    }

    else
    {
        Console.WriteLine("Welcome Admin");
    }

}

else if (permission.Contains("Manager"))
{   
    if (level >= 20)
    {
        Console.WriteLine("Contact Admin for access!");
    }

    else
    {
        Console.WriteLine("You do not have sufficient privileges");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges");
}