using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// there is a switch statement here
namespace LouieS_HW9
{
    class Creature
    {
        // create an array of attributes so player gets random each time
        public int[] health = new int[10];
        public int[] amtWater = new int[10];
        public int[] agility = new int[10];
        public int[] intelligence = new int[10];
        public int[] feet = new int[10];

        // dice method to populate the array
        Random dice = new Random();

        // populate the array
        public void PopulateStats()
        {
            for (int i = 0; i < health.Length; i++)
            {
                health[i] = dice.Next(10, 21);
            }
            for (int i = 0; i < amtWater.Length; i++)
            {
                amtWater[i] = dice.Next(1, 100);
            }
            for (int i = 0; i < agility.Length; i++)
            {
                agility[i] = dice.Next(1, 11);
            }
            for (int i = 0; i < intelligence.Length; i++)
            {
                intelligence[i] = dice.Next(0, 5);
            }
        }
        // creature greeting
        public void AnimalGreeting()
        {
            PopulateStats();
            Creature Pspringman1 = new Creature();
            Creature Pspringman2 = new Creature();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("As you were about to step to the left doors, you see two PolandSpring lookalikes pop up.\nBoth PolandSpring men had a huge bottle covered onto them water on the bottle.\nThe first one seems to look like hes about to fall.\nIt seems that the PolandSpring men are blocking you from entering the doors.");
            Console.WriteLine("PolandSpringman1 has " + health[dice.Next(0, 10)] + " health " + amtWater[dice.Next(0, 10)] + " liters of water " + agility[dice.Next(0, 10)] + " agility " + intelligence[dice.Next(0, 10)] + " intelligence " + feet[dice.Next(0,10)]   + " feet.");
            Console.WriteLine("PolandSpringman2 has " + health[dice.Next(0, 10)] + " health " + amtWater[dice.Next(0, 10)] + " liters of water " + agility[dice.Next(0, 10)] + " agility " + intelligence[dice.Next(0, 10)] + " intelligence " + feet[dice.Next(0, 10)] + " feet.");
            Console.ResetColor();
        }

        // player encounters the monster and will have to decide what to do
        // there is a while loop if player doesn't choose valid choices
        public void ChooseStatement()
        {
            Console.Write("What will you do?: <t> to tip the PolandSpring men <s> to scream at them <q> to quit game: ");
            string decision = Console.ReadLine().ToUpper();
            while (decision != "Q" && decision != "T" && decision != "S")
            {
                Console.Write("What will you do?: <t> to tip the PolandSpring men <s> to scream at them <q> to quit game: ");
                decision = Console.ReadLine().ToUpper();
            }
            switch (decision)
            {
                case "T":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You tipped the PolandSpring men over and they all died. You walked passed them and enter the door.");
                    Console.ResetColor();
                    break;
                case "S":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You decided to scream at the PolandSpring men. The bottle pops and the water flows out. \nThe PolandSpring men lie dead on the ground. You walked passed them and entered the door.");
                    Console.ResetColor();
                    break;
                case "Q":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You decided you can't handle these 2 punks and quit the game.");
                    Console.ResetColor();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}


