string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[1] = "R433";

Console.WriteLine(fraudulentOrderIDs[1]);

int[] myOrderIDs = {2000, 5000, 40, 60};

Console.WriteLine(myOrderIDs);
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudlent orders to process.");
Console.WriteLine($"There are {myOrderIDs.Length} fraudlent orders to process.");

string[] names = {"Emmy", "Jay", "Peri", "Sam"};
foreach (string name in names)
{
    Console.WriteLine("My name is " + name);
}

int[] inventory = {200, 800, 459, 764};
int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"\nWe have {sum} items in inventory.");

// StartWith
string[] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string item in orderIDs)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine(item);
    }
}