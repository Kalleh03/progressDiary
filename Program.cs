// while loop checks a condition at the start, then executes that block of code if the condition is true.
// do while loops always executes a block of code once THEN checks the condition at the bottom.







int number = 0;
int sum = 0;


Console.WriteLine($"Gimme a number under 100: ");
number = Convert.ToInt32(Console.ReadLine());

do
{
    sum += number++;
    if (sum > 0)
    {
        
        Console.WriteLine($"We plus {number} to {sum} ");
    }

}while (sum <= 100);

while (sum > 100)
{
    Console.WriteLine("AAAAND we're over 100!");
    break;
}


