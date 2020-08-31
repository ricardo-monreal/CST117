using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_06_Console
{
    class Program
    {
        class Dice
        {
            static int diceOne;
            static int diceTwo;
            static int rollCount = 0;


            public static void RollDie()
            {

                bool isSnakeEyes = false;

                
                Random random = new Random();

                // A constructor that takes an integer between 4 and 20, inclusive and sets the number of sides of the die
                // Sets the amount of sides for the dice
                int dieSides = random.Next(4, 21);
                Console.WriteLine("A set of dice was created with " + dieSides + " sides.\n");
                Console.WriteLine("Press Any key to start rolling!");
                Console.ReadKey();

                while (isSnakeEyes == false)
                {
                    // Counter will keep track of rolls
                    rollCount++;

                    System.Threading.Thread.Sleep(25);

                    //Use a Random number to “roll” the die.
                    //Random rand1 = new Random();
                    //diceOne = rand1.Next(1, dieSides);
                    int rand1 = random.Next(1, dieSides);
                    diceOne = rand1;

                    //Random rand2 = new Random();
                    //diceTwo = rand2.Next(1, dieSides);
                    int rand2 = random.Next(1, dieSides);
                    diceTwo = rand2;

                    Console.WriteLine("roll # " + rollCount + ":  " + "The first die landed on " + diceOne + " : The second die landed on " + diceTwo);
                    //Checks if rolled snake eyes
                    if (diceOne == 1 && diceTwo == 1)
                    {
                        isSnakeEyes = true;
                        Console.WriteLine("It took you " + rollCount + " rolls to get snake eyes.");


                    }

                }


            }

            static void Main(string[] args)
            {
                do
                {
                    RollDie();

                }
                while (PlayAgain());

                //Console.WriteLine("\nThanks for playing! press any key to exit.");
                //Console.ReadKey();

            }

            static public bool PlayAgain()
            {
                while (true) // Continue asking until a correct answer is given.
                {
                    Console.Write("Do you want to play again [Y/N]?");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                        return true;
                    if (answer == "N")
                        return false;
                }
            }
        }
    }
}