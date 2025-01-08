// Contoso Petting Zoo
// A program to organize petting zoo animals into groups for school visits.

using System; // Importing System namespace for basic input/output operations

// Array of animals available in the petting zoo
string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

// Plan visits for different schools with specified or default group numbers
PlanSchoolVisit("School A");               // Default 6 groups
PlanSchoolVisit("School B", 3);            // 3 groups
PlanSchoolVisit("School C", 2);            // 2 groups

// Function to plan a school visit
void PlanSchoolVisit(string schoolName, int groups = 6) 
{
    RandomizeAnimals(); // Shuffle the animals in random order
    string[,] group1 = AssignGroup(groups); // Assign animals to groups
    Console.WriteLine(schoolName);          // Print the school name
    PrintGroup(group1);                     // Print groups and their animals
}

// Function to randomize the order of animals in the petting zoo
void RandomizeAnimals() 
{
    Random random = new Random(); // Initialize random number generator

    // Shuffle animals using Fisher-Yates algorithm
    for (int i = 0; i < pettingZoo.Length; i++) 
    {
        int r = random.Next(i, pettingZoo.Length); // Generate a random index

        // Swap current animal with randomly chosen one
        string temp = pettingZoo[r];
        pettingZoo[r] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

// Function to assign animals into specified number of groups
string[,] AssignGroup(int groups = 6) 
{
    // Create a 2D array to store animal groups
    string[,] result = new string[groups, pettingZoo.Length/groups];
    int start = 0; // Index to track current animal

    // Loop through groups and assign animals
    for (int i = 0; i < groups; i++) 
    {
        for (int j = 0; j < result.GetLength(1); j++) 
        {
            result[i,j] = pettingZoo[start++]; // Assign animal to group
        }
    }

    return result; // Return the grouped animals
}

// Function to print the groups and their animals
void PrintGroup(string[,] groups) 
{
    // Loop through each group
    for (int i = 0; i < groups.GetLength(0); i++) 
    {
        Console.Write($"Group {i + 1}: "); // Print group number
        for (int j = 0; j < groups.GetLength(1); j++) 
        {
            Console.Write($"{groups[i,j]}  "); // Print animals in the group
        }
        Console.WriteLine(); // Move to the next line
    }
}
