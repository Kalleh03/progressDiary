

string permission = "Admin|Manager";
int level = 55;

// ett if statement med permission först för att se om man är admin eller inte. 
// sen ett if statement med level för admin och else
// sen fortsätta så ner i listan med level.

if (level > 55 && permission.Contains("Admin"))
{
    Console.WriteLine("Welcome, super Admin user");
}

else if(level >= 20 && permission.Contains("Admin"))
{
    Console.WriteLine("Welcome, Admin user.");
}

else if(level <= 20 && permission.Contains("Admin"))
{
    Console.WriteLine("Contact an Admin for access.");
}

else 
{
    Console.WriteLine("You do not have sufficient privileges");
}