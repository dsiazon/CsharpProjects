// Composite Formatting uses numbered placeholders within a string. At run time, everything inside the braces is resolved to a value that is also passed in based on their position.

string first = "Hello";
string second = "World";
string result = string.Format("{1} {0}!", first, second);
Console.WriteLine(result);
Console.WriteLine("{0} {0} {0}!", first, second);


//String interpolation is a technique that simplifies composite formatting.

string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

// Formatting currency

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

//Formatting numbers

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");


//Formatting percentages

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P3}");


//Combining formatting approaches

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = string.Format("You saved {0:C} off the regular {1:C2} price.", (price - salePrice), price);

yourDiscount += $" A discount of {((price - salePrice)/price):P2}!";

Console.WriteLine(yourDiscount);

// Discover padding and alignment

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

//Formatting strings by adding whitespace before or after

string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

// Overloaded method: an overloaded method is another version of a method with different or extra arguments
// that modify the functionality of the method slightly, as is the case with the overloaded version of the PadLeft() method.


// Working with padded strings

// Add the Payment ID, payee name, payment amount to the output

string paymentId = "769C";
string payeeName = "Danielle Siazon";
string paymnetAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(5);
formattedLine += paymnetAmount.PadLeft(10);

// Add a line of numbers above the output to more easily confirm the result

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);


// Exercise - Complete a challenge to apply string interpolation to a form letter

/* __________OUTPUT__________

Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75 %.

Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75 %   $55,000,000.00      
Glorious Future     13.13 %   $63,000,000.00

*/

// Starting Code

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string message = "";

message += string.Format("Dear {0}, \nAs a customer of our {1} offering we are excited to tell you about a new financial product that would dramatically increase your return.", customerName, currentProduct);
message += string.Format("\n\nCurrently, you own {0:N} shares at a return of {1:P2}.", currentShares, currentReturn);
message += string.Format("\n\nOur new product, {0} offers a return of {1:P2}. Given your current volume, your potential profit would be {2:C}. \n", newProduct, newReturn, newProfit);

Console.WriteLine(message);

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage += currentProduct.PadRight(20);
comparisonMessage += string.Format("{0:P2}   {1:C} \n", currentReturn, currentProfit);
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += string.Format("{0:P2}   {1:C}", newReturn, newProfit);

Console.WriteLine(comparisonMessage);

// dotnet new console -o ./ProjectName