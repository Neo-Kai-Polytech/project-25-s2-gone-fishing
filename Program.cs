namespace UberProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //luke Writes here
            string myName = "My name is Luke Ari Patel.";
            string[] split = myName.Split(' ');
            

            foreach (string word in split)
            {
                Console.WriteLine(word);
                Thread.Sleep(300);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYou are red now.\n");








            //Jacques Writes here


            Console.WriteLine("Hey Everybody, its your friendly local South African Kiwi guy here, wishing you all a great day!" +
                "Please tell me new thing about yourself that you think is more unique to yourself");


            int explosion = 2;

            for (int i = 0; i < 50; i++)
            {
                explosion = 2 * explosion;
                Console.WriteLine(explosion);
                Thread.Sleep(100);
            }

            Console.ReadLine();








            //karl Writes here

            Console.ForegroundColor = ConsoleColor.Blue;
            string  foxString = "The quick brown fox jumps over the lazy dog.     ", hairyFox, foxCopy;


            foxCopy = foxString.Replace("dog", "chicken");
            hairyFox = foxCopy.Insert(9, " hairy").Trim();
            Console.WriteLine("\n" + hairyFox);

            Console.ReadLine();


        }
    }
}
