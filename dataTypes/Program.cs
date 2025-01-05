using System.Globalization;

// signed
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
Console.WriteLine("");

// unsigned

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine("Unsigned integral types:");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
Console.WriteLine("");

// Floating point types
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// reference type variable
int[] data;
data = new int[3];

// Value Type
int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");

// Reference type Reference types include arrays, strings, and classes.
int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");

// Casting and conversion
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

// narrowing conversion
myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");

int first0 = 5;
int second0 = 7;
string msg = first.ToString() + second.ToString();
Console.WriteLine(msg);

string first1 = "5";
string second1 = "7";
int sum = int.Parse(first1) + int.Parse(second1);
Console.WriteLine(sum);

string value1 = "5";
string value2 = "7";
int result0 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result0);

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value0 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value0);

// TryParse()
string value3 = "102";
int result01 = 0;
if (int.TryParse(value3, out result01))
{
    Console.WriteLine($"Mearsurement: {result01}");
}
else
{
    Console.WriteLine("Unable to convert");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result01}");

string value01 = "bad";
int result02 = 0;
if (int.TryParse(value01, out result02))
{
   Console.WriteLine($"Measurement: {result02}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result02 > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result02}");


// Converting array
string[] values = { "12.3", "45", "ABC", "11", "DEF"};

decimal total = 0m;
string message0 = "";

foreach (var value11 in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value11, out number))
    {
        total += number;
    } else
    {
        message0 += value11;
    }
}

Console.WriteLine($"Message: {message0}");
Console.WriteLine($"Total: {total}");

// convertion challenge
int value001 = 11;
decimal value002 = 6.2m;
float value003 = 4.3f;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
int result1 = Convert.ToInt32(value001 / value002);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value002 / (decimal)value003;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value003 / value001;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");