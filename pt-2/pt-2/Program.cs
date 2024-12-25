// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Formats.Asn1;

Console.Write("Enter the first number: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int numB = Convert.ToInt32(Console.ReadLine());

int answer = numA * numB;
int actualAnswer = 0;

do
{
    Console.Write("Enter your answer: ");
    actualAnswer = Convert.ToInt32(Console.ReadLine());

    if (answer != actualAnswer)
    {
        Console.WriteLine("Close but it was wrong!");

    }
} while (answer != actualAnswer);
    Console.WriteLine("Well done!");

// conditional operator
Console.WriteLine("Enter a number, positive or negative: ");
int age = Convert.ToInt32(Console.ReadLine());
string result = age >= 0 ? "Positive!" : "Negative!";
Console.WriteLine(result);

// Numeric Formating
double value = 1000D / 12.34D;
Console.WriteLine(value);
Console.WriteLine(string.Format("{0} {1}", value, "Money"));
Console.WriteLine(string.Format("{0:0}", value));
Console.WriteLine(string.Format("{0:0.0}", value));
Console.WriteLine(string.Format("{0:0.#}", value));
Console.WriteLine(string.Format("{0:0.00}", value));

Console.WriteLine("Enter your first number: ");
double num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your second number");
double num2 = Convert.ToInt32(Console.ReadLine());

double money1 = num1 / num2;
double money2 = num1 / num2;
Console.WriteLine(string.Format("${0:0.00}", money1));
Console.WriteLine(string.Format("£{0:0.00}", money2));
Console.WriteLine(money1.ToString("C"));
Console.WriteLine(money2.ToString("C"));

