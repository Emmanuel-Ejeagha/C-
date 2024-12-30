Random dice = new Random();
int roll001 = dice.Next();
int roll002 = dice.Next(101);
int roll003 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll001}");
Console.WriteLine($"Second roll: {roll002}");
Console.WriteLine($"Third roll: {roll003}");

int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);

// Roll a dice
Random dice1 = new Random();

int roll01 = dice1.Next(1, 7);
int roll02 = dice1.Next(1, 7);
int roll03 = dice1.Next(1, 7);

int total = roll01 + roll02 + roll03;

Console.WriteLine($"Dice roll: {roll01} + {roll02} + {roll03} = {total}");

if ((roll01 == roll02) || (roll02 == roll03) || (roll01 == roll03))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total");
    total += 2;
}
if ((roll01 == roll02) && (roll02 == roll03))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}
if (total >= 15)
{
    Console.WriteLine("You win!");
}
else 
{
    Console.WriteLine("Sorry, you lose.");
}

// boolean
string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}
Console.WriteLine("\n");

// Nexted if statement
Random dice2 = new Random();

int roll1 = dice2.Next(1, 7);
int roll2 = dice2.Next(1, 7);
int roll3 = dice2.Next(1, 7);

int total1 = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3));
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total1 += 6; 
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total1 += 2;
    }
}

if (total1 >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}


// if, else, else if stateents
Random dice3 = new Random();

int roll11 = dice3.Next(1, 7);
int roll22 = dice3.Next(1, 7);
int roll33 = dice3.Next(1, 7);

int total01 = roll11 + roll22 + roll33;

Console.WriteLine($"Dice roll: {roll11} + {roll22} + {roll33} = {total}");

if ((roll11 == roll22) || (roll22 == roll33) || (roll11 == roll33))
{
    if ((roll11 == roll22) && (roll22 == roll33))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total01 += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total01 += 2;
    }
    Console.WriteLine($"Your total including the bonus: {total01}");
}
if (total01 >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total01 >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total01 == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}