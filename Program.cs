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
// Console.ReadLine();