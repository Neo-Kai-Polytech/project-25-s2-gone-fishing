using System.Numerics;
using System.Xml.Linq;

namespace UberProject
{
    public struct Player
    {
        public string playerName;
        public int playerHP;
        public string playerWeapon;
        public int playerAttack;
        public Player(string name, int hp, string weapon, int attack)
        {
            this.playerName = name;
            this.playerHP = hp;
            this.playerWeapon = weapon;
            this.playerAttack = attack;
        }
        public override string ToString()
        {
            return $"Name: {playerName} | HP: {playerHP} | Weapon: {playerWeapon} | Attack: {playerAttack}";
        }
    }
    public struct Enemies
    {
        public string enemyName;
        public int enemyHP;
        public int enemyAttack;
        public string enemyDesc;

        public Enemies(string name, int hp, int attack, string desc)
        {
            this.enemyName = name;
            this.enemyHP = hp;
            this.enemyAttack = attack;
            this.enemyDesc = desc;
        }
        public override string ToString()
        {
            return $"{enemyName} | HP: {enemyHP} | Attack: {enemyAttack} | Description: {enemyDesc}";
        }

    }
    public struct Weapons()
    {
        public string weaponName;
        public int weaponDamage;
        public string weaponType;
        public string weaponRarity;
        public override string ToString()
        {
            return $"{weaponName} | Damage: {weaponDamage} | Type: {weaponType} | Rarity: {weaponRarity}";
        }
    }
    public struct Ingredients()
    {
        public string ingredientName;
        public override string ToString()
        {
            return $"Name: {ingredientName}";
        }
    }
    public struct Items()
    {
        public string itemName;
        public string itemType;
        public int itemEffectValue;
        public string itemDesc;
        public override string ToString()
        {
            return $"{itemName} | Type: {itemType} | {itemEffectValue} | Description: {itemDesc}";
        }

    }
    public struct Recipes()
    {
        public string recipeName;
        public string ingredient1;
        public string ingredient2;
        public string ingredient3;
        public override string ToString()
        {
            return $"{recipeName} | Ingredient1: {ingredient1} | Ingredient2: {ingredient2} | Ingredient3: {ingredient3}";
        }
    }

    internal class Program
    {
        private static Random random = new Random();
        private static int Task;
        public static string charName, cookbook = "";
        static string[] inventory = ["", "", "", "", "", "", "", "", "", ""]; 
        static string[] foodSatchel = ["", "", "", "", "", "", "", "", "", ""];
        static Enemies[] monsters =
      {
            new Enemies("Mirelurk", 30, 5, "A mutated crab-like creature with a hard shell and a vicious bite."),
            new Enemies("Super Mutant", 40, 8, "A hulking brute with enhanced strength and resilience, often armed with heavy weapons."),
            new Enemies("Deathclaw", 50, 10, "A terrifying predator with razor-sharp claws and incredible speed."),
            new Enemies("Radscorpion", 35, 7, "A giant scorpion with a venomous sting and armored exoskeleton."),
            new Enemies("Radroach", 20, 4, "Giant irradiated cockroach with acidic saliva and armored carapace"),
            new Enemies("Mutant Hound", 35, 7, "Once a domestic dog, now a grotesque, hairless predator with enhanced senses and aggression."),
            new Enemies("Ash Crawler", 25, 5, "A pale, skeletal creature that burrows through radioactive ash, ambushing prey from below."),
            new Enemies("Ghoul Reaper", 30, 6, "A sentient, decaying humanoid that hunts the living for flesh, often in packs."),
            new Enemies("Wasteland Abomination", 50, 10, "A massive fusion of flesh and machinery, created from failed experiments and scavenged tech."),
            new Enemies("Irradiated Behemoth", 60, 12, "Towering brute pulsing with nuclear energy, leaving scorched earth in its wake."),
            new Enemies("Scorched Stalker", 28, 6, "Burn-scarred humanoid with smoldering skin, capable of setting traps and ambushes."),
            new Enemies("Toxic Spitter", 22, 5, "A bloated mutant that expels corrosive bile from a distended jaw."),
            new Enemies("Bone Dragger", 26, 5, "Lurks in the shadows, dragging scavenged bones across the ground to lure victims."),
            new Enemies("Nuke Leech", 18, 3, "A glowing, slug-like parasite that feeds on radiation and attaches to living hosts."),
            new Enemies("Murderous Crow", 18, 4, "A seemingly normal crow with teeth that can cut through ceramic plates"),
            new Enemies("Mutant Bear", 35, 8, "A mutated bear, aggressive and dangerous.")
    };

        static void Welcome()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("______ _                                        __       ______    _ _             _   \r\n|  ___| |                                      / _|      |  ___|  | | |           | |  \r\n| |_  | | __ ___   _____  _ __ ___        ___ | |_       | |_ __ _| | | ___  _   _| |_ \r\n|  _| | |/ _` \\ \\ / / _ \\| '__/ __|      / _ \\|  _|      |  _/ _` | | |/ _ \\| | | | __|\r\n| |   | | (_| |\\ V / (_) | |  \\__ \\     | (_) | |        | || (_| | | | (_) | |_| | |_ \r\n\\_|   |_|\\__,_| \\_/ \\___/|_|  |___/      \\___/|_|        \\_| \\__,_|_|_|\\___/ \\__,_|\\__|\r\n                                                                                       \r\n                                                                                       ");
            Console.ResetColor();
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
                "\nNot only damage is done to the humans, nature also paid the price animal species got extinct, air pollution went to the next level." +
                "\nIn the war many communities were lost, world population got half, darkness is now spreading every corner of the world." +
                "People praying to the God to restore the balance of the world.\nSome still have belief that someday a messiah will come and everything will come back to its original.");

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

            Player player = new Player(charName, 100, "Rusty Pipe Rifle", 10);

            Console.WriteLine($"{charName} belongs to a small village born and brought up in a big family. His mother was a housekeeper and father was the army chief." +
                $"\nHis whole family is very patriotic and kind. Following his father's footsteps he also wanted to become an army officer. " +
                $"\nHe also liked cooking which her mother taught him and wanted to use this side talent in his life. So he wanted to become an army chef." +
                "\nEventually, after working hard he accomplished his goal and started serving in the army.");
            Thread.Sleep(500);
            Console.WriteLine($"\n\nTwo Years Later.........\nRussia Bombed America and World War III started and whole world was on fire and people were starving. " +
                $"\nIn the attack {charName} lost his family, lost all of his friends fighting on the border.He himself got injured badly and was in hospital getting treated." +
                "Suddenly, something went bad and he went into a coma.");
            Thread.Sleep(500);
            Console.WriteLine("\nHe woke up after six months and remembered things which happened. \nAfter getting out from the hospital, he observed lots of things has changed example due to nuclear war some animals got mutated.\nSo, one night he had a panic attack and he was thinking that now  had no purpose left in his life, fully depressed, no family and friends. " +
                "\nBut he had no idea that nature has planned something big for him.");
            Thread.Sleep(500);
            Console.WriteLine($"After some days, while {charName} was still trying to figure out the purpose of his life, " +
                $"\none night he got a dream where he was sitting on the dining table with his mom and dad talking about stuff happened recently.\n" +
                "There his parents told him to follow his passion of cooking and serving people in order to make something out of his life.\n");
            Thread.Sleep(500);
            Console.WriteLine("\nAfter this night he decided to go on a world journey with passion to help people and to get some new experiences.");
            Console.WriteLine("\nTo decide where he should start first he just darted on the small globe and it landed on Russia.");
            Console.ReadLine();
            //start of the game


            StartingArea(ref player);

        }
         
        public static void StartingArea(ref Player player)
        {
            Console.WriteLine("Starting Area");
            Console.ReadLine();

            Console.Clear();

            event1(ref player);

            event2(ref player);

            event3(ref player);

            event4(ref player);

            event5(ref player);

            endEvent(ref player);



        }

    
        static void event1(ref Player player)
        {
            Console.WriteLine("With the journey now he is finally in Russia where he saw that everything is destroyed. " +
                "\nHe is finding any life which is still alive and can talk with them and he found a dense forest.And suddenly,..........");
            Thread.Sleep(2000);
            Console.WriteLine("\nYou see a bear running towards you!");
            Console.WriteLine("Prepare yourself!\n\n");
            Console.ReadLine();

            Enemies enemy = monsters[15];

            CombatSystem(ref player, enemy);

            Console.WriteLine("YOU'VE FOUND EPIC LOOT!");
            Console.ReadLine();
            AcquireEpicLoot();

            Console.WriteLine($"After the fight villagers came to see who is in trouble and found {charName}");
        }

        static void event2(ref Player player)
        {

            Console.WriteLine("After uniting with villagers he observed their cooking method  which was slightly different and want to talk with them regarding that." +
                "\nWhile chatting he got to know some new dishes which includes Russian steak etc.\n");
            Thread.Sleep(500);
            Console.WriteLine("Russian Steak is now added in your inventory.");
            Thread.Sleep(500);
            Console.WriteLine("Recipe for Russian Steak is Meat, Potato, Butter.");
            //here some things 2 or 3 ingredients will get added in the inventory
            cookbook = cookbook + "Russian Steak";
            for (int i = 0; i < foodSatchel.Length; i++)
            {
                if (foodSatchel[i] == "")
                {
                    foodSatchel[i] = "Bread";
                    break;
                }
            }

            for (int i = 0; i < foodSatchel.Length; i++)
            {
                if (foodSatchel[i] == "")
                {
                    foodSatchel[i] = "Meat";
                    break;
                }
            }
            for (int i = 0; i < foodSatchel.Length; i++)
            {
                if (foodSatchel[i] == "")
                {
                    foodSatchel[i] = "Potato";
                    break;
                }
            }
            for (int i = 0; i < foodSatchel.Length; i++)
            {
                if (foodSatchel[i] == "")
                {
                    foodSatchel[i] = "Butter";
                    break;
                }
            }

            Console.WriteLine("Press any button to cook new dish");
            Console.ReadLine();
            InventoryManage();

            Console.WriteLine("Press any button to continue...");
            Console.ReadLine();
            //end of event and he continues his journey
        }

        static void event3(ref Player player)
        {
            Console.WriteLine($"Now Continuing in Russia {charName} reached in Moscow. He saw that city is pretty much destroyed and the vibes are pretty depressed in the city.\nRoaming around he met a bunch of people going in a group mental therapy and decided to join them. During the conversations he told them his passion of cooking and about his journey.\n" +
                $"So other persons shared their favorite recipies and ingredients with him.");
            Console.WriteLine();
            Console.WriteLine("The recipies are following:");
            Console.WriteLine("1. Borcht - Meat, Onion, Potato");
            Console.WriteLine("2. Solyanka - pickle, lemon, flour");
            cookbook = cookbook + "Borcht | Meat, Onion Potato ";
            cookbook = cookbook + "Solyanka | Pickle, Lemon, Flour ";
            for (int i = 0; i < foodSatchel.Length; i++)
            {
                if (foodSatchel[i] == "")
                {
                    foodSatchel[i] = "Onion";
                    break;
                }
            }
            for (int i = 0; i < foodSatchel.Length; i++)
            {
                if (foodSatchel[i] == "")
                {
                    foodSatchel[i] = "Pickle";
                    break;
                }
            }
            for (int i = 0; i < foodSatchel.Length; i++)
            {
                if (foodSatchel[i] == "")
                {
                    foodSatchel[i] = "Lemon";
                    break;
                }
            }
            for (int i = 0; i < foodSatchel.Length; i++)
            {
                if (foodSatchel[i] == "")
                {
                    foodSatchel[i] = "Flour";
                    break;
                }
            }
            Console.WriteLine("Press any button to cook new dish");
            Console.ReadLine();
            InventoryManage();


            Console.WriteLine("Press any button to continue...");
            Console.ReadLine();


        }

        static void event4(ref Player player)
        {
            string input;
            Console.WriteLine("You see yourself at what used to be an old car park. Tattered green tents lay across it, and military jeeps create barricades. You can tell it had long since been abandoned. All of a sudden a crow comes eye to eye with you. twitchingly eyeing you up.");
            Enemies enemy = monsters[14];
            CombatSystem(ref player, enemy); //Crow fight
            Console.WriteLine("You notice that the crow has given you bite marks. It seems that over time it has evolved teeth to chew through the armour plating that the military soldiers have. It seems that you have caused quite the commotion during your fight, and now all of the crows want to see what's going on");
            Console.WriteLine("You couldn't outrun them if you tried, unless you managed to find a distraction. The meat you're carrying will do just fine. Or you can engage with them, and see what the soldiers left behind");
            Console.WriteLine("r|   Sacrifice all meat and run away     f|    Fight 5 crows back to back");
            input = Console.ReadLine();
            switch (input)
            {
                case "f":
                    CombatSystem(ref player, enemy); //Fight 5 crows
                    CombatSystem(ref player, enemy); 
                    CombatSystem(ref player, enemy); 
                    CombatSystem(ref player, enemy); 
                    CombatSystem(ref player, enemy);
                    Console.WriteLine("YOU'VE FOUND EPIC LOOT!");
                    Console.ReadLine();
                    AcquireEpicLoot();
                    break;
                case "r":
                    for (int i = 0; i < foodSatchel.Length; i++)
                    {
                        if (foodSatchel[i] == "Meat" ||  foodSatchel[i] == "Fish")
                        {
                            foodSatchel[i] = "";
                        }
                    }
                    Console.WriteLine("You run away, losing all your meat");
                    break;
            }
            Console.ReadLine();
        }

        static void event5(ref Player player)
        {
            Console.WriteLine($"{charName} find themself walking through a run-down mall. They are heading towards the food court to keep warm throughout the night. Expecting trouble, {charName} is surprised to see a small community surviving deep inside the mall.");
            Console.WriteLine($"Coming down to meet the survivors, they instantly welcome {charName} into their community. {charName} explained their dream of helping people, and the survivors told them that they believed that one day a messiah would come to save us all, and that {charName} should eat a meal with them");
            Console.ReadLine();
            cookbook = cookbook + "Kutia | Rice, Canned Fruits, Flower Seeds";
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "Rice";
                }
            }
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "Canned Fruits";
                }
            }
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "Flower Seeds";
                }
            }
            Console.WriteLine("Kutia was added to your cookbook");
            Console.ReadLine();
        }

        static void endEvent(ref Player player)
        {
            Console.WriteLine("Now you are in the end of the game.");
            Console.WriteLine($"People in Moscow have told {charName} that there is a Military base near Moscow where a chef teacher is needed and they can use his help.");
            Console.WriteLine($"\nSo he went there and saw bunch of young soldiers eating raw flesh which is not good for health. " +
                $"\nSo {charName} approached them but suddenly siren starts ringing and news is a Mutant Scorpio attacked the OutPost.");
            Console.WriteLine($"{charName} decides to help other soldiers");
            Console.ReadLine();
            Console.WriteLine($"Prepare to FIGHT!!!");

            Enemies enemy = monsters[3];

            CombatSystem(ref player, enemy);

            //fighting scene will come here
            Console.WriteLine($"After the Fight you gained the trust of soldiers and now told them that he wants to teach soldiers some cooking methods.");
            Console.WriteLine($"In this whole journey {charName} learned lots of new dishes which are:");
            Console.WriteLine("Beef stroganoff - Meat, Sour Cream, Onions");
            Console.WriteLine("Varenniki - Cheese, Potato, Eggs");
            Console.ReadLine();

            Console.WriteLine("Now these recipies are added in your inventory");
            cookbook = cookbook + "Varenniki | Cheese, Potato, Eggs ";
            cookbook = cookbook + "Beef stroganoff | Meat, Sour Cream, Onions ";
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "Cheese";
                }
            }
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "Eggs";
                }
            }
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "Sour Cream";
                }
            }
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "Onions";
                }
            }
            Console.ReadLine();

            Console.WriteLine("Thanks for playing the game.Hope you enjoyed it.");
            Console.WriteLine("If you wanna play again press A\nIf you wanna exit Press Enter.");
        }


        public static void CombatSystem(ref Player player, Enemies enemy)
        {
            int choice;
            string temp;

            while (player.playerHP > 0 && enemy.enemyHP > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Player: {player.playerName} | HP: {player.playerHP} | Weapon: {player.playerWeapon} | Attack: {player.playerAttack}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("VS".PadLeft(32));
                Console.WriteLine("------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Enemy: {enemy.enemyName} | HP: {enemy.enemyHP} | Attack: {enemy.enemyAttack}");
                Console.WriteLine($"Description: {enemy.enemyDesc}");

                Console.ResetColor();

                Console.WriteLine("What do you want to do?");

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Open Inventory");

                temp = Console.ReadLine();
                choice = Convert.ToInt32(temp);


                switch (choice)
                {
                    case 1:
                        // Attack
                        int pAttack = player.playerAttack + random.Next(-2, 3);
                        enemy.enemyHP = enemy.enemyHP - pAttack;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{player.playerName} attacks {enemy.enemyName} for {pAttack} damage!");
                        Console.ResetColor();

                        if (enemy.enemyHP <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{enemy.enemyName} is defeated!");
                            Console.ResetColor();
                            break;
                        }

                        int eAttack = enemy.enemyAttack + random.Next(-2,3);
                        player.playerHP = player.playerHP - eAttack;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"{enemy.enemyName} attacks {player.playerName} for {eAttack} damage!");
                        Console.ResetColor();

                        if (player.playerHP <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{player.playerName} has been defeated!");
                            Console.ResetColor();

                            Console.WriteLine("GAME OVER! Press Enter to exit...");
                            Main();
                        }

                        Console.WriteLine("\nPress Enter for next round...");
                        Console.ReadLine();
                        break;

                    case 2:
                        // Open Inventory
                        Console.Clear();
                        DisplayInventory(ref player, enemy);
                        continue; // Skip the rest of the loop and go back to the top
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        continue; // Skip the rest of the loop and go back to the top
                }

            }

            Console.WriteLine("Combat ended. Press Enter to continue...");
            Console.ReadLine();

        }


        static void DisplayInventory(ref Player player, Enemies enemy)
        {
            Console.WriteLine("Inventory:");
            Console.WriteLine("Slot | Item");
            Console.WriteLine("---------------");
            for (int i = 0; i < inventory.Length; i++)
            {
                string item = string.IsNullOrEmpty(inventory[i]) ? "[Empty]" : inventory[i];
                Console.WriteLine($"{i + 1,4} | {item}");
            }
            Console.WriteLine();

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Use an item");
            Console.WriteLine("2. Equip a weapon");
            Console.WriteLine("3. Return to combat");

            int choice;
            string temp = Console.ReadLine();
            choice = Convert.ToInt32(temp);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the slot number of the item you want to use:");
                    int itemSlot;
                    temp = Console.ReadLine();
                    itemSlot = Convert.ToInt32(temp) - 1;
                    if (itemSlot >= 0 && itemSlot < inventory.Length && !string.IsNullOrEmpty(inventory[itemSlot]))
                    {
                        string[] itemDetails = inventory[itemSlot].Split(" - ");
                        if (itemDetails.Length >= 3 && itemDetails[1] == "Healing")
                        {
                            int healAmount = Convert.ToInt32(itemDetails[2]);
                            player.playerHP = player.playerHP + healAmount;
                            Console.WriteLine($"You used {itemDetails[0]} and healed for {healAmount} HP!");
                            inventory[itemSlot] = "";
                        }
                        else if (itemDetails.Length >= 3 && itemDetails[1] == "Explosive")
                        {
                            int damageAmount = Convert.ToInt32(itemDetails[2]);
                            enemy.enemyHP = enemy.enemyHP - damageAmount;
                            Console.WriteLine("***HUGE EXPLOSIONS***");
                            Console.WriteLine($"You used {itemDetails[0]} against {enemy.enemyName} dealing {damageAmount} damage!");
                            inventory[itemSlot] = "";
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid slot number or empty slot.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the slot number of the weapon you want to equip:");
                    int weaponSlot;
                    temp = Console.ReadLine();
                    weaponSlot = Convert.ToInt32(temp) - 1;
                    if (weaponSlot >= 0 && weaponSlot < inventory.Length && !string.IsNullOrEmpty(inventory[weaponSlot]))
                    {
                        string[] weaponDetails = inventory[weaponSlot].Split(" - ");
                        if (weaponDetails.Length >= 4)
                        {
                            player.playerWeapon = weaponDetails[0];
                            player.playerAttack = Convert.ToInt32(weaponDetails[1]);
                            Console.WriteLine($"You equipped {player.playerWeapon} with {player.playerAttack} attack power!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid weapon details.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid slot number or empty slot.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Returning to combat...");
                    Thread.Sleep(1000);
                    return;
            }


        }

        static void AcquireEpicLoot()
        {
            // This will be an Array of Loot that you can randomly acquire through different events and fights.

            Weapons[] weapons =
            {
                new Weapons { weaponName = "Rusty Pipe Rifle", weaponDamage = 12, weaponType = "Ranged", weaponRarity = "Common" },
                new Weapons { weaponName = "Spiked Baseball Bat", weaponDamage = 10, weaponType = "Melee", weaponRarity = "Common" },
                new Weapons { weaponName = "Radiation Axe", weaponDamage = 14, weaponType = "Melee", weaponRarity = "Common" },
                new Weapons { weaponName = "Jury-Rigged Laser Pistol", weaponDamage = 16, weaponType = "Energy", weaponRarity = "Common" },
                new Weapons { weaponName = "Toxic Syringe Gun", weaponDamage = 13, weaponType = "Ranged", weaponRarity = "Common" },
                new Weapons { weaponName = "Electrified Machete", weaponDamage = 17, weaponType = "Melee", weaponRarity = "Common" },
            
                new Weapons { weaponName = "Hunting Rifle", weaponDamage = 25, weaponType = "Ranged", weaponRarity = "Rare" },
                new Weapons { weaponName = "Sawblade Launcher", weaponDamage = 30, weaponType = "Ranged", weaponRarity = "Rare" },
                new Weapons { weaponName = "Combat Shotgun", weaponDamage = 30, weaponType = "Ranged", weaponRarity = "Rare" },
                new Weapons { weaponName = "Flamer", weaponDamage = 35, weaponType = "Heavy", weaponRarity = "Rare" },
                new Weapons { weaponName = "Super Sledge", weaponDamage = 28, weaponType = "Melee", weaponRarity = "Rare" },
                new Weapons { weaponName = "Laser Musket", weaponDamage = 32, weaponType = "Energy", weaponRarity = "Rare" },
            
                new Weapons { weaponName = "Experimental Gauss Rifle", weaponDamage = 55, weaponType = "Energy", weaponRarity = "Epic" },
                new Weapons { weaponName = "Tesla Cannon", weaponDamage = 65, weaponType = "Energy", weaponRarity = "Epic" },
                new Weapons { weaponName = "Incendiary Chainsaw", weaponDamage = 50, weaponType = "Melee", weaponRarity = "Epic" },
                new Weapons { weaponName = "Cryolator", weaponDamage = 60, weaponType = "Energy", weaponRarity = "Epic" },
                new Weapons { weaponName = "Railway Rifle", weaponDamage = 58, weaponType = "Ranged", weaponRarity = "Epic" },
                new Weapons { weaponName = "Auto-Axe", weaponDamage = 52, weaponType = "Melee", weaponRarity = "Epic" },
            
                new Weapons { weaponName = "Mini Nuke Launcher", weaponDamage = 100, weaponType = "Explosive", weaponRarity = "*Legendary*" },
                new Weapons { weaponName = "Plague Injector", weaponDamage = 80, weaponType = "Ranged", weaponRarity = "*Legendary*" },
                new Weapons { weaponName = "Hellfire Minigun", weaponDamage = 90, weaponType = "Heavy", weaponRarity = "*Legendary*" },
                new Weapons { weaponName = "Quantum Disruptor", weaponDamage = 110, weaponType = "Energy", weaponRarity = "*Legendary*" },
                new Weapons { weaponName = "Oblivion Hammer", weaponDamage = 95, weaponType = "Melee", weaponRarity = "*Legendary*" },
                new Weapons { weaponName = "Apocalypse Blade", weaponDamage = 105, weaponType = "Melee", weaponRarity = "*Legendary*" },
            };


            Ingredients[] ingredients =
            {
                new Ingredients { ingredientName = "Bread" },
                new Ingredients { ingredientName = "Lettuce" },
                new Ingredients { ingredientName = "Tomato" },
                new Ingredients { ingredientName = "Cheese" },
                new Ingredients { ingredientName = "Meat" },
                new Ingredients { ingredientName = "Egg" },
                new Ingredients { ingredientName = "Potato" },
                new Ingredients { ingredientName = "Carrot" },
                new Ingredients { ingredientName = "Onion" },
                new Ingredients { ingredientName = "Garlic" },
                new Ingredients { ingredientName = "Salt" },
                new Ingredients { ingredientName = "Pepper" },
                new Ingredients { ingredientName = "Drinkable Water" },
                new Ingredients { ingredientName = "Jam" },
                new Ingredients { ingredientName = "Milk" },
                new Ingredients { ingredientName = "Butter" },
                new Ingredients { ingredientName = "Mushroom" },
                new Ingredients { ingredientName = "Fish" },
                new Ingredients { ingredientName = "Apple" },
                new Ingredients { ingredientName = "Mutfruit" }
            };

            Items[] items =
            {
                new Items { itemName = "Stimpak", itemType = "Healing", itemEffectValue = 15, itemDesc = "A medical kit that heals wounds and restores health." },
                new Items { itemName = "RadAway", itemType = "Healing", itemEffectValue = 10, itemDesc = "A serum that removes radiation from the body." },
                new Items { itemName = "Nuka-Cola", itemType = "Beverage", itemEffectValue = 8, itemDesc = "A refreshing drink that boosts energy." },
                new Items { itemName = "Pork n' Beans", itemType = "Food", itemEffectValue = 9, itemDesc = "A can of beans that restores hunger." },
                new Items { itemName = "Mirelurk Meat"  , itemType = "Food", itemEffectValue = 12, itemDesc = "Cooked meat from a Mirelurk." },
                new Items { itemName = "Mutfruit", itemType = "Food", itemEffectValue = 5, itemDesc = "A mutated fruit, slightly restores health." },
                new Items { itemName = "Antiseptic Bandage", itemType = "Healing", itemEffectValue = 12, itemDesc = "A bandage soaked in antiseptic, heals minor wounds." },
                new Items { itemName = "Dirty Water", itemType = "Beverage", itemEffectValue = 5, itemDesc = "Water of questionable quality, restores a small amount of health." },
                new Items { itemName = "Molotov Cocktail", itemType = "Explosive", itemEffectValue = 18, itemDesc = "A bottle filled with flammable liquid, deals fire damage." },
                new Items { itemName = "Fragmentation Grenade", itemType = "Explosive", itemEffectValue = 20, itemDesc = "A standard grenade that explodes into deadly shrapnel." },
                new Items { itemName = "Plasma Mine", itemType = "Explosive", itemEffectValue = 24, itemDesc = "A mine that detonates with a burst of plasma energy." },
                new Items { itemName = "Dynamite Bundle", itemType = "Explosive", itemEffectValue = 30, itemDesc = "A bundle of dynamite sticks, causes a large explosion." },
                new Items { itemName = "Cryo Grenade", itemType = "Explosive", itemEffectValue = 15, itemDesc = "A grenade that explodes with a freezing blast, slowing enemies." },
                new Items { itemName = "Cram", itemType = "Food", itemEffectValue = 15, itemDesc = "A can of processed meat, restores a moderate amount of health." },
                new Items { itemName = "Purified Water", itemType = "Beverage", itemEffectValue = 10, itemDesc = "Clean water, restores a good amount of health." }
            };

            int weaponLootRarity = random.Next(1,101);
            int weaponLoot;
            int itemLoot = random.Next(items.Length);
            int ingredientLoot = random.Next(ingredients.Length);

            if (weaponLootRarity <= 40)
            {
                weaponLoot = random.Next(0, 6); // Common Weapons

            }
            else if (weaponLootRarity > 40 && weaponLootRarity < 70)
            {
                weaponLoot = random.Next(6, 12); // Rare Weapons
            }
            else if (weaponLootRarity >= 70 && weaponLootRarity < 90)
            {
                weaponLoot = random.Next(12, 18); // Epic Weapons
            }
            else
            {
                weaponLoot = random.Next(18, 24); // Legendary Weapons
            }

            Weapons acquiredEpicWeapon = weapons[weaponLoot];
            Items acquiredItem = items[itemLoot];
            Ingredients acquiredIngredient = ingredients[ingredientLoot];

            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = $"{acquiredEpicWeapon.weaponName} - {acquiredEpicWeapon.weaponDamage} - {acquiredEpicWeapon.weaponType} - {acquiredEpicWeapon.weaponRarity}";
                    break;
                }

            }

            Console.WriteLine("You have received ");

            if (weapons[weaponLoot].weaponRarity == "Common")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (weapons[weaponLoot].weaponRarity == "Rare")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (weapons[weaponLoot].weaponRarity == "Epic")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (weapons[weaponLoot].weaponRarity == "*Legendary*")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            Console.Write($"{acquiredEpicWeapon}");

            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine($"You have received {acquiredItem.itemName}");
            Thread.Sleep(1000);

            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = $"{acquiredItem.itemName} - {acquiredItem.itemType} - {acquiredItem.itemEffectValue}";
                    break;
                }
            }

            Console.ReadLine();

        }

        public static Enemies RadndomHostileEncounter()
        {
            // This will be an Array of Enemies that you can randomly encounter in the game.


            Enemies[] monsters =
        {
            new Enemies("Mirelurk", 30, 5, "A mutated crab-like creature with a hard shell and a vicious bite."),
            new Enemies("Super Mutant", 40, 8, "A hulking brute with enhanced strength and resilience, often armed with heavy weapons."),
            new Enemies("Deathclaw", 50, 10, "A terrifying predator with razor-sharp claws and incredible speed."),
            new Enemies("Radscorpion", 35, 7, "A giant scorpion with a venomous sting and armored exoskeleton."),
            new Enemies("Radroach", 20, 4, "Giant irradiated cockroach with acidic saliva and armored carapace"),
            new Enemies("Mutant Hound", 35, 7, "Once a domestic dog, now a grotesque, hairless predator with enhanced senses and aggression."),
            new Enemies("Ash Crawler", 25, 5, "A pale, skeletal creature that burrows through radioactive ash, ambushing prey from below."),
            new Enemies("Ghoul Reaper", 30, 6, "A sentient, decaying humanoid that hunts the living for flesh, often in packs."),
            new Enemies("Wasteland Abomination", 50, 10, "A massive fusion of flesh and machinery, created from failed experiments and scavenged tech."),
            new Enemies("Irradiated Behemoth", 60, 12, "Towering brute pulsing with nuclear energy, leaving scorched earth in its wake."),
            new Enemies("Scorched Stalker", 28, 6, "Burn-scarred humanoid with smoldering skin, capable of setting traps and ambushes."),
            new Enemies("Toxic Spitter", 22, 5, "A bloated mutant that expels corrosive bile from a distended jaw."),
            new Enemies("Bone Dragger", 26, 5, "Lurks in the shadows, dragging scavenged bones across the ground to lure victims."),
            new Enemies("Nuke Leech", 18, 3, "A glowing, slug-like parasite that feeds on radiation and attaches to living hosts."),
            new Enemies("Murderous Crow", 7, 10, "A seemingly normal crow with teeth that can cut through ceramic plates")
        };

            int enemyNumber = random.Next(monsters.Length);

            return monsters[enemyNumber];


        }


        static void Task2()
        {
            // OPTIONS MENU

            Console.WriteLine("This is Task 2");
            Console.WriteLine("Press any key to return to menu");
            Console.ReadLine();

        }
        public static void Task3()
        {
            // Collection of Things
            string userInput;

            do
            {

                Console.WriteLine("Welcome to the collection of things in our game");
                Console.WriteLine("The Menu options are:");
                Console.WriteLine("1  Monsters");
                Console.WriteLine("2  Weapons");
                Console.WriteLine("3  Items");
                Console.WriteLine("4  Ingredients");
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
                        // Display all enemies in a readable format
                        Enemies[] monsters =
                        {
                            new Enemies("Mirelurk", 30, 5, "A mutated crab-like creature with a hard shell and a vicious bite."),
                            new Enemies("Super Mutant", 40, 8, "A hulking brute with enhanced strength and resilience, often armed with heavy weapons."),
                            new Enemies("Deathclaw", 50, 10, "A terrifying predator with razor-sharp claws and incredible speed."),
                            new Enemies("Radscorpion", 35, 7, "A giant scorpion with a venomous sting and armored exoskeleton."),
                            new Enemies("Radroach", 20, 4, "Giant irradiated cockroach with acidic saliva and armored carapace"),
                            new Enemies("Mutant Hound", 35, 7, "Once a domestic dog, now a grotesque, hairless predator with enhanced senses and aggression."),
                            new Enemies("Ash Crawler", 25, 5, "A pale, skeletal creature that burrows through radioactive ash, ambushing prey from below."),
                            new Enemies("Ghoul Reaper", 30, 6, "A sentient, decaying humanoid that hunts the living for flesh, often in packs."),
                            new Enemies("Wasteland Abomination", 50, 10, "A massive fusion of flesh and machinery, created from failed experiments and scavenged tech."),
                            new Enemies("Irradiated Behemoth", 60, 12, "Towering brute pulsing with nuclear energy, leaving scorched earth in its wake."),
                            new Enemies("Scorched Stalker", 28, 6, "Burn-scarred humanoid with smoldering skin, capable of setting traps and ambushes."),
                            new Enemies("Toxic Spitter", 22, 5, "A bloated mutant that expels corrosive bile from a distended jaw."),
                            new Enemies("Bone Dragger", 26, 5, "Lurks in the shadows, dragging scavenged bones across the ground to lure victims."),
                            new Enemies("Nuke Leech", 18, 3, "A glowing, slug-like parasite that feeds on radiation and attaches to living hosts.")
                        };
                        Console.WriteLine("Monsters in the game:\n");
                        foreach (var enemy in monsters)
                        {
                            Console.WriteLine(enemy);
                        }
                        Console.WriteLine("\n-- Press any key to return to the collection menu --");
                        Console.ReadLine();
                        break;

                    case "2":
                        // Display all weapons in a readable format
                        Weapons[] tier1weapons =
                        {
                            new Weapons { weaponName = "Rusty Pipe Rifle", weaponDamage = 12, weaponType = "Ranged" },
                            new Weapons { weaponName = "Spiked Baseball Bat", weaponDamage = 10, weaponType = "Melee" },
                            new Weapons { weaponName = "Radiation Axe", weaponDamage = 14, weaponType = "Melee" },
                            new Weapons { weaponName = "Jury-Rigged Laser Pistol", weaponDamage = 16, weaponType = "Energy" },
                            new Weapons { weaponName = "Toxic Syringe Gun", weaponDamage = 13, weaponType = "Ranged" },
                            new Weapons { weaponName = "Electrified Machete", weaponDamage = 17, weaponType = "Melee" }
                        };
                        Weapons[] tier2weapons =
                        {
                            new Weapons { weaponName = "Hunting Rifle", weaponDamage = 25, weaponType = "Ranged" },
                            new Weapons { weaponName = "Sawblade Launcher", weaponDamage = 30, weaponType = "Ranged" },
                            new Weapons { weaponName = "Combat Shotgun", weaponDamage = 30, weaponType = "Ranged" },
                            new Weapons { weaponName = "Flamer", weaponDamage = 35, weaponType = "Heavy" },
                            new Weapons { weaponName = "Super Sledge", weaponDamage = 28, weaponType = "Melee" },
                            new Weapons { weaponName = "Laser Musket", weaponDamage = 32, weaponType = "Energy" },
                        };
                        Weapons[] tier3weapons =
                        {
                            new Weapons { weaponName = "Experimental Gauss Rifle", weaponDamage = 55, weaponType = "Energy" },
                            new Weapons { weaponName = "Tesla Cannon", weaponDamage = 65, weaponType = "Energy" },
                            new Weapons { weaponName = "Incendiary Chainsaw", weaponDamage = 50, weaponType = "Melee" },
                            new Weapons { weaponName = "Cryolator", weaponDamage = 60, weaponType = "Energy" },
                            new Weapons { weaponName = "Railway Rifle", weaponDamage = 58, weaponType = "Ranged" },
                            new Weapons { weaponName = "Auto-Axe", weaponDamage = 52, weaponType = "Melee" }
                        };
                        Weapons[] tier4weapons =
                        {
                            new Weapons { weaponName = "Mini Nuke Launcher", weaponDamage = 100, weaponType = "Explosive" },
                            new Weapons { weaponName = "Plague Injector", weaponDamage = 80, weaponType = "Ranged" },
                            new Weapons { weaponName = "Hellfire Minigun", weaponDamage = 90, weaponType = "Heavy" },
                            new Weapons { weaponName = "Quantum Disruptor", weaponDamage = 110, weaponType = "Energy" },
                            new Weapons { weaponName = "Oblivion Hammer", weaponDamage = 95, weaponType = "Melee" },
                            new Weapons { weaponName = "Apocalypse Blade", weaponDamage = 105, weaponType = "Melee" },
                        };

                        Console.WriteLine("Weapons in the game:\n");

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Tier 1 Weapons:");
                        foreach (var weapon in tier1weapons)
                        {
                            Console.WriteLine($"Name: {weapon.weaponName}, Damage: {weapon.weaponDamage}, Type: {weapon.weaponType}");
                        }
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tier 2 Weapons:");
                        foreach (var weapon in tier2weapons)
                        {
                            Console.WriteLine($"Name: {weapon.weaponName}, Damage: {weapon.weaponDamage}, Type: {weapon.weaponType}");
                        }
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Tier 3 Weapons:");
                        foreach (var weapon in tier3weapons)
                        {
                            Console.WriteLine($"Name: {weapon.weaponName}, Damage: {weapon.weaponDamage}, Type: {weapon.weaponType}");
                        }
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Tier 4 Weapons:");
                        foreach (var weapon in tier4weapons)
                        {
                            Console.WriteLine($"Name: {weapon.weaponName}, Damage: {weapon.weaponDamage}, Type: {weapon.weaponType}");
                        }

                        Console.ResetColor();

                        Console.WriteLine("\n-- Press any key to return to the collection menu --");
                        Console.ReadLine();
                        break;

                    case "3":
                        // Display all items in a readable format
                        Items[] items =
                        {
                            new Items { itemName = "Stimpak", itemType = "Healing", itemEffectValue = 15, itemDesc = "A medical kit that heals wounds and restores health." },
                            new Items { itemName = "RadAway", itemType = "Healing", itemEffectValue = 10, itemDesc = "A serum that removes radiation from the body." },
                            new Items { itemName = "Nuka-Cola", itemType = "Beverage", itemEffectValue = 8, itemDesc = "A refreshing drink that boosts energy." },
                            new Items { itemName = "Pork n' Beans", itemType = "Food", itemEffectValue = 9, itemDesc = "A can of beans that restores hunger." },
                            new Items { itemName = "Mirelurk Meat"  , itemType = "Food", itemEffectValue = 12, itemDesc = "Cooked meat from a Mirelurk." },
                            new Items { itemName = "Mutfruit", itemType = "Food", itemEffectValue = 5, itemDesc = "A mutated fruit, slightly restores health." },
                            new Items { itemName = "Antiseptic Bandage", itemType = "Healing", itemEffectValue = 12, itemDesc = "A bandage soaked in antiseptic, heals minor wounds." },
                            new Items { itemName = "Dirty Water", itemType = "Beverage", itemEffectValue = 5, itemDesc = "Water of questionable quality, restores a small amount of health." },
                            new Items { itemName = "Molotov Cocktail", itemType = "Explosive", itemEffectValue = 18, itemDesc = "A bottle filled with flammable liquid, deals fire damage." },
                            new Items { itemName = "Fragmentation Grenade", itemType = "Explosive", itemEffectValue = 20, itemDesc = "A standard grenade that explodes into deadly shrapnel." },
                            new Items { itemName = "Plasma Mine", itemType = "Explosive", itemEffectValue = 24, itemDesc = "A mine that detonates with a burst of plasma energy." },
                            new Items { itemName = "Dynamite Bundle", itemType = "Explosive", itemEffectValue = 30, itemDesc = "A bundle of dynamite sticks, causes a large explosion." },
                            new Items { itemName = "Cryo Grenade", itemType = "Explosive", itemEffectValue = 15, itemDesc = "A grenade that explodes with a freezing blast, slowing enemies." },
                            new Items { itemName = "Cram", itemType = "Food", itemEffectValue = 15, itemDesc = "A can of processed meat, restores a moderate amount of health." },
                            new Items { itemName = "Purified Water", itemType = "Beverage", itemEffectValue = 10, itemDesc = "Clean water, restores a good amount of health." }
                        };
                        Console.WriteLine("Items in the game:\n");
                        foreach (var item in items)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n-- Press any key to return to the collection menu --");
                        Console.ReadLine();
                        break;

                    case "4":
                        // Display all ingredients in a readable format
                        Ingredients[] ingredients =
                        {
                            new Ingredients { ingredientName = "Bread" },
                            new Ingredients { ingredientName = "Lettuce" },
                            new Ingredients { ingredientName = "Tomato" },
                            new Ingredients { ingredientName = "Cheese" },
                            new Ingredients { ingredientName = "Meat" },
                            new Ingredients { ingredientName = "Egg" },
                            new Ingredients { ingredientName = "Potato" },
                            new Ingredients { ingredientName = "Carrot" },
                            new Ingredients { ingredientName = "Onion" },
                            new Ingredients { ingredientName = "Garlic" },
                            new Ingredients { ingredientName = "Salt" },
                            new Ingredients { ingredientName = "Pepper" },
                            new Ingredients { ingredientName = "Drinkable Water" },
                            new Ingredients { ingredientName = "Jam" },
                            new Ingredients { ingredientName = "Milk" },
                            new Ingredients { ingredientName = "Butter" },
                            new Ingredients { ingredientName = "Mushroom" },
                            new Ingredients { ingredientName = "Fish" },
                            new Ingredients { ingredientName = "Apple" },
                            new Ingredients { ingredientName = "Mutfruit" }
                        };
                        Console.WriteLine("Ingredients in the game:\n");
                        foreach (var ingredient in ingredients)
                        {
                            Console.WriteLine(ingredient);
                        }
                        Console.WriteLine("\n-- Press any key to return to the collection menu --");
                        Console.ReadLine();
                        break;

                    case "5":
                        // Display all recipes in a readable format
                        Recipes[] recipes =
                        {
                            new Recipes { recipeName = "Russian Steak", ingredient1 = "Meat", ingredient2 = "Potato", ingredient3 = "Butter" },
                            new Recipes { recipeName = "Nuka-Cola Cake", ingredient1 = "Flour", ingredient2 = "Sugar", ingredient3 = "Nuka-Cola" },
                            new Recipes { recipeName = "Mutfruit Salad", ingredient1 = "Mutfruit", ingredient2 = "Lettuce", ingredient3 = "Tomato" },
                            new Recipes { recipeName = "Radroach Stew", ingredient1 = "Radroach Meat", ingredient2 = "Potato", ingredient3 = "Carrot" },
                            new Recipes { recipeName = "Wasteland Omelette", ingredient1 = "Egg", ingredient2 = "Cheese", ingredient3 = "Onion" },
                            new Recipes { recipeName = "Mirelurk Pie", ingredient1 = "Mirelurk Meat", ingredient2 = "Potato", ingredient3 = "Salt" },
                            new Recipes { recipeName = "Mutant Hound Jerky", ingredient1 = "Mutant Hound Meat", ingredient2 = "Salt", ingredient3 = "Pepper" },
                            new Recipes { recipeName = "Ghoul Goulash", ingredient1 = "Ghoul Meat", ingredient2 = "Carrot", ingredient3 = "Onion" },
                            new Recipes { recipeName = "Irradiated Apple Jam", ingredient1 = "Apple", ingredient2 = "Sugar", ingredient3 = "Jam" },
                            new Recipes { recipeName = "Cheesy Potato Soup", ingredient1 = "Potato", ingredient2 = "Cheese", ingredient3 = "Drinkable Water" },
                            new Recipes { recipeName = "Fried Fish Fillet", ingredient1 = "Fish", ingredient2 = "Butter", ingredient3 = "Salt" },
                            new Recipes { recipeName = "Mushroom Stew", ingredient1 = "Mushroom", ingredient2 = "Onion", ingredient3 = "Drinkable Water" },
                            new Recipes { recipeName = "Egg & Mutfruit Breakfast", ingredient1 = "Egg", ingredient2 = "Mutfruit", ingredient3 = "Milk" },
                            new Recipes { recipeName = "Carrot & Potato Mash", ingredient1 = "Carrot", ingredient2 = "Potato", ingredient3 = "Butter" },
                            new Recipes { recipeName = "Spicy Meat Skewer", ingredient1 = "Meat", ingredient2 = "Pepper", ingredient3 = "Onion" },
                            new Recipes { recipeName = "Garlic Bread", ingredient1 = "Bread", ingredient2 = "Butter", ingredient3 = "Garlic" },
                            new Recipes { recipeName = "Apple Pie", ingredient1 = "Apple", ingredient2 = "Flour", ingredient3 = "Butter" },
                            new Recipes { recipeName = "Mutfruit Jam Toast", ingredient1 = "Toast", ingredient2 = "Mutfruit", ingredient3 = "Jam" },
                            new Recipes { recipeName = "Rad-X Smoothie", ingredient1 = "Rad-X", ingredient2 = "Milk", ingredient3 = "Mutfruit" },
                            new Recipes { recipeName = "Pepper Steak", ingredient1 = "Meat", ingredient2 = "Pepper", ingredient3 = "Butter" }
                        };
                        Console.WriteLine("Recipes in the game:\n");
                        foreach (var recipe in recipes)
                        {
                            Console.WriteLine(recipe);
                        }
                        Console.WriteLine("\n-- Press any key to return to the collection menu --");
                        Console.ReadLine();
                        break;

                    case "0":
                        Welcome();
                        break;

                    default:
                        InvalidInput();
                        break;

                }

                Console.Clear();


            } while (userInput != "0");

            Console.WriteLine("Press any key to return to menu");
            Console.ReadLine();

        }

        static void Exit()
        {
            Console.WriteLine("This is the exit");
            Console.WriteLine("Press any key to close program");
            Console.ReadLine();
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
                Console.WriteLine("Hello. This is your food inventory.\nPress 1 to cook ingredients\nPress 2 to read out your inventory\n\nPress 0 to close the program"); //Menu text
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
                        Console.WriteLine("Food satchel:");
                        for (int i = 0; i < foodSatchel.Length; i++)
                        {
                            Console.WriteLine(foodSatchel[i]);
                        }
                        Console.WriteLine("-- End of food inventory. Press enter to go back to menu");
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
                Console.WriteLine("You are now in the cooking menu. What would you like to do?\n1. Start cooking\n2. Read cookbook\n0. Go back to food inventory");
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
                for (int i = 0; i < foodSatchel.Length; i++)
                {
                    if (foodSatchel[i] == "Bread")
                    {
                        foodSatchel[i] = "Toast";
                        Console.Write("You cooked Toast");
                        break;
                    }
                }
            }
            //Boiling Water
            else if (ingredient1 == "drinkable water")
            {
                for (int i = 0; i < foodSatchel.Length; i++)
                {
                    if (foodSatchel[i] == "Drinkable Water")
                    {
                        foodSatchel[i] = "Boiling Water";
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
            if (ingredient1 == "lettuce" && ingredient2 == "lettuce") //Conditions (Must be in order)
            {
                for (int i = 0; i < foodSatchel.Length; i++)
                {
                    if (foodSatchel[i] == "Lettuce") //First instance of ingredient
                    {
                        foodSatchel[i] = "Salad"; //Change it to result
                        Console.WriteLine("You made Salad");

                        for (int j = 0; j < foodSatchel.Length; j++) //Second instance of ingredient
                        {
                            if (foodSatchel[j] == "Lettuce")
                            {
                                foodSatchel[j] = ""; //Change it to nothing

                                break; //break out of each for loop so that it doesn't change all instances of lettuce (Sorry Krissi)
                            }
                        }
                        break;
                    }
                }
            }
            else if (ingredient1 == "toast" && ingredient2 == "jam")
            {
                for (int i = 0;i < foodSatchel.Length; i++)
                {

                }
            }
            else
            {
                Console.WriteLine("I don't know what to make with this!");
            }
            Console.ReadLine();
        }

        static void tierThree(string ingredient1, string ingredient2, string ingredient3)
        {
            if (ingredient1 == "bread" && ingredient2 == "lettuce" && ingredient3 == "bread")
            {
                for (int i = 0; i < foodSatchel.Length; i++)
                { //Adds sandwich
                    if (foodSatchel[i] == "Bread")
                    {
                        foodSatchel[i] = "Basic Sandwich";
                        Console.WriteLine("You made a Basic Sandwich");
                        for (int j = 0; j < foodSatchel.Length; j++) //Removes second ingredient
                        {
                            if (foodSatchel[j] == "Lettuce")
                            {
                                foodSatchel[j] = "";

                                for (int k = 0; k < foodSatchel.Length; k++) //Removes third ingredient
                                {
                                    if (foodSatchel[k] == "Bread")
                                    {
                                        foodSatchel[k] = "";

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
            if (ingredient1 == "meat" && ingredient2 == "bread" && ingredient3 == "potato")
            {
                for (int i = 0; i < foodSatchel.Length; i++)
                { //Adds Russian Steak
                    if (foodSatchel[i] == "Meat")
                    {
                        foodSatchel[i] = "Russian Steak";
                        Console.WriteLine("You made a Russian Steak");
                        for (int j = 0; j < foodSatchel.Length; j++) //Removes second ingredient
                        {
                            if (foodSatchel[j] == "Bread")
                            {
                                foodSatchel[j] = "";

                                for (int k = 0; k < foodSatchel.Length; k++) //Removes third ingredient
                                {
                                    if (foodSatchel[k] == "Potato")
                                    {
                                        foodSatchel[k] = "";

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
            else if (ingredient1 == "meat" && ingredient2 == "onion" && ingredient3 == "potato")
            {
                for (int i = 0; i < foodSatchel.Length; i++)
                { //Adds borscht
                    if (foodSatchel[i] == "Meat")
                    {
                        foodSatchel[i] = "Borscht";
                        Console.WriteLine("You made Borscht");
                        for (int j = 0; j < foodSatchel.Length; j++) //Removes second ingredient
                        {
                            if (foodSatchel[j] == "Onion")
                            {
                                foodSatchel[j] = "";

                                for (int k = 0; k < foodSatchel.Length; k++) //Removes third ingredient
                                {
                                    if (foodSatchel[k] == "Potato")
                                    {
                                        foodSatchel[k] = "";

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
            else if (ingredient1 == "cheese" && ingredient2 == "potato" && ingredient3 == "eggs")
            {
                for (int i = 0; i < inventory.Length; i++)
                { //Adds Varenniki
                    if (inventory[i] == "Cheese")
                    {
                        inventory[i] = "Varenniki";
                        Console.WriteLine("You made Varenniki");
                        for (int j = 0; j < inventory.Length; j++) //Removes second ingredient
                        {
                            if (inventory[j] == "Potato")
                            {
                                inventory[j] = "";

                                for (int k = 0; k < inventory.Length; k++) //Removes third ingredient
                                {
                                    if (inventory[k] == "Eggs")
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
            else if (ingredient1 == "meat" && ingredient2 == "sour cream" && ingredient3 == "onions")
            {
                for (int i = 0; i < inventory.Length; i++)
                { //Adds Beef Stroganoff
                    if (inventory[i] == "Meat")
                    {
                        inventory[i] = "Beef Stroganoff";
                        Console.WriteLine("You made Beef Stroganoff");
                        for (int j = 0; j < inventory.Length; j++) //Removes second ingredient
                        {
                            if (inventory[j] == "Sour Cream")
                            {
                                inventory[j] = "";

                                for (int k = 0; k < inventory.Length; k++) //Removes third ingredient
                                {
                                    if (inventory[k] == "Onions")
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
            else if (ingredient1 == "pickle" && ingredient2 == "lemon" && ingredient3 == "flour")
            {
                for (int i = 0; i < foodSatchel.Length; i++)
                { //Adds solyanka
                    if (foodSatchel[i] == "Pickle")
                    {
                        foodSatchel[i] = "Solyanka";
                        Console.WriteLine("You made Solyanka");
                        for (int j = 0; j < foodSatchel.Length; j++) //Removes second ingredient
                        {
                            if (foodSatchel[j] == "Lemon")
                            {
                                foodSatchel[j] = "";

                                for (int k = 0; k < foodSatchel.Length; k++) //Removes third ingredient
                                {
                                    if (foodSatchel[k] == "Flour")
                                    {
                                        foodSatchel[k] = "";

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
            else if (ingredient1 == "rice" && ingredient2 == "canned fruits" && ingredient3 == "flower seeds")
            {
                for (int i = 0; i < inventory.Length; i++)
                { //Adds Kutia
                    if (inventory[i] == "Rice")
                    {
                        inventory[i] = "Kutia";
                        Console.WriteLine("You made Kutia");
                        for (int j = 0; j < inventory.Length; j++) //Removes second ingredient
                        {
                            if (inventory[j] == "Canned Fruits")
                            {
                                inventory[j] = "";

                                for (int k = 0; k < inventory.Length; k++) //Removes third ingredient
                                {
                                    if (inventory[k] == "Flower Seeds")
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
            else
            {
                Console.WriteLine("I don't know what to make with this!");
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
