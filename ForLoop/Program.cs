for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine(i);
}

System.Console.WriteLine();

for (int i = 10; i >= 0; i--)
{
    System.Console.WriteLine(i);
}

System.Console.WriteLine();
for (int i = 0; i < 10; i += 2)
{
    System.Console.WriteLine(i);
}

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
    if (i  == 5)
        break;
}

string[] names = {"Mary", "Mark", "Gino", "Sam", "Mercy"};
for (int i = names.Length - 1; i >= 0; i--)
{
    System.Console.WriteLine(names[i]);
}

for (int i = 0; i < names.Length; i++)
    if (names[i] == "Sam") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);
System.Console.WriteLine("\n\n");
// FIZZBUZZ
for (int x = 1; x < 101; x++)
{
    if ((x % 3 == 0) && (x % 5 == 0))
        Console.WriteLine("FizzBuzz");
    else if (x % 5 == 0)
        System.Console.WriteLine("Buzz");
    else if (x % 3 == 0)
        System.Console.WriteLine("Fizz");
    else
        System.Console.WriteLine(x);
}