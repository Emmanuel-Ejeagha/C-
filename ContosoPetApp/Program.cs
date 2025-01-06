using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

// This projects stores the data of pets available for sale or hire

// The pets array will store the following:
string animalID = "";
string animalSpecies = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// vari9ables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m;

//  array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 7];

// create some initial ourAnimal array entries 4
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog" ;
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription= "loves to have her belly rubbed and likes to chase her tail. gives a lot of kisses.";
            animalNickname = "spike";
            suggestedDonation = "85.00";

            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "2";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time!loves to lean-in and dive doggy hugs.";
            animalNickname = "loki";
            suggestedDonation = "85.00";
            break;
        
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            suggestedDonation = "85.00";
            break;
        
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "85.00";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "85.00";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age" + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description:" + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality" + animalPersonalityDescription;
    ourAnimals[i, 6] = "Suggested Donation: "  + suggestedDonation;

    if (!decimal.TryParse(suggestedDonation, out decimalDonation)){
        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
        }
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
}
//  5
do
{
    // display the top-level menu options

    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal ages and physical descriptions are complete");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal's age");
    Console.WriteLine(" 6. Edit animal personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
        /* Note: We could put a do statement around the menuSelection entry to ensure a valid entry,
            but we use a conditional statement below that only process the valid entry values,
            so the do statement is not required here. 
        */
    }

    // use the switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (int i  = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            // Display all dogs with a specified characteristic
            string dogCharacteristic = "";

            while (dogCharacteristic == "")
            {
                // have the user enter physical characteristics to search for
                Console.WriteLine($"\nEnter one desired dog characteristics to search for");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    dogCharacteristic = readResult.ToLower().Trim();
                }
            } 
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            bool noMatchesDog = true;
            // #6 loop through the ourAnimals array to search for matching animals
            string dogDescription = "";
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 1].Contains("dog"))
                {
                    // #7 Search combined descriptions and report results
                    dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
                    if (dogDescription.Contains(dogCharacteristic))
                    {
                        Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");
                        Console.WriteLine(dogDescription);

                        noMatchesDog = false;
                    }
                }
            }
            break;
        
        case "2":
            // Add a new animal friend to the ourAnimal array
            string anotherPet = "y";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                bool validEntry = false;

                //  get species (cat or dog) - string animalSpecies is a required field
                do
                {
                    if (noMatchesDog)
                    {
                        Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
                    }
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            // Console.WriteLine($"You entered: {animalSpecial}.")
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // get the pet's age. can be ? at the initial entry.
                do
                {
                    int petAge;
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else 
                        {
                            validEntry = true;
                        }
                    }
                    
                } while (validEntry == false);

                // get a description of the pet's physical apperance/condition - animalPhysicalDesccription can be blank
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");

                // get a description of the pet's personality - animalPersonalityDescription can be blank
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");
                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");

                // store the pet information  in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age" + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description:" + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality" + animalPersonalityDescription;

                // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                petCount = petCount + 1;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }
                    } while (anotherPet != "y" && anotherPet != "n");
                }    
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter kry to continue.");
                readResult = Console.ReadLine();
            }
            break;
        
        case "3":
            // Ensure animal ages and physical descriptions are complete
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        
        case "4":
            // Ensure animal nicknames and personality descriptions are complete
            Console.WriteLine("Challenge Project - please check soon to see the progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console. ReadLine();
            break;

        case "5":
            // Edit an animal's age
            Console.WriteLine("UNDER CONSTRUCTION - please check bsck next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            // Edit an animal's age
            Console.WriteLine("UNDER CONSTRUCTION - please check bsck next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        
        case "7":
            // Edit an animal's age
            Console.WriteLine("UNDER CONSTRUCTION - please check bsck next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        
        case "8":
            // Edit an animal's age
            Console.WriteLine("UNDER CONSTRUCTION - please check bsck next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }
} while (menuSelection != "exit");