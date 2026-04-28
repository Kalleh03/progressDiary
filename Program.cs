// I feel like i have understood how to convert from string, to double, to decimal and back to int again without problems. 


Console.Write("Write a number: ");
int number = Convert.ToInt32(Console.ReadLine());
double numberDouble = Convert.ToDouble(number);
Console.WriteLine($"{numberDouble} double");
Console.WriteLine(numberDouble.GetType());
decimal numberDecimal = Convert.ToDecimal(numberDouble);
Console.WriteLine($"{numberDecimal} decimal");
Console.WriteLine(numberDecimal.GetType());
int number2 = Convert.ToInt32(numberDecimal);
Console.WriteLine($"{number2} int again!");
Console.WriteLine(number2.GetType());