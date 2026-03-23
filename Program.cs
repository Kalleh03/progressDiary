using System;
using System.Runtime.CompilerServices;

// This was interesting, a lesson in compressing code and making it readable. 
// Really interesting stuff and i get most of it, bools are the problem right now.
// I still have some work to do concerning formatting etc, but it's getting there!  

class Program
{   
    static void Main()
    {

        Console.WriteLine(1 > 2);
        Console.WriteLine(1 < 2);
        Console.WriteLine(1 >= 1);
        Console.WriteLine(1 <= 1);

    }    
}
    

    // When using strings i should use ToUpper() or ToLower() to make the strings uniform.
    // Also to remove whitespace i can use Trim() so there's no sneaky space just waiting to bug me. 
    // I can use these in order by adding a ().ToLower() after another method.