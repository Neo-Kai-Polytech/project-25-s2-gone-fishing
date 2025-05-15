namespace UberProject
{
    internal class Program
    {
        private static Random random = new Random();
        private static int Task;
        static string[] inventory = ["", "", "", "", "", "", "", "", "", ""]; //Inventory of 10 slots, all same empty value to check if slots are empty


        static void Welcome()
        {
            Console.WriteLine("FLAVOURS OF FALLOUT");
            Console.WriteLine();
            Console.WriteLine("The Menu options are:");
            Console.WriteLine("1  New Game");
            Console.WriteLine("2  Options");
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

            Console.WriteLine("So the story starts with World War III Apocalypse where all countries were on war. Lost of lives were lost, families got ruined. Not only damage is done to the humans, nature also paid the price animal species got extinct, air pollution went to the next level." +
                "In the war many comunities were lost, world population got half, darkness is now spreading every corner of the world.People praying to the God to restore the balance of the world and some still have belief someone will a messiah will come and everything will come back to original.");

            Console.WriteLine("Press any key to know about the main character");
            Console.ReadLine();


            // Lead to Character Creation?
            CharacterCreation();


        }

        static void CharacterCreation()

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

            int events;
        Console.WriteLine("Where would want to go first?");
            Console.WriteLine("The options are:");
            Console.WriteLine("Event 1");
            Console.WriteLine("Event 2");
            Console.WriteLine("Event 3");
            Console.WriteLine("Event 4");
            events = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            switch(events)
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
        }
        




        // Lead to first Starting Area?

        StartingArea();

        }
        static void event1()
        {
            Console.WriteLine("Continuing his journey now he reached Russia where he saw that everything is destroyed.He is findind any life which is still alive and can talk with them. He is in a dense forest right now.");
            //where do you wanna go/
            Thread.Sleep(500);
            Console.WriteLine("You see a bear running towards you.");
            Console.WriteLine("what do you wannna do run or fight ?");
            //during fight bear hp will come
            //If he fights he will kill him and with the fighting sounds people will come and meet him
            //If he runs he will find a village and they all together giht the bear and will kill the bear and enjoy the steak.
            //here we can add some combat things and can give hp to the person and bear, he can also use various things like sword or something to fight.
            Console.WriteLine("");
            Console.ReadLine();

        }

        static void event2()
        {
            

        }

        static void event3()
        {
            

        }

        static void event4()
        {
            

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
            int enemyHealth = random.Next(30, 45);

            int playerIniative = random.Next(0, 10);
            int enemyIniative = random.Next(0, 10);

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
            Console.WriteLine("Hello. This is your inventory.\nPlease press 1 to scavenge for ingredients\nPlease press 2 to read out your inventory\n\nPlease press Anything else to close the program"); //Menu
            input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            do
            {
                switch (input)
                {
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                    case 0:
                        Console.WriteLine("Exiting inventory now");
                        break;
                    case 1: //Scavenges for ingredients and puts it in an empty slot in your inventory
                        Scavenge();
                        break;
                    case 2: //Shows you your inventory
                        for (int i = 0; i < inventory.Length; i++)
                        {
                            Console.WriteLine(inventory[i]);
                        }
                        break;
                }

                Console.WriteLine("Please enter in your next input\nPress 1 to scavenge for ingredients\nPress 2 to read out your inventory\n\nPress Anything else to close the program");
                input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (input != 0);
        }

        static void Scavenge() //Ingredients are placeholder. Can be added on to
        {
            int searchCase;
            searchCase = random.Next(1, 5); //Decides what you find
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

