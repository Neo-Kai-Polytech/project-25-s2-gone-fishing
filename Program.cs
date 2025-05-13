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
            // Print to Screen Main Story Summary?

            Console.WriteLine("This is the main story");

            Console.WriteLine("Press any key to go to Character Creation");
            Console.ReadLine();


            // Lead to Character Creation?
            CharacterCreation();


        }

        static void CharacterCreation()

        {
            // List Character Options??

            Console.WriteLine("This is where you can choose or create your Character");


            Console.WriteLine("Press any key to move on to the Starting Area");
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
            int enemyHealth = random.Next(30,45);

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

