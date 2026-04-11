// FUUUCK YEAH! First time i completed a challenge without looking at the answer! 
// I'm gonna celebrate with a beer, then i'm gonna check what's actually needed in the code and what's overengineered.

// A for statement is made up of three different parts.  The first one is the initializer, that's int i = 1; in this example
// The second part is separated by a semicolon and called the condition.
// Third part is separated by semicolon aswell and called the iterator. 
// The whole thing with i= int inside the parenthesis is called the body. 


// Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
// When the current value is divisible by 3, print the term Fizz next to the number.
// When the current value is divisible by 5, print the term Buzz next to the number.
// When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.



for (int i = 1; i < 101; i++)

{   

    if (i % 5 == 0 && i % 3 == 0 )
    {
        Console.WriteLine($"{i} FizzBuzz");
    }

    else if (i % 3 == 0 && !(i % 5 == 0))

    Console.WriteLine($"{i} Fizz");

    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} Buzz");
    }

    else
    {
    Console.WriteLine(i);
    }
}    
    
