using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Students don't have get this advanced, making sure they understand "if" statements and
            //that they understand "&&" and "||" as well as can error check

            //gets user input as a 1, 2, or 3
            string userChoice = GetUserChoice();

            //Transform number input to color for output
            string userColor = GetThatColor(userChoice);

            //returns random number between 1-6
            int number = RollDie();

            //takes the random number and changes it to either red, white, or blue
            string dieColor = DetermineDieColor(number);

            //Determines the winner by comparing the colors from the random generator and user
            //Outputs color from user and computer as well as if you win or lose
            DecideWinner(userColor, dieColor);
        }

        static string GetUserChoice()
        {
            //Display's instructions and then menu choices
            DisplayChoices();

            string userInput = Console.ReadLine();

            while (!ValidInput(userInput))//Won't let user pick an invalid choice
            {
                Console.Clear();
                Console.WriteLine("Incorrect input, have to choose a number between 1 and 3");
                DisplayChoices();
                userInput = Console.ReadLine();
            }

            return userInput;
        }

        static bool ValidInput(string userInput)
        {
            if (userInput == "1" || userInput == "2" || userInput == "3")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void DisplayChoices()
        {
            Console.Write("In this game, the user will pick a color, and then the computer will roll a die and ");
            Console.WriteLine("determine if it is 'Red', 'White', or 'Blue'");
            Console.WriteLine("\nSelect either 1, 2, or 3:");
            Console.WriteLine("1) Red\n2) White\n3) Blue");
        }

        static string GetThatColor(string userChoice)
        {
            if (userChoice == "1")
            {
                return "Red";
            }
            else if (userChoice == "2")
            {
                return "White";
            }
            else
            {
                return "Blue";
            }
        }

        static int RollDie()
        {
            //Random number generator, gives back a number 1-7
            Random random = new Random();
            int number;
            number = random.Next(5) + 1;

            return number;
        }

        static string DetermineDieColor(int number)
        {
            if (number == 1 || number == 4)
            {
                return "Red";
            }
            else if (number == 2 || number == 5)
            {
                return "White";
            }
            else
            {
                return "Blue";
            }

        }

        static void DecideWinner(string userColor, string dieColor)
        {
            if (userColor == "Red" && dieColor == "Red" || userColor == "White" && dieColor == "White"
            || userColor == "Blue" && dieColor == "Blue")
            {
                Console.WriteLine($"You win!\nUser Choice: {userColor}\nDie Color: {dieColor}");
            }
            else
            {
                Console.WriteLine($"You lose :/\nUser Choice: {userColor}\nDie Color: {dieColor}");
            }
        }

    }
}
