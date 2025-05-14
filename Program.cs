namespace UberProject
{
    internal class Program
    {
        private static Random random = new Random();
        private static int Task;
        private static string charName;
        static string[] inventory = ["", "", "", "", "", "", "", "", "", ""]; //Inventory of 10 slots, all same empty value to check if slots are empty


        static void Welcome()
        {
            Console.WriteLine("FLAVOURS OF FALLOUT");
            Console.WriteLine();
            Console.WriteLine("The Menu options are:");
            Console.WriteLine("1  New Game");
            Console.WriteLine("2  Options");
            Console.WriteLine("3  Controls");
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
            // Print to Screen Main Story Summary

            Console.WriteLine("So the story starts with World War III Apocalypse where all countries were on war. Lost of lives were lost, families got ruined. Not only damage is done to the humans, nature also paid the price animal species got extinct, air pollution went to the next level." +
                "In the war many comunities were lost, world population got half, darkness is now spreading every corner of the world.People praying to the God to restore the balance of the world and some still have belief someone will a messiah will come and everything will come back to original."  );

            Console.WriteLine("Press any key to know about the main character");
            Console.ReadLine();


            // Lead to Character Creation
            CharacterCreation();


        }

        public static void CharacterCreation()

        {
            // List Character Options??
            string charName;

            Console.WriteLine("Enter the name of the character.");
            charName = Console.ReadLine();
            Console.WriteLine("The main character belongs to a small village born and brought up in a big family. His mother was a housekeeper and father was the army chief. His all family is very patriotic and kind. Follwing his father's footsteps he also wanted to become a army officer.He also liked cooking which came from his mother and wanted to use this side talent in his life. So he wanted to become a army chef" +
                ".Eventually, after working hard he accomplished his goal and started serving in the army.");
            Thread.Sleep(500);
            Console.WriteLine("Two Years Later.........\n Russia Bombed America and World War III started and whole world was on fire and people were starving. In the attack on citizens he lost his family, lost all of his friends fighting on the border.He himself got injured badly and was in hospital getting treated." +
                "Suddenly, something went bad and he went into comma.");
            Thread.Sleep(500);
            Console.WriteLine("He woke up after Six months and remembered things which happened. After getting out from the hospital he had no purpose left in his life, fully depressed, no family and friends. But he had no idea that nature has planned something big for him.");
            Thread.Sleep(500);
            Console.WriteLine("After some days, while he was still trying to figure out the purpose of his life, One night he got a dream where he was sitting on the dining table with his mom and dad talking about stuff happened recently" +
                "and there his parents told him to follow his passion of cooking and serving people in order to make something out of his life.");
            Thread.Sleep(500);
            Console.WriteLine("After this night he decided to go on a world journey with passion to help people and to get some new experiences.");
            Thread.Sleep(500);
            Console.WriteLine("Where would want to go first?");
            Console.WriteLine("The options are:");
            Console.ReadLine();






            // Lead to first Starting Area?

            StartingArea();

        }

        static void StartingArea()
        {
            Console.WriteLine("Starting Area");
            Thread.Sleep(2000);
            Console.Clear();



            Console.WriteLine("Before you stands a Huge Mutated Rat");
            Thread.Sleep(2000);
            Console.WriteLine("It shrieks in blood curdling savagery ready to gnaw your face off");
            Thread.Sleep(2000);
            Console.WriteLine("PREPARE TO FIGHT!");
            Thread.Sleep(2000);

            Console.Clear();

            Console.WriteLine("Epic Combat Commences");

            combatSystem();










            Console.WriteLine("Press any key to move on to the next area...");
            Console.ReadLine();
            RandomNextArea();
        }

        static void RandomNextArea()
        {
            Console.WriteLine("This is the second explorable Area");
            Console.WriteLine("Press any key to go to the END");
            Console.ReadLine();
            EndArea();

        }

        static void EndArea()
        {
            Console.WriteLine("Well done you have made it to the end");
            Console.WriteLine("Press any key to go back to the main Menu");
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


        static void combatSystem()
        {
            int playerHP = 100;
            int enemyHP = 30;

            int playerIniative = random.Next(0, 10);
            int enemyIniative = random.Next(0, 10);

            string enemyName = "Giant Rat";


            do {

                Console.Write("Name".PadRight(15));
                Console.Write("Name".PadLeft(15));
                Console.WriteLine();
                Console.Write("Player".PadRight(15));
                Console.Write(enemyName.PadLeft(15));
                Console.WriteLine();
                Console.WriteLine("VS".PadLeft(15));
                Console.Write("Health:".PadRight(15));
                Console.Write("Health:".PadLeft(15));
                Console.WriteLine();
                Console.Write(playerHP.PadRight(15));
                Console.Write(enemyHP.PadLeft(15));

            } while (enemyHP > 0); 



            Console.ReadLine();


            if (playerIniative >= enemyIniative)

            {
                Console.WriteLine("Player rolled higher iniative");
                Console.WriteLine("Player goes first");
                Console.WriteLine();


            }
            else 
            {
                Console.WriteLine("Enemy rolled higher iniative");
                Console.WriteLine("Enemy strikes first");
                Console.WriteLine("Giant Mutated Attacks with VISCIOUS CLAWS");

                int enemyDamage = random.Next(0, 10);

            }

            
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
                // OPTIONS MENU

                Console.WriteLine("This is Task 3");
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
                Console.WriteLine("Hello. This is your inventory.\nPress 1 to cook ingredients\nPress 2 to read out your inventory\nPress 3 to scavenge for ingredients\n\nPress 0 to close the program"); //Menu text
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
                    case 3:
                        Console.Clear();
                        Scavenge();
                        Console.WriteLine("-- Press enter to go back to the menu");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            } while (input != 0);
        }
        // WIP. IGNORE SPAGHETTI CODE. WILL BREAK DOWN OVER TIME
        /*TODO: 
        *Add functional tier 3 crafting recipies. Make it so I don't need an if statement with 9 or's to cover all cooking variations.
        *Change "for (int i = 0; i < inventory.Length; i++)" to a while/do while loop. It is more efficient.
         */
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
                        Console.WriteLine("Toast | Tier 1 recipie - 1 bread\nBoiling Water | Tier 1 recipie - 1 Drinkable Water\nSalad | Tier 2 recipie - 2 lettuce\nBasic sandwich | Tier 3 recipie - 1 Lettuce, 2 bread");
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
                        Console.WriteLine("What ingredient would you like to use?");
                        ingredientSlot1 = Console.ReadLine().ToLower();
                        //Toast
                        if (ingredientSlot1 == "bread") //ingredient (bread, in this case)
                        {
                            for (int i = 0; i < inventory.Length; i++)
                            {
                                if (inventory[i] == "Bread") //Grab the ingredient from inventory
                                {
                                    inventory[i] = "Toast"; //Make inventory slot the final meal
                                    Console.Write("You cooked Toast");
                                    break;
                                }
                            }
                        }
                        //Boiling Water
                        else if (ingredientSlot1 == "drinkable water") //ingredient
                        {
                            for (int i = 0; i < inventory.Length; i++)
                            {
                                if (inventory[i] == "Drinkable Water") //Find in inventory
                                {
                                    inventory[i] = "Boiling Water"; //Replace it
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
                        break;
                    case 2: //Cooking tier 2 recipies
                        Console.WriteLine("What is the first ingredient you would like to use?");
                        ingredientSlot1 = Console.ReadLine().ToLower();
                        Console.WriteLine("What is the second ingredient you would like to use?");
                        ingredientSlot2 = Console.ReadLine().ToLower();
                        //Salad
                        if (ingredientSlot1 == "lettuce" && ingredientSlot2 == "lettuce") //Ingredients
                        {
                            for (int i = 0; i < inventory.Length; i++)
                            {
                                if (inventory[i] == "Lettuce") //Grab the first ingredient in inventory
                                {
                                    inventory[i] = "Salad"; //Make it salad
                                    Console.WriteLine("You made Salad");
                                }
                                else if (inventory[i] == "Lettuce") //Make sure to change all other ingredients used to empty slots
                                {
                                    inventory[i] = "";
                                    break;
                                }
                            }
                        }
                        Console.ReadLine();
                        break;
                    case 3: //Cooking tier 3 recipies
                        Console.WriteLine("What is the first ingredient you would like to use?");
                        ingredientSlot1 = Console.ReadLine().ToLower();
                        Console.WriteLine("What is the second ingredient you would like to use?");
                        ingredientSlot2 = Console.ReadLine().ToLower();
                        Console.WriteLine("What is the third ingredient you would like to use?");
                        ingredientSlot3 = Console.ReadLine().ToLower();
                        break;
                    case 0:
                        break;
                }
                Console.Clear();
            } while (input != 0);


        }
        static void Scavenge() //Ingredients are placeholder. Can be added on to
        {
            int searchCase;
            searchCase = random.Next(1, 6); //Decides what you find
            switch (searchCase)
            {
                default: //You found nothing
                    Console.WriteLine("You found nothing");
                    break;
                case 1: //You find lettuce
                    for (int i = 0; i < inventory.Length; i++)
                    {
                        if (inventory[i] == "") //Finds an empty slot in inventory
                        {
                            inventory[i] = "Lettuce"; //Sets empty slot to lettuce
                            Console.WriteLine("Added Lettuce to your inventory");
                            break; //Breaks convention, but if it's not there than the entire inventory fills up with lettuce.
                        }
                    }
                    break;

                case 2:
                case 3:
                case 4: //You find bread. You are also more likely to find bread compared to lettuce, thanks to the numerous cases assigned to the bread
                    for (int i = 0; i < inventory.Length; i++)
                    {
                        if (inventory[i] == "") //Finds empty slot
                        {
                            inventory[i] = "Bread"; //Sets empty slot as bread
                            Console.WriteLine("Added bread to your inventory");
                            break;
                        }
                    }
                    break;
                case 5:
                    for (int i = 0; i < inventory.Length; i++)
                    {
                        if (inventory[i] == "")
                        {
                            inventory[i] = "Drinkable Water";
                            Console.WriteLine("You found a bottle of Drinkable Water");
                            break;
                        }
                    }
                    break;
            }
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

