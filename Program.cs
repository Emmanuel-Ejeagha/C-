// See https://aka.ms/new-console-template for more information
using System.Diagnostics;


Console.WriteLine("Hello, World!");
Console.WriteLine("My name is emmanuel");

int age = 30;
Console.WriteLine(age);
Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue);

long BigNum = 89099960L;
Console.WriteLine(BigNum);
Console.WriteLine(long.MaxValue);
Console.WriteLine(long.MinValue);

float precision = 5.000200F;
Console.WriteLine(precision);
Console.WriteLine(float.MaxValue);
Console.WriteLine(float.MinValue);

double num1 = 65.87D;
Console.WriteLine(num1);
Console.WriteLine(double.MaxValue);
Console.WriteLine(double.MinValue);

decimal money = 14.99M;
Console.WriteLine(money);
Console.WriteLine(decimal.MaxValue);
Console.WriteLine(decimal.MinValue);

// int x;
// int y;
// int z;
// or
int x = 40,
    y = 39,
    z = 80;
Console.WriteLine(x + y + z);
y = 40;
Console.WriteLine(y);
// Console.ReadLine();

// TEXT BASED DATATYPES
string name = "Emmy";
char letter = 'a';
Console.WriteLine(letter);
Console.WriteLine(name);

Console.Write("Your name is ");
Console.Write(name);
Console.WriteLine();
Console.WriteLine(letter);

// CONVERTING STRINGS TO NUMBERS
string textAge = "-23";
int newAge = Convert.ToInt32(textAge);
Console.WriteLine(newAge);

string myBigNum = "006673838";
long bigNum = Convert.ToInt64(myBigNum);
Console.WriteLine(bigNum);

string negetiveNum = "-093.983";
double negative = Convert.ToDouble(negetiveNum);
Console.WriteLine(negative);

string precisionNum = "584.90";
float precison = Convert.ToSingle(precisionNum);
Console.WriteLine(precison);

string myDollar = "14.999";
decimal dollar = Convert.ToDecimal(myDollar);
Console.WriteLine(dollar);

// Boolean Datatype
bool value = true;
bool isFemale = false;

Console.WriteLine(isFemale);
Console.WriteLine(value);

// operators
int myAge = 23;
myAge++;
Console.WriteLine(myAge);

myAge--;
Console.WriteLine(myAge);

newAge = 30;
newAge += 10;
Console.WriteLine(newAge);
newAge -= 200;
Console.WriteLine(newAge);

string myName = "Emma";
myName += " is programming";
Console.WriteLine(myName);

char ch = 'a';
ch += 'c';
Console.WriteLine(ch);

int i = 0;
Console.WriteLine(++i);
Console.WriteLine(i);

// Reminder
int firstNum = 10;
int secondNum = 3;
Console.WriteLine(firstNum / secondNum);
Console.WriteLine(firstNum % secondNum);

// var keyword
var username = "Emmanuel";
var worth = 4000D;
var funds = 200.34;

System.Console.WriteLine(username);
System.Console.WriteLine(worth);
System.Console.WriteLine(funds);

// const keyword
const int vat = 20;
const double percentVAT = vat / 100D;
int balance = 10027;

Console.WriteLine(balance * percentVAT);
Console.WriteLine(vat);

//  Console I/O
Console.WriteLine("Hello my name is Emmanuel");
Console.Write("Enter your name: "); 
string uName = Console.ReadLine();

Console.Write("Enter your age: ");
string ageInput = Console.ReadLine();
int uAge = Convert.ToInt32(ageInput);



Console.WriteLine("Your name is " + uName + " you are " + uAge + " years old");
System.Console.WriteLine(   );
Console.WriteLine("Your name is {0} you are {1} years old", uName, uAge );

// if statement
if (uAge >= 18 && uAge <= 120)
{
    Console.WriteLine("You are elegible to vote");
} 
else if (uAge < 18 && uAge > 0)
{
    Console.WriteLine("You are not elegible to vote!");
}
else if (uAge > 120 || uAge <= 0)
{
    Console.WriteLine("Invalid age!");
}


if (uAge < 0 || uAge > 150)
{
    Console.WriteLine("Invalid age!");
}
else
{
    if (uAge >= 18 && uAge <= 25)
    {
        Console.WriteLine("You are between 18 and 25");
    }
    else if (uAge >= 26)
    {
        Console.WriteLine("You are 26 or older");
    }
}

Console.Write("Enter the first number: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int numB = Convert.ToInt32(Console.ReadLine());

int ans = numA * numB;

Console.WriteLine("Value of "+ numA + " x " + numB + ": ");
int actualAns = Convert.ToInt32(Console.ReadLine());

if (ans == actualAns)
{
    Console.WriteLine("Well done!");
}
else if (ans != actualAns)
{
    Console.WriteLine("Close but it was wrong!");
}

// Switch statement
Console.Write("Enter a day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1: Console.WriteLine("Monday"); 
        break;
    case 2: Console.WriteLine("Tuesday");
        break;
    case 3: Console.WriteLine("Wednesday");
        break;
    case 4: Console.WriteLine("Thursday");
        break;
    case 5: Console.WriteLine("Friday");
        break;
    case 6: Console.WriteLine("Saturday");
        break;
    case 7: Console.WriteLine("Sunday");
        break;

    default: Console.WriteLine("Invalid number! Enter a value between 1 and 7");
        break; 
}

// FOR LOOP
for (int a = 0; a < 10; a++)
{
    Console.WriteLine(a);
}

for (int w = 1; w < 11; w+=2)
{
    Console.WriteLine(w);
}

// seconnd eg
System.Console.WriteLine("What do you want to repeat?: ");
string msg = Console.ReadLine();

System.Console.WriteLine("How many times do you want to say hello?");
int counter = Convert.ToInt32(Console.ReadLine());

if (counter <= 0)
{
    Console.WriteLine(" Sorry, please enter a value above 0");
}
else 
{
    for (int b = 0; b <= counter; b++)
    {
        System.Console.WriteLine(msg);
    }
}

// While Loop
int ab = 0;
while (ab < 10)
{
    System.Console.WriteLine(ab);
}

// Console.ReadLine()