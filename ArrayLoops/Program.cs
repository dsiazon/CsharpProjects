//string [] favGGs = new string[3];
/*
string[] favGGs = {"TWICE", "GIDLE", "RED VELVET"};

Console.WriteLine($"First: {favGGs[0]}");
Console.WriteLine($"Second: {favGGs[1]}");
Console.WriteLine($"Third: {favGGs[2]}");

Console.WriteLine($"I have {favGGs.Length} favorite girl groups.");


foreach (string name in favGGs){
    Console.WriteLine(name);
}

*/
/*
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin  = 0;

foreach (int items in inventory){

    sum+= items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");

}

Console.WriteLine($"We have {sum} items in inventory.");
*/

//CODE CHALLENGE: Report the Order IDs that need further investigation

string[] fraudulentOrderIDs = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

foreach (string items in fraudulentOrderIDs){
    if (items.StartsWith("B")){
        Console.WriteLine(items);
    }
}

