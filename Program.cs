
// Övning 1:
// if  (int.TryParse(userInput, out acceptableInput) såhär funkar Parse, om försök( string input, ut intform)

// Övning 2:
// userInput = Console.ReadLine().Trim() ?? string.Empty;  här sparar man input med trim och null direkt! 
// sen går if att snygga till i tre fina rader.
// userInput.Equals(admin, StringComparison.OrdinalIgnoreCase)  här jämför man string mot input. 


// Öva parse, toint, tostring, etc i en writeline. 


double siffra = 1.553d;

Convert.ToDecimal(siffra);

Console.WriteLine(siffra);
Console.WriteLine(siffra.GetType());

Convert.ToString(siffra);

string siffra2 = "1.44";

Console.WriteLine(siffra2);
Console.WriteLine(siffra2.GetType());

