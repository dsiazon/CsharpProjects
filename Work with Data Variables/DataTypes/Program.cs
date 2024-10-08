﻿
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");

Console.WriteLine("Unigned integral types:");

Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");

Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

int[] data = new int[3];

string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float: {myFloat}");

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);

Console.WriteLine(sum);

//Casting

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

int value = (int)1.23456789m;
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m);
Console.WriteLine(value2);

<<<<<<< HEAD:DataTypes/Program.cs
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");


//Cast
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");


// narrowing conversion means that you're attempting to convert a value from a data type that can hold 
// more information to a data type that can hold less information

// widening conversion means that you're attempting to convert a value from a data type that could hold 
// less information to a data type that can hold more information

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float : {myFloat}");



//ToString() method

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);


// Convert a string to an int using the Parse() helper method

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

// Convert a string to a int using the Convert class

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);


//Compare casting and converting a decimal into an int

int value = (int)1.5m;
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m);
Console.WriteLine(value2);

*/
=======


// TryParse() method

string name = "Bob";
Console.WriteLine(int.Parse(name));

//-> System.FormatException: 'Input string was not in a correct format.'

// TryParse() a string into an int

string value = "102";
int result = 0;
if (int.TryParse(value, out result)){
    Console.WriteLine($"Measurement: {result}");
}else{
    Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");

//-> Measurement: 102
//-> Measurement (w/ offset): 152


// Complete a challenge to combine string
// array values as strings and as integers

string[] values = {"12.3", "45", "ABC", "11", "DEF"};
decimal total = 0m;
string message = "";

foreach(var value in values)
{
    decimal num;
    if(decimal.TryParse(value, out num)){
        total += num;
    }else{
        message += value;
    }
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");

//-> Message: ABCDEF
//-> Total: 68.3

*/

//Complete a challenge to output math operations as specific number types

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = value1 / (int)value2;
int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / (float)value1;
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
>>>>>>> 26d81867e4ca25f909ba5c7170110d1b7c1d8c2b:Work with Data Variables/DataTypes/Program.cs
