string[] pallets = [ "B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted.....");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Array.Clear(pallets, 0, 1);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine();
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C01";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Use the ToCharArray() to reverse a string
string value = "abc123";
char[] valueArray = value.ToCharArray();
Console.WriteLine(valueArray);
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);
string result1 = string.Join(",", valueArray);
Console.WriteLine(result1);
string[] items = result1.Split(",");
foreach (string item in items)
{
    Console.WriteLine(item);
}

string pangram = "The quick brown fox jumps over the lazy dog";
Console.WriteLine(pangram);
char[] pangramArray = pangram.ToCharArray();
Array.Reverse(pangramArray);
string result2 = new string(pangramArray);
Console.WriteLine(result2);

//  reverse words in a sentence challenge
// Step 1
string[] message = pangram.Split(' ');

// step 2
string[] newMessage = new string[message.Length];
// Console.WriteLine($" Step 2...... {newMessage}");

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result4 = string.Join(" ", newMessage);
Console.WriteLine(result4);

// 1. Create a string array to split the string
// 2. Create a string array to store the length of the array
// 3. Create a foreach loop 
// 4. check if the length of array[0] is less than 4
// 5. print the result

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderID = orderStream.Split(',');
Array.Sort(orderID);

foreach (var item in orderID)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
        Console.WriteLine($"{item} \t- Error");
}

//  STRING FORMATTING
string first = "Hello";
string second = "World";
string result3 = string.Format("{0} {1}!", first, second);
Console.WriteLine(result3);

Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

// FORMATTING CURRENCY
decimal price = 198.56986m;
int discount = 50;

Console.WriteLine($"Price: {price:C} (save {discount:C})");