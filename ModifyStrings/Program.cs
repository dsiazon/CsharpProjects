// Use the string's IndexOf() and Substring() helper methods

string message = "Find what is (inside the parantheses)";

int openingPosition = message.IndexOf("(") + 1;
int closingPosition = message.IndexOf(")");

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

string message1 = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition1 = message1.IndexOf(openSpan);
int closingPosition1 = message1.IndexOf(closeSpan);

openingPosition1 += openSpan.Length;

int length1 = closingPosition1 - openingPosition1;
Console.WriteLine(message1.Substring(openingPosition1, length1));


//Exercise - Use the string's IndexOfAny() and LastIndexOf() helper methods

string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


// Retrieve all instances of substrings inside parentheses

string message = "(What if) there are (more than) one (set of parentheses)?";

while(true){
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    message = message.Substring(closingPosition + 1);
}

//Work with different types of symbol sets


string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");


string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

char[] openSymbols = { '[', '{', '(' };

int closingPosition = 0;

while (true){
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    char matchingSymbol = ' ';

    switch(currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;    
    }

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}

// Exercise - Use the Remove() and Replace() methods

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

//Use the Replace() method

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);

// Exercise - Complete a challenge to extract, replace, and remove data from an input string

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

string openDiv = "<div>";
int openDivLength = openDiv.Length;
int openDivIndex = input.IndexOf(openDiv);

string closeDiv = "</div>";
int closeDivLength = closeDiv.Length - 1;
int closeDivIndex = input.IndexOf(closeDiv);

output = input.Substring(openDivIndex +  openDivLength, closeDivIndex - closeDivLength);
output = output.Replace("trade", "reg");

string openSpan = "<span>";
int openSpanLength = openSpan.Length;
int startPosition = input.IndexOf(openSpan) + openSpanLength;

string closeSpan = "</span>";
int closeSpanLength = closeSpan.Length;
int endPosition = input.IndexOf(closeSpan) - startPosition;


quantity = $"Quantity: {input.Substring(startPosition, endPosition)}";
output = $"Output: {output}";

Console.WriteLine(quantity);
Console.WriteLine(output);

// dotnet new console -o ./ProjectName