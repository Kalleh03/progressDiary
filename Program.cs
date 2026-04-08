

// vi börjar med att declare employeelevel och employeename.
int employeLevel = 300;
string employeName = "Kalle";

// sen behöver vi en tom string för title att använda.

string title = "";


// sen switch block för employeelevel och case inuti med title och sist en break för att bryta process.
// ett switch statement är ett block och behöver inte delas med {}. varje case avslutas med ":". sista heter default.

switch (employeLevel)
{
case 100:
title = "Mupp";
break;

case 200:
title = "Muppare";
break;

case 300:
title = "Muppast";
break;

default:
title = "El-reta..";
break;
}

Console.WriteLine($"{employeName} is {title}");