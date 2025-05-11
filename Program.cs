namespace UberProject
{
    internal class Program
    {
         private static int Task;

        static void Welcome()
        {
            Console.WriteLine("FLAVOURS OF FALLOUT");
            Console.WriteLine();
            Console.WriteLine("The Menu options are:");
            Console.WriteLine("1  New Game");
            Console.WriteLine("2  Options");
            Console.WriteLine();
            Console.WriteLine("0  Exit menu system");
        }

        static void Task1()
        {
            // NEW GAME CREATION --> Lead to Character Creation and Start of Story

            Console.WriteLine("This is Task 1");

            CharacterCreation();

            Console.WriteLine("Press any key to return to menu");
            Console.ReadLine();

        }

        static void CharacterCreation()

        {
            // List Character Options??

            Console.WriteLine();

            // Print to Screen Main Story Summary?

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

