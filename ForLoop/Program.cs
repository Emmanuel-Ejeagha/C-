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

for