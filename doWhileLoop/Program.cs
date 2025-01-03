Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 20);
    System.Console.WriteLine(current);
} while (current != 7);

System.Console.WriteLine();
while (current >= 3)
{
    current = random.Next(1, 20);
    System.Console.WriteLine(current);
}
Console.WriteLine($"Last number: {current}");

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

// hero and monster game
int hero = 10;
int monster = 10;

Random dice = new Random();

do{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


// user input challenge
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
            validEntry = true;
        else
            Console.WriteLine("Your input is invalid, please try again.");
    }
} while (validEntry == false);

// capture user input in a string variable named readResult
int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);

// Project 1
string? readResult1;
string valueEntered = "";
int numValue = 0;
bool validNumber1 = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult1 = Console.ReadLine();
    if (readResult1 != null) 
    {
        valueEntered = readResult1;
    }

    validNumber1 = int.TryParse(valueEntered, out numValue);

    if (validNumber1 == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber1 = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber1 == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();

// Project 2
string? readResult2;
string roleName = "";
bool validEntry2 = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult2 = Console.ReadLine();
    if (readResult2 != null) 
    {
        roleName = readResult2.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry2 = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry2 == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();

// Project 3
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}

// Project 3
string[] myStrings1 = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount1 = myStrings.Length;

string myString1 = "";
int periodLocation1 = 0;

for (int i = 0; i < stringsCount1; i++)
{
    myString1 = myStrings1[i];
    periodLocation1 = myString1.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation1 != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString1.Remove(periodLocation1);

        // the remainder of myString is the string value to the right of the location
        myString1 = myString1.Substring(periodLocation1 + 1);

        // remove any leading white-space from myString
        myString = myString1.TrimStart();

        // update the comma location and increment the counter
        periodLocation1 = myString1.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString1.Trim();
    Console.WriteLine(mySentence);
}