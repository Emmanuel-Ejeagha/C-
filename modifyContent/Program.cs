string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf("(");
int closingPosition = message.IndexOf(")");

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

openingPosition += 1;

length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

message = "What is the value <span>between the tags</span>?";

openingPosition = message.IndexOf("<span>");
closingPosition = message.IndexOf("</span>");

openingPosition += 6;
length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

const string openSpan1 = "<span>";
const string closeSpan1 = "</span>";

openingPosition = message.IndexOf(openSpan1);
closingPosition = message.IndexOf(closeSpan1);

openingPosition += openSpan1.Length;
length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

message = "hello there!";

int first_h = message.IndexOf('h');
int last_h = message.LastIndexOf('h');

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    closingPosition = message.IndexOf(')');
    length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}

// indexOfAny()
message = "Hello, world!";
char[] charsToFind = { 'a', 'e', 'i' };

int index = message.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols1 = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

closingPosition = 0;

while (true)
{
    openingPosition = message.IndexOfAny(openSymbols1, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}

// Remove file
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

// Replace
message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string openSpan2 = "<span>";
const string closeSpan2 = "</span>";

int quantityStart = input.IndexOf(openSpan2) + openSpan2.Length; // + length of <span> so index at end of <span> tag
int quantityEnd = input.IndexOf(closeSpan2);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademaark symbol with the registered trademark symbole
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);

// Calculate the total purchase price
double total1 = 0;
double minimumSpend1 = 30.00;

double[] items1 = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts1 = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items1.Length; i++)
{
    total1 += GetDiscountedPrice(i);
}

total1 -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total1)}");

double GetDiscountedPrice(int itemIndex)
{
    return items1[itemIndex] * (1 - discounts1[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total1 >= minimumSpend1;
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}
