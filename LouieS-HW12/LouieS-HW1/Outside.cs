using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouieS_HW9
{
    class Outside
    {

        const string theColors = "red,green,blue,cyan,magenta,yellow,navy,white";
        public void OutsideHouse()
        {
            // choosing the color outside

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You somehow spawned right in front of a building and see 8 colors on top of it (red,green,blue,cyan,magenta,yellow,navy,white) in that order. Please choose the 3rd color.");
            Console.ResetColor();
            Console.Write("You picked the color " + theColors.Substring(theColors.IndexOf("blue"),4));
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nSuddenly a giant blue monster appears from the color scheme and wrecks havoc on the door. The door breaks down. \nYou entered through the door.");
            Console.ResetColor();

        }
        // creating 5 different rooms for the door
        public void DifferentDoors()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("As the door breaks down, you decided to walk in.\nThere are 7 different doors that appear, 5 on the left, and 2 on the right. \nThe doors on the left labeled UP,DOWN,LEFT,RIGHT, and CHINA. \nThe other two doors on the right labeled \nDonec pellentesque tellus a justo vestibulum,Proin tincidunt massa dictum velit sollicitudin, and In ultrices interdum risus quis dapibus.\nYou don't understand what anything on the right means so you decided not to bother with it.");
            Console.ResetColor();
        }
        

    }
}
