using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouieS_HW9
{
    class MouthWashMan : Iedible  // created this class cause I needed 5
    {
        private int numChunks = 3;

        public void Bite()          // bite method for this guy
        {
            Config configobj = new Config();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("After winning the sodaweight championship, a new challenger appears. His name is MouthWashMan. He seems harmless and you felt thirsty. You also see MouthWashMan holding some Listerine.");
            Console.ResetColor();
            Console.Write("What do you want to do with MouthWashMan?: (R)inse your mouth, (S)pit, (D)rink the Listerine, (Q)uit: ");
            string colgate = Console.ReadLine().ToUpper();
            while (colgate != "R" && colgate != "S" && colgate != "D" && colgate != "Q")                                     // if user chooses invalid option
            {
                Console.Write("What do you want to do with MouthWashMan?: (R)inse your mouth, (S)pit, (D)rink the Listerine, (Q)uit: ");
                colgate = Console.ReadLine().ToUpper();

            }
            for (int numChunks = 3; numChunks >= 0; numChunks--)      // forloop making player do something at least 3 times
            {
                while (colgate != "R" && colgate != "S" && colgate != "D" && colgate != "Q")                                     // if user chooses invalid option
                {
                    Console.Write("What do you want to do with MouthWashMan?: (R)inse your mouth, (S)pit, (D)rink the Listerine, (Q)uit: ");
                    colgate = Console.ReadLine().ToUpper();

                }
                Console.Write("What do you want to do with MouthWashMan?: (R)inse your mouth, (S)pit, (D)rink the Listerine, (Q)uit: ");
                colgate = Console.ReadLine().ToUpper();
                switch (colgate)          // if user chooses one of the options
                {

                    case "R":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You have rinsed your mouth with Listerine. It is now squeaky clean.");
                        Console.ResetColor();
                        break;
                    case "S":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You spit at MouthWashMan and he disintegrated cause your breath smells bad. ");
                        Console.ResetColor();
                        break;
                    case "D":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You begin drinking the Listerine. ????????? ");
                        Console.ResetColor();
                        break;
                    case "Q":
                        configobj.GameEnd();
                        break;
                }
            }
            Environment.Exit(0);
        }

        public Boolean IsConsumed()
        {
            if (numChunks > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
