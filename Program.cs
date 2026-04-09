// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>

// this is the string we get to search in. 
string sku = "01-MN-L";

// this is the sneaky string in to array and split at the "-" that we have never seen before... 
string[] product = sku.Split('-');


// these are just there to store the answers. 
string type = "";
string color = "";
string size = "";

// search through the first part of the string for numbers.
switch (product[0])
{
    case "01":
    type = "Sweat shirt";
    break;

    case "02":
    type = "T-shirt";
    break;

    case "03":
    type = "Sweat pants";
    break;

    default:
    type = "Other";
    break;
}

// search through the string for "BL"
switch (product[1])
{
    case "BL":
    color = "Black";
    break;

    case "MN":
    color = "Maroon";
    break;

    default:
    color = "White";
    break;
}

// search through the string for "L"
switch (product[2])
{
    case "S":
    size = "Small";
    break;

    case "M":
    size = "Medium";
    break;

    case "L":
    size = "Large";
    break;

    default:
    size = "Large";
    break;
}

// output from the switches into text. 
Console.WriteLine($"Product: {type} {size} {color} ");
