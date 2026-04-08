

// vi börjar med att declare employeelevel och employeename.
int employeelevel = 400;
string employeename = "Kalle";

// sen behöver vi en tom string för title att använda.

string title = "";

// sen switch block för employeelevel och case inuti med title och sist en break för att bryta process.
// ett switch statement är ett block och behöver inte delas med {}. varje case avslutas med ":". sista heter default.

switch (employeelevel)
{
    case 100:
    title = "Junior associate";
    break;

    case 200:
    title = "Medium associate";
    break;

    case 300:
    title = "Senior associate";
    break;

    case 400:
    title = "Owner";
    break;

    default:
    title = "Scrub";
    break;
}

Console.WriteLine($"{employeename} is a {title}");