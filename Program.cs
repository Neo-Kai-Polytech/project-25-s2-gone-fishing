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

            // Main story line

            // Print to Screen Main Story Summary


            Console.WriteLine("So the story starts with World War III Apocalypse where all countries were on war. Lost of lives were lost, families got ruined. Not only damage is done to the humans, nature also paid the price animal species got extinct, air pollution went to the next level." +
                "In the war many comunities were lost, world population got half, darkness is now spreading every corner of the world.People praying to the God to restore the balance of the world and some still have belief someone will a messiah will come and everything will come back to original.");

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

            //start of the game
            FirstFight();

        }

        public static void events()

        {
            {
                int events;
                Console.WriteLine("Where would want to go first?");
                Console.WriteLine("The options are:");
                Console.WriteLine("Event 1");
                Console.WriteLine("Event 2");
                Console.WriteLine("Event 3");
                Console.WriteLine("Event 4");
                events = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

                switch (events)
                {
                    case 1:
                        //go to event 1
                        break;
                    case 2:
                        //go to event 2
                        break;
                    case 3:
                        //go to event 3
                        break;
                    case 4:
                        //go to event 4
                        break;
                        static void event1()
                        {
                            char des1;
                            Console.WriteLine("Continuing his journey now he reached Russia where he saw that everything is destroyed.He is findind any life which is still alive and can talk with them. He is in a dense forest right now.");
                            //where do you wanna go/
                            Thread.Sleep(500);
                            Console.WriteLine("You see a bear running towards you.");
                            Console.WriteLine("what do you wannna do run or fight ?");
                            des1 = Convert.ToChar(Console.ReadLine());
                            //during fight bear hp will come
                            //If he fights he will kill him and with the fighting sounds people will come and meet him
                            //If he runs he will find a village and they all together giht the bear and will kill the bear and enjoy the steak.
                            //here we can add some combat things and can give hp to the person and bear, he can also use various things like sword or something to fight.
                            Console.WriteLine("");
                            switch (des1)
                            {
                                case 'r':
                                    Console.WriteLine("While running he got to a village where he saw bunch of people");
                                    break;
                                case 'f':
                                    //he fights
                                    int bear = 50;
                                    int player = 100;
                                    break;
                            }
                            Console.WriteLine("After this he observed the cooking method of the villagers which was slighl=tly different and wane to talk with them regarding that.While chatting he got to know some new dishes which includes russian steak etc.");
                            //here some things 2 or 3 ingredients will get added in the inventory
                            Console.WriteLine("Press any button to cook new dish");
                            //here cook book will come 

                            Console.ReadLine();
                            //end of event and he continues his journey
                        }



                        //event 2 will come here

                }
                static void event2()
                {
                    Console.WriteLine("");
                }

                //event 3 will come here
                static void event3()
                {
                    Console.WriteLine("");
                }

                // event 4 will come here
                static void event4()
                {
                    Console.WriteLine("");
                }
            }
        }


        public static void FirstFight()
        {
            Console.WriteLine("Starting Area");
            Thread.Sleep(2000);
            Console.Clear();

            //Console.WriteLine("Before you stands a Huge Mutated Rat");
            //Thread.Sleep(2000);
            //Console.WriteLine("It shrieks in blood curdling savagery ready to gnaw your face off");
            //Thread.Sleep(2000);
            //Console.WriteLine("PREPARE TO FIGHT!");
            //Thread.Sleep(2000);

            Console.Clear();

            Console.WriteLine("Epic Combat Commences");

            string enemyName = HostileEnemies();

            CombatSystem(enemyName);

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


        public static void CombatSystem(string enemyName)
        {
            int playerHP = 100;
            int enemyHP = random.Next(30, 40);

            int playerAttack = 0;
            int enemyAttack = 0;

            do
            {

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
                Console.Write(playerHP.ToString().PadRight(15));
                Console.Write(enemyHP.ToString().PadLeft(15));

                Console.WriteLine();
                Console.WriteLine("What would you like to do?");

                string playerInput = Console.ReadLine();

                playerAttack = random.Next(5, 15);
                Console.WriteLine($"\nPlayer attacks dealing {playerAttack} damage! \n");
                enemyHP = enemyHP - playerAttack;


                enemyAttack = random.Next(1, 6);
                Console.WriteLine($"\n{enemyName} attacks dealing {enemyAttack} damage! \n");
                playerHP = playerHP - enemyAttack;

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
