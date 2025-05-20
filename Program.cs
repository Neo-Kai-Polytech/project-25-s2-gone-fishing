namespace UberProject
{
    public struct Enemies()
    {
        string enemyName;
        int enemyHP;
        int enemyAttack;
        string enemyType;
        string enemyDesc;
    }
    public struct Weapons()
    {
        string weaponName;
        int weaponDamage;
        string weaponType;
    }
    public struct Ingredients()
    {
        string ingredientName;
    }
    public struct Consumables()
    {
        string itemName;
        int itemDamage;
        string itemType;
        int itemHeal;
        string itemDesc;

    }
    public struct Recipes()
    {
        string recipeName;
    }

    internal class Program
    {
        private static Random random = new Random();
        private static int Task;
        public static string charName, cookbook = "";
        static string[] inventory = ["", "", "", "", "", "", "", "", "", ""]; //Inventory of 10 slots, all same empty value to check if slots are empty


        static void Welcome()
        {
            Console.WriteLine("FLAVOURS OF FALLOUT");
            Console.WriteLine();
            Console.WriteLine("The Menu options are:");
            Console.WriteLine("1  New Game");
            Console.WriteLine("2  Options");
            Console.WriteLine("3  Collection");
            Console.WriteLine("0  Exit menu system");
            Console.WriteLine();
        }

        static void Task1()
        {
            // NEW GAME CREATION --> Lead to Start of Story and Character Creation

            StoryLineSum();

        }

        static void StoryLineSum()
        {

            // Main story line

            // Print to Screen Main Story Summary


            Console.WriteLine("So the story starts with World War III Apocalypse where all countries were on war. Lost of lives were lost, families got ruined. " +
                "Not only damage is done to the humans, nature also paid the price animal species got extinct, air pollution went to the next level." +
                "In the war many communities were lost, world population got half, darkness is now spreading every corner of the world." +
                "People praying to the God to restore the balance of the world and some still have belief someone will a messiah will come and everything will come back to original.");

            Console.WriteLine("Press any key to know about the main character");
            Console.ReadLine();


            // Lead to Character Creation
            CharacterCreation();


        }

        public static void CharacterCreation()

        {
            // List Character Options??
            string charName;

            //char name

            Console.WriteLine("Enter the name of the character.");
            charName = Console.ReadLine();
            //char background

            Console.WriteLine($"{charName} belongs to a small village born and brought up in a big family. His mother was a housekeeper and father was the army chief. " +
                $"His all family is very patriotic and kind. Follwing his father's footsteps he also wanted to become a army officer. " +
                $"He also liked cooking which came from his mother and wanted to use this side talent in his life. So he wanted to become a army chef." +
                "Eventually, after working hard he accomplished his goal and started serving in the army.");
            Thread.Sleep(500);
            Console.WriteLine($"Two Years Later.........\nRussia Bombed America and World War III started and whole world was on fire and people were starving. " +
                $"In the attack on citizens {charName} lost his family, lost all of his friends fighting on the border.He himself got injured badly and was in hospital getting treated." +
                "Suddenly, something went bad and he went into a coma.");
            Thread.Sleep(500);
            Console.WriteLine("He woke up after six months and remembered things which happened. After getting out from the hospital he had no purpose left in his life, fully depressed, no family and friends. But he had no idea that nature has planned something big for him.");
            Thread.Sleep(500);
            Console.WriteLine($"After some days, while {charName} was still trying to figure out the purpose of his life, One night he got a dream where he was sitting on the dining table with his mom and dad talking about stuff happened recently" +
                "and there his parents told him to follow his passion of cooking and serving people in order to make something out of his life.");
            Thread.Sleep(500);
            Console.WriteLine("After this night he decided to go on a world journey with passion to help people and to get some new experiences.");
            Thread.Sleep(500);
            Console.ReadLine();
            //start of the game

            Console.Clear();

            StartingArea(charName);

        }

        public static void StartingArea(string charName)
        {

            event1(charName);

            event2(charName);

            event3(charName);

            event4(charName);



        }

    
        static void event1(string charName)
        {
            Console.WriteLine("Continuing his journey now he reached Russia where he saw that everything is destroyed. " +
                "He is findind any life which is still alive and can talk with them. He is in a dense forest right now.");
            Thread.Sleep(500);
            Console.WriteLine("You see a bear running towards you!");
            Console.WriteLine("Prepare yourself!\n\n");


            string enemyName = "Bear";
            CombatSystem(enemyName, charName);

            event2(charName);

        }

        static void event2(string charName)
        {

            Console.WriteLine("After this he observed the cooking method of the villagers which was slightly different and want to talk with them regarding that." +
                "While chatting he got to know some new dishes which includes russian steak etc.");
            Thread.Sleep(500);
            //here some things 2 or 3 ingredients will get added in the inventory

            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "Bread";
                    break;
                }
            }
            Console.WriteLine("Press any button to cook new dish");
            Console.ReadLine();
            InventoryManage();

            Console.ReadLine();
            //end of event and he continues his journey
        }

        static void event3(string charName)
        {
            Console.WriteLine("This is event 3");
            Console.ReadLine();
        }

        // event 4 will come here
        static void event4(string charName)
        {
            Console.WriteLine("This is event 4");
            Console.ReadLine();
        }
  
        public static void CombatSystem(string enemyName, string charName)
        {
            int playerHP = 100;
            int enemyHP = random.Next(30, 40);

            int playerAttack = 0;
            int enemyAttack = 0;

            do
            {
                Console.Clear();
                Console.Write("Name".PadRight(15));
                Console.Write("Name".PadLeft(15));
                Console.WriteLine();
                Console.Write(charName.PadRight(15));
                Console.Write(enemyName.PadLeft(15));
                Console.WriteLine();
                Console.WriteLine("VS".PadLeft(15));
                Console.Write("Health:".PadRight(15));
                Console.Write("Health:".PadLeft(15));
                Console.WriteLine();
                Console.Write(playerHP.ToString().PadRight(15));
                Console.Write(enemyHP.ToString().PadLeft(15));

                Console.WriteLine();
                Console.WriteLine("What would you like to do?");

                string playerInput = Console.ReadLine();

                playerAttack = random.Next(5, 15);
                Console.WriteLine($"\nPlayer attacks dealing {playerAttack} damage! \n");
                enemyHP = enemyHP - playerAttack;
                Thread.Sleep(1000);

                enemyAttack = random.Next(1, 6);
                Console.WriteLine($"\n{enemyName} attacks dealing {enemyAttack} damage! \n");
                playerHP = playerHP - enemyAttack;
                Thread.Sleep(1000);


            } while (enemyHP > 0);

            Console.ReadLine();

        }

        static void EpicLoot()
        {
            // This will be an Array of Loot that you can randomly acquire through different events and fights.

            string[] weapons;
            string[] ingredients;
            string[] recipes;
            string[] potions;
            string[] explosives;

        }

        public static string HostileEnemies()
        {
            string[] monsterNames = new string[]
            {
                "Radroach",             // Giant, irradiated cockroach with acidic saliva and armored carapace.
                "Mutant Hound",         // Once a domestic dog, now a grotesque, hairless predator with enhanced senses and aggression.
                "Ash Crawler",          // A pale, skeletal creature that burrows through radioactive ash, ambushing prey from below.
                "Ghoul Reaper",         // A sentient, decaying humanoid that hunts the living for flesh, often in packs.
                "Wasteland Abomination",// A massive fusion of flesh and machinery, created from failed experiments and scavenged tech.
                "Irradiated Behemoth",  // Towering brute pulsing with nuclear energy, leaving scorched earth in its wake.
                "Scorched Stalker",     // Burn-scarred humanoid with smoldering skin, capable of setting traps and ambushes.
                "Toxic Spitter",        // A bloated mutant that expels corrosive bile from a distended jaw.
                "Bone Dragger",         // Lurks in the shadows, dragging scavenged bones across the ground to lure victims.
                "Nuke Leech"            // A glowing, slug-like parasite that feeds on radiation and attaches to living hosts.
            };


            int enemyNumber = random.Next(monsterNames.Length);

            string enemyName = monsterNames[enemyNumber].ToString();

            return enemyName;


        }


        static void Task2()
        {
            // OPTIONS MENU

            Console.WriteLine("This is Task 2");
            Console.WriteLine("Press any key to return to menu");
            Console.ReadLine();

        }
        static void Task3()
        {
            // Collection of Things
            string userInput;

            do
            {

                Console.WriteLine("Welcome to the collection of things in our game");
                Console.WriteLine("The Menu options are:");
                Console.WriteLine("1  Monsters");
                Console.WriteLine("2  Weapons");
                Console.WriteLine("3  Ingredients");
                Console.WriteLine("4  Consumables");
                Console.WriteLine("5  Recipes");
                Console.WriteLine();
                Console.WriteLine("0  Exit menu system");

                Console.WriteLine();
                Console.WriteLine("Please choose an option");
                userInput = Console.ReadLine();
                

                Console.Clear();

                switch (userInput)

                {
                    case "1":
                        Task1();
                        break;

                    case "2":
                        Task2();
                        break;

                    case "3":
                        Task3();
                        break;

                    case "4":
                        Exit();
                        break;

                    case "5":
                        Exit();
                        break;

                    case "6":
                        Exit();
                        break;

                    case "0":
                        Exit();
                        break;

                    default:
                        InvalidInput();
                        break;

                }




            } while (userInput != "0");

            Console.WriteLine("Press any key to return to menu");
            Console.ReadLine();

        }

        static void Exit()
        {
            Console.WriteLine("This is the exit");
            Console.WriteLine("Press any key to close program");
        }

        static void InvalidInput()
        {
            Console.WriteLine("Invalid Input");
            Console.ReadLine();
        }

        static void InventoryManage()
        {
            int input;
            Console.Clear();
            do
            {
                Console.WriteLine("Hello. This is your inventory.\nPress 1 to cook ingredients\nPress 2 to read out your inventory\n\nPress 0 to close the program"); //Menu text
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    default:
                        InvalidInput();
                        break;
                    case 0: //Exit inventory
                        Console.WriteLine("Exiting inventory now");
                        break;
                    case 1: //Scavenges for ingredients and puts it in an empty slot in your inventory
                        Cooking();
                        break;
                    case 2: //Shows you your inventory
                        Console.WriteLine("Inventory:");
                        for (int i = 0; i < inventory.Length; i++)
                        {
                            Console.WriteLine(inventory[i]);
                        }
                        Console.WriteLine("-- End of inventory. Press enter to go back to menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
                Console.Clear();
            } while (input != 0);
        }

        static void Cooking()
        {
            int input;
            Console.Clear();
            do
            {
                Console.WriteLine("You are now in the cooking menu. What would you like to do?\n1. Start cooking\n2. Read cookbook\n0. Go back to inventory");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    default:
                        InvalidInput();
                        break;
                    case 1:
                        Kitchen();
                        break;
                    case 2:
                        Console.WriteLine($"{cookbook}\n\n-- Press enter to go back");
                        Console.ReadLine();
                        break;
                    case 0:
                        break;
                }
                Console.Clear();
            } while (input != 0);
        }

        static void Kitchen()
        {
            int input;
            string ingredientSlot1, ingredientSlot2, ingredientSlot3;
            Console.Clear();
            do
            {
                Console.WriteLine("What tier recipie do you want to make?\n1. Tier 1 recipie\n2. Tier 2 recipie\n3. Tier 3 recipie\n\n0. Go back to cooking menu");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    default:
                        InvalidInput();
                        break;
                    case 1: //Cooking tier 1 recipies
                        Console.Clear();
                        Console.WriteLine("What ingredient would you like to use?");
                        ingredientSlot1 = Console.ReadLine().ToLower();
                        tierOne(ingredientSlot1);
                        break;
                    case 2: //Cooking tier 2 recipies
                        Console.Clear();
                        Console.WriteLine("What is the first ingredient you would like to use?");
                        ingredientSlot1 = Console.ReadLine().ToLower();
                        Console.WriteLine("What is the second ingredient you would like to use?");
                        ingredientSlot2 = Console.ReadLine().ToLower();
                        tierTwo(ingredientSlot1, ingredientSlot2);
                        break;
                    case 3: //Cooking tier 3 recipies
                        Console.Clear();
                        Console.WriteLine("What is the first ingredient you would like to use?");
                        ingredientSlot1 = Console.ReadLine().ToLower();
                        Console.WriteLine("What is the second ingredient you would like to use?");
                        ingredientSlot2 = Console.ReadLine().ToLower();
                        Console.WriteLine("What is the third ingredient you would like to use?");
                        ingredientSlot3 = Console.ReadLine().ToLower();
                        tierThree(ingredientSlot1, ingredientSlot2, ingredientSlot3);
                        break;
                    case 0:
                        break;
                }
                Console.Clear();
            } while (input != 0);


        }

        static void tierOne(string ingredient1)
        {
            //Toast
            if (ingredient1 == "bread")
            {
                for (int i = 0; i < inventory.Length; i++)
                {
                    if (inventory[i] == "Bread")
                    {
                        inventory[i] = "Toast";
                        Console.Write("You cooked Toast");
                        break;
                    }
                }
            }
            //Boiling Water
            else if (ingredient1 == "drinkable water")
            {
                for (int i = 0; i < inventory.Length; i++)
                {
                    if (inventory[i] == "Drinkable Water")
                    {
                        inventory[i] = "Boiling Water";
                        Console.WriteLine("You made Boiling Water");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("You don't know what to make with this!");
            }
            Console.ReadLine();
        }
        static void tierTwo(string ingredient1, string ingredient2)
        {

            //Salad
            if (ingredient1 == "lettuce" && ingredient2 == "lettuce") //Conditions
            {
                for (int i = 0; i < inventory.Length; i++)
                {
                    if (inventory[i] == "Lettuce") //First instance of ingredient
                    {
                        inventory[i] = "Salad"; //Change it to result
                        Console.WriteLine("You made Salad");

                        for (int j = 0; j < inventory.Length; j++) //Second instance of ingredient
                        {
                            if (inventory[j] == "Lettuce")
                            {
                                inventory[j] = ""; //Change it to nothing

                                break; //break out of each for loop so that it doesn't change all instances of lettuce (Sorry Krissi)
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("I don't know what to do with this!");
            }
            Console.ReadLine();
        }

        static void tierThree(string ingredient1, string ingredient2, string ingredient3)
        {
            if (ingredient1 == "bread" && ingredient2 == "lettuce" && ingredient3 == "bread")
            {
                for (int i = 0; i < inventory.Length; i++)
                { //Adds sandwich
                    if (inventory[i] == "Bread")
                    {
                        inventory[i] = "Basic Sandwich";
                        Console.WriteLine("You made a Basic Sandwich");
                        for (int j = 0; j < inventory.Length; j++) //Removes second ingredient
                        {
                            if (inventory[j] == "Lettuce")
                            {
                                inventory[j] = "";

                                for (int k = 0; k < inventory.Length; k++) //Removes third ingredient
                                {
                                    if (inventory[k] == "Bread")
                                    {
                                        inventory[k] = "";

                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            Console.ReadLine();
        }

        static void Main()
        {

            string temp;


            do
            {
                Welcome();

                Console.WriteLine("Please choose an option");
                temp = Console.ReadLine();
                Task = Convert.ToInt32(temp);

                Console.Clear();

                switch (Task)

                {
                    case 1:
                        Task1();
                        break;

                    case 2:
                        Task2();
                        break;

                    case 3:
                        Task3();
                        break;

                    case 0:
                        Exit();
                        break;

                    default:
                        InvalidInput();
                        break;

                }

                Console.Clear();


            } while (Task != 0);




        }
    }
}
