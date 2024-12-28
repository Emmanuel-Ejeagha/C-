// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Formats.Asn1;
using System.Globalization;

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

Console.WriteLine(money2.ToString("C", CultureInfo.CurrentCulture));


Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

Console.WriteLine(@"    c:\source\repos
        (this is where your code goes)");
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// string projectName = "ACME";

// string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
// Console.WriteLine("\n" + projectName + "\n");
// Console.WriteLine(russianMessage);

string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// In math, PEMDAS is an acronym that helps students remember the order of operations. The order is:

// Parentheses (whatever is inside the parenthesis is performed first)
// Exponents
// Multiplication and Division (from left to right)
// Addition and Subtraction (from left to right)

// Calculating a degree celcius
int fahrenheit = 94;
decimal result1 = (fahrenheit - 32m) * (5m/9m);

Console.WriteLine($"The temperature {result1} Celsius.");

// GPA Calculator
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

int leadingDigit = (int) gradePointAverage;
int firstDigit = (int) (gradePointAverage * 10 ) % 10;
int secondDigit = (int) (gradePointAverage * 100 ) % 10;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");
