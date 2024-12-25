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
