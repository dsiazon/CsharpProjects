
Random random = new Random();
int current = random.Next(1, 11);


do{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);

} while (current != 7);


while (current >= 3){
    Console.WriteLine(current);
    current = random.Next(1,11);
}
Console.WriteLine($"Last number: {current}");


Random random = new Random();
int myAttack = random.Next(1,11);
int monsterAttack = random.Next(1,11);
int myHealth = 10;
int monsterHealth = 10;

do {

    myAttack = random.Next(1,11);
    monsterHealth -= myAttack;
    Console.WriteLine($" Monster was damaged and lost {myAttack} and now has {monsterHealth}");

    monsterAttack = random.Next(1,11);
    myHealth -= monsterAttack;
    Console.WriteLine($" Hero was damaged and lost {monsterAttack} and now has {myHealth}");

    if(monsterHealth <= 0)
        continue;

} while (monsterHealth > 0 && myHealth > 0);

Console.WriteLine(myHealth > monsterHealth ? "Hero wins!" : "Monster wins!");




string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);



string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);

// capture user input in a string variable named readResult

int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);



// PROJECT 1
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;
Console.WriteLine("Enter a number between 5 and 10:");

do{
    readResult = Console.ReadLine();

    if (readResult != null) 
    {
        valueEntered = readResult;
    }

       validNumber = int.TryParse(valueEntered, out numValue);

    if(validNumber == true){
        if(numValue <= 5 || numValue >= 10){
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }else{
            Console.WriteLine($"Your input value {numValue} has been accepted.");
        }
    }
} while (validNumber == false);

// PROJECT 2
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter your role name: Administrator, Manager, or User");

do{
    readResult = Console.ReadLine();
    if(readResult.Trim().ToLower() == "administrator" || readResult.Trim().ToLower() == "manager" || readResult.Trim().ToLower() == "user"){
        validEntry = true;
        Console.WriteLine($"Your input value {readResult} has been accepted.");
    }else{
        Console.WriteLine($"The role name that you entered, {readResult} is not valid. Enter your role name (Administrator, Manager, or User)");
    }

} while (validEntry = false);


// PROJECT 3

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString ="";
int periodLocation = 0;


for(int i = 0; i < stringsCount; i++){
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while(periodLocation != -1){

        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1);

        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}

