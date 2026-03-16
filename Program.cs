using System;
using System.Runtime.CompilerServices;



class Program
{   
    

    static void Main()
    {
        string[] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
        int [] orderNr  = {111, 444, 666, 442, 555, 888, 145, 135, 1113};
        int sum = 0;
        int bin = 0;
        
       foreach(string orderID in orderIDs)
        {
            if (orderID.StartsWith("B"))
            {
                Console.WriteLine(orderID);
            }
        }

        foreach (int order in orderNr)
        {
            
            sum += order;
            bin++;
            Console.WriteLine($"Bin {bin} = {order} items (running total: {sum})");
            
            
        }
        Console.WriteLine($"We have {sum} items in inventory.");

    }
}


// först gör man en string med orderIDs. 
// sen gör man en foreach med string orderID som pekar in i string med in orderIDs
// efter det en if orderID.StartsWith
// sen skriver man ut orderID