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

// FORMATTING CURRENCY (:C)
decimal price = 198.56986m;
int discount = 50;

Console.WriteLine($"Price: {price:C} (save {discount:C})");

// FORMATING NUMBERS (:N)
decimal measurement = 1233244449.4899920m;
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N3} units");

// Formating Percentages
decimal tax = .36789m;
Console.WriteLine($"Tax rate: {tax:P2}");

price = 87.767m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount = $"A discount of {((price - salePrice)/price):P2}!";
Console.WriteLine(yourDiscount);

// string interpolation
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

// padding
string input = "Pad this";
Console.WriteLine(input.PadLeft(10));
Console.WriteLine(input.PadLeft(12, '*'));
Console.WriteLine(input.PadRight(12, '-'));

string paymentID = "769C";

var formattedLine = paymentID.PadLeft(6);

Console.WriteLine(formattedLine);

// Add the payee name to the output
paymentID = "R645";
string payeeName = "Mr. Christopher Colombus";
string paymentAmt = "$5,000.00";

var formattedLine1 = paymentID.PadRight(6);
formattedLine1 += payeeName.PadRight(24);
formattedLine1 += paymentAmt.PadLeft(15);

Console.WriteLine("\n11234550987654321234566543223457654323456777767543");
Console.WriteLine(formattedLine1);

// Complete a challenge to apply string interpolation to a form letter
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;
string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
Console.WriteLine(comparisonMessage);

comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
Console.WriteLine(comparisonMessage);

comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);
Console.WriteLine(comparisonMessage);

