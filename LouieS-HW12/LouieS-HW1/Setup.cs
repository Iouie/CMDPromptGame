using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouieS_HW9
{
    class Setup
    {            // BASIC STORYLINE

        /* Game name- Louie's House
         * User enters his/her name
         * The game starts with the player waking up having a really bad headache which eventually turns
         * out to be amnesia.
         * The player looks around and sees and realizes he/she is in an empty house with a path and a sign saying "Reach the end of my game to win a prize!"
         * The player then has to follow the path (Forward) and eventually it will lead up to 2 doors: one door says up and one says down.
         * Up leads to nowhere and you will eventually starve to death and down leads to Memeworld which you will enter.
         * Level 1 Memeworld, there are 4 meme posters and a door. The door has 4 empty slots which require something to fill in.
         * You can interact with 4 posters. Each poster teleports you to a different room and the room requires player interaction in order to get a dank-meme key to unlock the door
         * Player inserts all dank keys and door opens. Door shuts as player sees nothing ahead. Suddenly gas appears and player loses conscious.
         * Player enters 2nd area which has pictures of WWE superstars, belts and hall of famers.
         * Player sees 4 curtains each labeled, Royal Rumble, Survivor Series, Summerslam, and Royal Rumble
         * Player has to enter each curtain and fight bosses with the last being Wrestlemania;
         *  Player has to win match using certain interactions to receive the most prestigious belt being the "Champ of Louie"
         * If player loses, player gets buried alive
         * After receiving belt, a magical fifth curtain pops out and player will walk through it reaching the final stage.
         * Level 3, a magical Zoidberg looking guy appears and gives you a sword and bait. He explains that his daughter was kidnapped by some dude and asks you to help him retrieve her back
         * Player uses sword and bait to fight final boss Lord Jaegar (this dude has 4 different levels so you gotta kill him 4 times)
         * There are also four different rooms where the boss hides
         * In order for him to pop out, player has to use some sort of bait and run to a certain color room with correct bait
         * If player uses wrong bait or wrong room, zoidberg look alike gets pissed and teleports player to nothingess
         * After player wins, he retrieves daughter from bosses body and a light wil shine
         * Follow the light to get prize, if you don't zoidberg lookalike will claim you as his son
         */


        // created an array to ask user for 10 nums
        private int[] usernums = new int[10];
        private List<string> Userfood = new List<string>();  // creating list of food

        private string CharacterName;   // store main character name
        // intro of the game
        public string GetCharacterName // allows GET and SET for user name
        {
            get
            {
                return this.CharacterName;
            }
            set
            {
                CharacterName = value;
            }
        }
        public int[] GetUserNums  // allows GET and SET for user nums
        {
            get
            {
                return usernums;
            }
            set
            {
                usernums = value;
            }
        }

        public List<string> GetFood // allows GET and SET for food
        {
            get
            {
                return Userfood;
            }
            set
            {
                Userfood = value;
            }
        }
        public void GetName()
        {
            //game name
            Console.WriteLine("Welcome to Louie's House");
            Console.WriteLine("************************");


            // do while loop if player doesn't enter a name
            do
            {
                Console.Write("Please enter a valid name : ");
                CharacterName = Console.ReadLine().Trim();
            }
            while (CharacterName == "");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Louie's House " + CharacterName + " I hope you enjoy your stay!");
            Console.ResetColor();
            Console.WriteLine();
        }

        public void Intro()
        {// narration and instructions
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Louie's House is an interactive text based game. \nPlayer will be asked to do certain interactions in order to win. \nIf player chooses the wrong interaction, player dies. \nThere will be 3 levels that the player has to go through. \nAs you increase in level, the difficulty will also increase. \nGood luck, have fun, and don't die!");
            Console.ResetColor();
            Console.WriteLine();


            // ask if you want to play game, too bad you're forced to play 

            Console.Write("Do you want to continue?   Y/N : ");
            string answer = Console.ReadLine().ToUpper();
            string subCaps = answer.ToUpper();

            // while loop if player enters anything else other than Y or N

            while (subCaps != "Y" && subCaps != "N")
            {
                Console.Write("Do you want to continue?   Y/N : ");
                answer = Console.ReadLine().ToUpper();
                subCaps = answer.ToUpper();
            }

            if (subCaps == "Y")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Time to play the game!");
                Console.ResetColor();
            }
            else if (subCaps == "N")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Too bad you're playing anyway HAHA\n");
                Console.ResetColor();
            }
        }

        // ask user for the 10 numbers
        public void AskUser()
        {
            for (int i = 0; i < usernums.Length; i++)
            {
                Console.Write("Please enter integer number {0} (10-100):", i + 1);
                string userinput = Console.ReadLine();
                int userint = 0;
                bool userparsed = int.TryParse(userinput, out userint);
                usernums[i] = userint;
                Console.WriteLine("You have entered {0}", usernums[i]);
                while (userparsed == false || (userint > 100 || userint < 10))
                {
                    Console.Write("Please enter a valid number (10-100), Your number was not valid:");
                    userinput = Console.ReadLine();
                    userint = 0;
                    userparsed = int.TryParse(userinput, out userint);
                    usernums[i] = userint;
                    Console.WriteLine("You have entered {0}", usernums[i]);
                }
            }

            // display the 10 numbers
            for (int i = 0; i < usernums.Length; i++)
            {
                Console.WriteLine("Your numbers are: " + usernums[i]);
            }
        }

        // ask user for the food
        public void UserFoodInput()
        {
            Console.WriteLine("We want you to engage more into and the game. So we're going to ask you to implement some of your favorite food.");
            Console.Write("You may enter as many food as you want, 1 per prompt. \nPlease enter a food name:");
            string foodname = Console.ReadLine();
            int food = 0;
            bool foodboolvalue = int.TryParse(foodname, out food);

            // if the user just presses enter
            while (string.IsNullOrEmpty(foodname))
            {
                Console.Write("You may enter as many food as you want, 1 per prompt. \nPlease enter a valid food name:");
                foodname = Console.ReadLine();
            }
            Console.WriteLine("You have chosen {0}", foodname);
            Console.Write("Would you like to add more food? Y/N: ");
            string morefood = Console.ReadLine().ToUpper();
            Boolean somevalue = true;
            Userfood.Add(foodname);

            // if the user presses enter or anything other than Y or N
            while (string.IsNullOrEmpty(morefood) || (morefood != "Y" && morefood != "N"))
            {
                Console.WriteLine("Would you like to add more food?: Y/N");
                morefood = Console.ReadLine().ToUpper();

            }
            // if the user presses "Y" it will prompt for another food
            while (morefood == "Y" && somevalue == true)
            {
                Console.Write("You may enter as many food as you want, 1 per prompt. \nPlease enter a food name:");
                foodname = Console.ReadLine();
                somevalue = true;

                // if the user presses enter for food it will repeat itself
                while (string.IsNullOrEmpty(foodname))
                {
                    Console.Write("You may enter as many food as you want, 1 per prompt. \nPlease enter a valid food name:");
                    foodname = Console.ReadLine();
                }
                Userfood.Add(foodname);
                Console.WriteLine("Would you like to add more food?: Y/N");
                morefood = Console.ReadLine().ToUpper();

                // if the user presses enter or any other value other than Y or N, it will repeat itself
                while (string.IsNullOrEmpty(morefood) || (morefood != "Y" && morefood != "N"))
                {
                    Console.WriteLine("Would you like to add more food?: Y/N");
                    morefood = Console.ReadLine().ToUpper();
                }
            }

            // if the user is done adding food
            while (morefood == "N" && somevalue == true)
            {
                somevalue = false;
                string convertedList = string.Join(",", Userfood.ToArray());
                Console.WriteLine("You have chosen these food: " + convertedList);

            }

        }

        // returning the list
        //    public List<string> GetList()
        //   {
        //      return Userfood;
        //   }
    }
}



