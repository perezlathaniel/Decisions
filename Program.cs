using System.Security.Cryptography.X509Certificates;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lathaniel's Big Giveaway!");
            Console.Write("Choose a door: 1, 2, 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
            {
                message = "You won a new car!";
                Console.WriteLine(message);
            }

            else if (userValue == "2")
            {
                message = "Sorry, you did not win a car. Try again next time.";
                Console.WriteLine(message);
            }

            else if (userValue == "3")
            {
                message = "Sorry, you did not win a car. Try again next time.";
                Console.WriteLine(message);
            }

            else
            {
                message = "Sorry, we didn't understand. Please choose a valid selection next time.";
                Console.WriteLine(message);
            }

            Console.WriteLine(message);
            Console.ReadKey();

        }

    }
}