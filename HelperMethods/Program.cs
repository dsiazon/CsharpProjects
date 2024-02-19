// dotnet new console -o ./HelperMethods
/*
// Create an array of pallets, then sort them

string[] pallets = { "B14", "A11", "B12", "A13"  };

Array.Sort(pallets);

foreach( var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reverse: ");

Array.Reverse(pallets);

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


//Clear() and Resize()
//Access value of cleared element
// Call string helper method on cleared element

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0].ToLower()}");
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Resize 

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Split() Join()

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);


string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = string.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach( string item in items)
{
    Console.WriteLine(item);
}

//Reverse words in a sentence

string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);

//sort orders and tag errors

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(",");

Array.Sort(orders);

foreach(var order in orders){
    if(order.Length != 4){
        Console.WriteLine($"{order}     - Error");
    }else{
        Console.WriteLine(order);
    }
}
*/
