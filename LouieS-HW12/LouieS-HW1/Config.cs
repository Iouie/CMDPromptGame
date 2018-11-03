using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouieS_HW9
{
    class Config

    {

        public Setup setupobj = new Setup();
        Random dice1 = new Random();

        // creating another dice method
        public int diceroll(int smallnum, int bignum)
        {
            int d1Roll = dice1.Next(1, 7);
            return d1Roll;
        }

        // overloaded dice method
        public int diceroll(int smallnum, int bignum, int somethingelse)
        {
            int d1Roll = dice1.Next(1, 7);
            return d1Roll;
        }
        public Boolean DiceMethod()
        {
            // creating a dice object
            Config obj1 = new Config();
            Random dice1 = new Random();        // only created 1 instance b/c using 2 would make the dice roll the same


            //generate a random number generator and sum of 2 dice rolls
            int d1Roll = obj1.diceroll(1, 7); // creates a random roll for dice1
            int d1Roll2 = obj1.diceroll(1, 7, 10); // creates a random roll for dice2
            int sumDice = d1Roll + d1Roll2;
            Boolean dicebool = Convert.ToBoolean(sumDice);

            Console.WriteLine("You rolled a " + d1Roll + " and a " + d1Roll2);

            // if statements to see what the player rolled

            if (sumDice >= 4)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Congratulations, " + setupobj.GetCharacterName + " rolled a sum of " + sumDice + ". The key magically appear in your pocket!" + "\nYou used the key to unlock the door.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(setupobj.GetCharacterName + " rolled a " + sumDice + " which is clearly less than 4 if you have taken a math class. ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("5 golems appeared from this magical die and stomped you to death. You have died!");
                Console.ResetColor();
                Environment.Exit(0);
            }
            return dicebool;
        }

        // creating an ending for game
        public void GameEnd()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("5 golems appeared from a magical die and stomped you to death. You have died!");
            Console.ResetColor();
            Environment.Exit(0);
        }
    }
}
