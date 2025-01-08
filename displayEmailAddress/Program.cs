// DisplayEmail converter

string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Emmanuel", "Ejeagha"},
    {"Mary", "Kay"}, {"Mercy", "Kyrian"},
};

string[,] external =
{
    {"Vivian", "Bay"}, {"Clien", "Steel"},
    {"Steve", "Graham"}, {"Salow", "Klin"} 
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);

}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
}

void DisplayEmail(string first, string last, string domain = "contoso.com")
{
    string email = first.Substring(0, 2) + last;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}