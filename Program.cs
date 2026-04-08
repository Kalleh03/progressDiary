// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>


string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

string clothes = "";

// gjort en ny string clothes för att spara kläder.  Nu visar den "M" för mitt case är tomt. 

switch(clothes)
{
    case "product":
    size = "S";
    break;

    case "":
    size = "M";
    break;

    case "03":
    size = "L";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");

// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// } else if (product[0] == "02")
// {
//     type = "T-Shirt";
// } else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

// if (product[1] == "BL")
// {
//     color = "Black";
// } else if (product[1] == "MN")
// {
//     color = "Maroon";
// } else
// {
//     color = "White";
// }

// if (product[2] == "S")
// {
//     size = "Small";
// } else if (product[2] == "M")
// {
//     size = "Medium";
// } else if (product[2] == "L")
// {
//     size = "Large";
// } else
// {
//     size = "One Size Fits All";
// }
