using System;
using System.Runtime.CompilerServices;



class Program
{   
    

    static void Main()
    {
        string[] fraudIDs = {"A55DF", "A456", "B3456", "B345488", "A12", "B778", "C1"};

       foreach (string fraudID in fraudIDs)
        {
            if(fraudID.Contains("2"))
            {   
                Console.WriteLine(fraudID);
            }
            else
            {
                Console.WriteLine($"{fraudID} did not contain 2");
            }
        }

        foreach (string fraudID in fraudIDs)
        {
            if(fraudID.EndsWith("6"))
            {
                Console.WriteLine($"{fraudID} ends with 6");
            }
            else
            {
                Console.WriteLine($"{fraudID} did not end with 6");
            }
        }
    }
}


// först bygger man en string med orderIDs . 
// sen gör man en foreach med string orderID som pekar in i string med in orderIDs
// efter det en if orderID.StartsWith
// sen skriver man ut orderID