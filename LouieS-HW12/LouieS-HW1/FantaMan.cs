using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouieS_HW9
{
    class FantaMan : Iedible     // created this class cause I needed 5
    {
        MouthWashMan mouth = new MouthWashMan();
        private Boolean isConsumed = false;
        public void Bite()
        {
            Config configobj = new Config();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("After winning the sodaweight championship, a new challenger appears. His name is FantaMan. He seems harmless and you felt thirsty. You also see FantaMan holding on to bottles of Coke and Pepsi.");
            Console.ResetColor();
            Console.Write("What do you want to do with FantaMan?: (D)rink him, Drink (P)epsi, Drink (C)oke, (Q)uit: ");
            string drinkhim = Console.ReadLine().ToUpper();
            while (drinkhim != "D" && drinkhim != "Q" && drinkhim != "P" && drinkhim != "C")                                     // if user chooses invalid option
            {
                Console.Write("What do you want to do with FantaMan?: (D)rink him, Drink (P)epsi, Drink (C)oke, (Q)uit: ");
                drinkhim = Console.ReadLine().ToUpper();
            }
            switch (drinkhim)          // if user chooses one of the options
            {
                case "D":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You have drank the whole bottle of FantaMan. It was delicious.");
                    Console.ResetColor();
                    isConsumed = true;
                    break;
                case "P":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You take the Pepsi bottle from FantaMan and gulped down the Pepsi.");
                    Console.ResetColor();
                    isConsumed = false;
                    break;
                case "C":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You take the Coke bottle from FantaMan and gulped down the Coke.");
                    Console.ResetColor();
                    isConsumed = false;
                    break;
                case "Q":
                    configobj.GameEnd();
                    break;
            }
            //if player decides to drink the same drink
            do
            {
                Console.Write("What do you want to do with FantaMan?: (D)rink him, Drink (P)epsi, Drink (C)oke, (Q)uit: ");   // user doesnt finish drinking yet
                drinkhim = Console.ReadLine().ToUpper();
                switch (drinkhim)          // if user chooses one of the options
                {
                    case "D":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You have drank the whole bottle of FantaMan. It was delicious.");
                        Console.ResetColor();
                        isConsumed = true;
                        break;
                    case "P":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You almost finished this drink. ");
                        Console.ResetColor();
                        isConsumed = false;
                        break;
                    case "C":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You almost finished this drink. ");
                        Console.ResetColor();
                        isConsumed = false;
                        break;
                    case "Q":
                        configobj.GameEnd();
                        break;
                }
            }
            while (isConsumed == false);
            if (isConsumed == true)
            {
                Console.WriteLine("You drank everything.");
                mouth.Bite();
            }
        }

        public Boolean IsConsumed()
        {
            return isConsumed;
        }
    }
}
