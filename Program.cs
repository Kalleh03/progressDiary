using System;
using System.Runtime.CompilerServices;



class Program
{   
    static void Main()
    {
    int[] numbers = { 4, 8, 15, 16, 23, 42 };
    int total = 0;
    bool found = false;

    foreach (int number in numbers)
    {
        total += number;
        if (number == 42) 
            found = true;
    }

    if (found)
        Console.WriteLine("Set contains 42");
    
    Console.WriteLine($"Total: {total}");   
    }    
}

            
            
                    
            

        


            
            

            

        


// To initialize a value you need it before the if statement.  Ex value = 10;
// We can give int a value of 0 outside the if statement and then give it another value after. 
// To increase readability we don't use too many curlybraces if we don't have to.
// Also we don't smash everything into one line of code. 

// Moving int for total and bool found = false outside the codebracket.  
// 