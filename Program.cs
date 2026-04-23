
// I am playing around with type casting, converting here and there to really get a hang of this. 
// Dunno, but it feels ok? 





Console.WriteLine("Write a number: ");
string? userInput = Console.ReadLine();
int inputInt = Convert.ToInt32(userInput);
Console.WriteLine($" You wrote : {inputInt}");
Console.WriteLine($"Now we convert {inputInt} to double!");
double inputDouble = Convert.ToDouble(inputInt);
Console.WriteLine($" You wrote : {inputDouble} which is now a Double!");
Console.WriteLine(inputDouble.GetType());
float inputFloat = Convert.ToSingle(inputDouble);
Console.WriteLine($"You wrote {inputFloat.GetType()} which is a float now!");
