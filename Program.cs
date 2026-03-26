class Program

        // so i started adding everything to the same file and separate them by strings so i know where one function starts.
{   
    static void Main()
    {

        int a = 7;
        int b = 6;
        
        string s1 = "Hello";
        string s2 = "Hello";

        Console.WriteLine(1 > 2);
        Console.WriteLine(1 < 2);
        Console.WriteLine(1 >= 1);
        Console.WriteLine(1 <= 1);


        Console.WriteLine("Start of string");
        string testText = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(testText.Contains("cow"));
        Console.WriteLine(testText.Contains("fox"));


        Console.WriteLine("Start of string2");
        Console.WriteLine(testText.Contains("dog") == false);
        Console.WriteLine(!testText.Contains("dog"));



        Console.WriteLine("Start of string3");
        Console.WriteLine(!testText.Contains("fox"));   //this says "not contains fox" which is False.
        Console.WriteLine(!testText.Contains("cow"));   //this says "not contains cow" so that's True. 


        Console.WriteLine("Start of string4 (a != b)");
        Console.WriteLine(a != b); // output: True
        Console.WriteLine(s1 != s2); // output: False


    }    
}
    

    // When using strings i should use ToUpper() or ToLower() to make the strings uniform.
    // Also to remove whitespace i can use Trim() so there's no sneaky space just waiting to bug me. 
    // I can use these in order by adding a ().ToLower() after another method.
    // Ctrl-h is used to find and replace all instances of a word IN THIS FILE Ctrl-shift-h for all instances within project. 
    // ! is used for "not" can be used in a argument or ==false behind argument.

