using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LouieS_HW9
{
    class House
    {


        public Setup setupobj;
        public Random randomfood;
        public Outside outsideobj;
        private string Lastname;
        // constant # of moves
        const int SPACES_TO_REACH_NEXT_LVL = 12;

        public void GetLastName()  // getting the last name of the player
        {
            // do while loop if player doesn't enter a name
            do
            {
                Console.Write("Please enter a valid last name : ");
                Lastname = Console.ReadLine().Trim();
            }
            while (Lastname == "");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ResetColor();
            setupobj.GetCharacterName = setupobj.GetCharacterName + "" + Lastname; // getting the full name
            Console.WriteLine("Thank you for your full name: " + setupobj.GetCharacterName);
        }
        public void HouseLevel()
        {
            // ask player how many steps to take 
            Console.Write("Please enter the number of spaces you want to move 0-11: ");
            string pickNum = Console.ReadLine();
            int convertMoves = 0;
            int i = 0;
            Boolean numMoves = int.TryParse(pickNum, out convertMoves);

            // if player chooses invalid number
            while (convertMoves > 11 || convertMoves < 0)
            {
                Console.Write("Please enter the number of spaces you want to move 0-11: ");
                pickNum = Console.ReadLine();
                convertMoves = 0;
                i = 0;
                numMoves = int.TryParse(pickNum, out convertMoves);
            }
            // for loop to keep track of players steps

            for (i = convertMoves; i < convertMoves + 1; i++)
            {
                int totalmoves = 0;
                totalmoves = totalmoves + convertMoves;
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(setupobj.GetCharacterName + " has moved " + convertMoves + " spaces.");
                Console.ResetColor();
                Console.WriteLine(setupobj.GetCharacterName + " has not reached the next level. No need to rush, the house is only getting darker :).");

                // if total moves is less than 12, user repeats moving steps
                while (totalmoves < 12)
                {
                    Console.Write("Please enter the number of spaces you want to move 0-11: ");
                    pickNum = Console.ReadLine();
                    convertMoves = 0;
                    i = 0;
                    numMoves = int.TryParse(pickNum, out convertMoves);
                    while (convertMoves > 11 || convertMoves < 0)
                    {
                        Console.Write("Please enter the number of spaces you want to move 0-11: ");
                        pickNum = Console.ReadLine();
                        convertMoves = 0;
                        i = 0;
                        numMoves = int.TryParse(pickNum, out convertMoves);
                    }
                    for (i = convertMoves; i < convertMoves + 1; i++)
                    {
                        totalmoves = totalmoves + convertMoves;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(setupobj.GetCharacterName + " has moved " + convertMoves + " spaces.");
                        Console.ResetColor();
                        Console.WriteLine(setupobj.GetCharacterName + " has not reached the next level. No need to rush, the house is only getting darker :).");
                    }
                }

                // when user finally reaches 12 or more steps, user advances
                while (totalmoves >= 12)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(setupobj.GetCharacterName + " has reached the next level.");
                    Console.ResetColor();
                    break;
                }
            }
        }

        // continue the story and asking user which door to choose
        public Boolean ChooseDoor()
        {
            Boolean choosetheDoor = true;
            //setupobj.UserFoodInput();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("There are 5 doors in front of you. One of them has a sign saying UP and the other is saying DOWN and the other 3 are LEFT, RIGHT, and CHINA.");
            Console.ResetColor();
            Console.Write("Which door will you choose?  (U)Heaven (D)Hell (L)Left (R)Right (C) China (O) Outside (Q)Quit to quit: ");
            string whichDoor = Console.ReadLine().ToUpper();
            string something = setupobj.GetFood[randomfood.Next(0, setupobj.GetFood.Count)];
            // while loop if player chooses <ENTER> for value
            while (whichDoor == "")
            {
                Console.Write("Which door will you choose?  (U)Heaven (D)Hell (L)Left (R)Right (C) China (O) Outside (Q)Quit to quit: ");
                whichDoor = Console.ReadLine().ToUpper();

            }
            // while loop if user enters anything else other than correct value and <ENTER>
            while (whichDoor != "D" && whichDoor != "Q" && whichDoor != "U" && whichDoor != "L" && whichDoor != "R" && whichDoor != "C" && whichDoor != "O")
            {
                Console.Write("Which door will you choose?  (U)Heaven (D)Hell (L)Left (R)Right (C) China (O) Outside (Q)Quit to quit: ");
                whichDoor = Console.ReadLine().ToUpper();
            }
            // do while loop which allows player to explore each door
            do
            {
                switch (whichDoor)
                {
                    case "U":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You chose to go " + whichDoor + "." + "\nThe door leads you up and up and finally stops. You entered the room. The room is filled with disney posters on the walls and figurines of the floor and some food on the floor. \nThere is also a large screen TV with the movie UP being played. You see nothing else and decided to leave the door. \nAs you leave the door you see " + something + " lying on the floor.");
                        Console.ResetColor();
                        return ChooseDoor();

                    case "D":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You chose to go " + whichDoor + "." + "\nThe door is locked and it requires a key. There is a sign to the left saying roll 2 dies and get a 4 or higher to unlock the door. \nSuddenly 2 dies dropped on the ground. You picked them up and rolled them. ");
                        Console.ResetColor();
                        choosetheDoor = false;
                        break;
                    case "L":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You chose to go " + whichDoor + "." + "\nYou opened the door which said LEFT. Inside, you see an empty classroom with a lot of tables and chairs. In each table, there were malfunctioned robots sitting on a chair. \nAs you look around, you see a chalkboard and lots of souvenirs stuck on the board. You wanted to pick one but somewhere in your mind you felt it was dangerous so you leave the souvenirs on the board and eventually leave the room. \n You accidently stepped on " + something + " before you left the room.");
                        Console.ResetColor();
                        return ChooseDoor();

                    case "R":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You chose to go " + whichDoor + "." + "\nYou opened the door which said RIGHT. The roof is lit up with bright colors which made it look the sun. On the ground you see a massive civilization of what seems to be of elves. \nYou took a step forward and you heard a crack sound. You look below your shoes and saw hundreds of dead elves stuck on it. \nWithout hesitation, the entire population of elves threw" + something + " on you. You couldn't take it anymore and had to leave the room.");
                        Console.ResetColor();
                        return ChooseDoor();
                    case "C":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You chose to go " + whichDoor + "." + "\nYou opened the door which said CHINA. The door magically teleports you to the middle of somewhere which looks like a battlefield. On one side, you see chinese people which were wearing red and on the other blue. This looks like some type of war. \nYou see both sides charging at each other and you had nowhere else to go. Suddenly the sky rains down the light upon you and teleported you back to the doors.");
                        Console.ResetColor();
                        return ChooseDoor();
                    case "Q":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You decided to quit the game.");
                        Environment.Exit(0);
                        break;
                    case "O":                      // if player wanted to go outside
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You decided to go back outside.");
                        outsideobj.DifferentDoors();
                        ChooseDoor();

                        break;

                }
            }
            while (choosetheDoor == true);

            // player chooses the right door and enters level1
            do
            {
                Level1.Basement();
            }
            while (whichDoor == "D");


            return choosetheDoor;
        }

    }
}



