using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouieS_HW9
{
    class Level2
    {
        public Config configobj = new Config();
        public Random morediceroll = new Random();
        public SodaMan sodaobj;      // parent class obj
        public FantaMan fanta = new FantaMan();

        public void WhichMonster()
        {
            morediceroll.Next(1, 3);    // created a diceroll from 1 to 2 
            if (morediceroll.Next(1, 3) == 2)       // if player rolls 2, he encounters PepsiMan otherwise CokeMan
            {
                PepsiMan sodaobj = new PepsiMan(5);   // Polymorphism
                Console.WriteLine("The Buddha figure has teleported you to a wrestling ring. You have encountered a can with a Pepsi on it.");
                Console.Write("What would you like to do to it? (C)lothesline (T)ouch (S)uplex (Q)uit: ");
                string choosemove = Console.ReadLine().ToUpper();
                while (choosemove != "C" && choosemove != "Q" && choosemove != "T" && choosemove != "S")
                {
                    Console.Write("What would you like to do to it? (C)lothesline (T)ouch (S)uplex (Q)uit: ");
                    choosemove = Console.ReadLine().ToUpper();
                }
                switch (choosemove)
                {
                    case "C":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You decided to clothesline the PepsiMan can and you ruined his dreams of becoming the sodaweight champion.");
                        Console.ResetColor();
                        fanta.Bite();
                        break;
                    case "T":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You decided to touch the PepsiMan.");
                        sodaobj.Attack();      // calls the attack method for pepsiman
                        Console.ResetColor();
                        fanta.Bite();
                        break;
                    case "S":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You decided to suplex the PepsiMan can and you ruined his dreams of becoming the sodaweight champion. ");
                        Console.ResetColor();
                        fanta.Bite();
                        break;
                    case "Q":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        configobj.GameEnd();
                        Console.ResetColor();

                        break;
                }
            }
            else
            {
                CokeMan sodaobj = new CokeMan(3);  // Polymorphism 
                Console.WriteLine("The Buddha figure has teleported you to a wrestling ring. You have encountered a can with a Coke on it.");
                Console.Write("What would you like to do to it? (C)lothesline (T)ouch (S)uplex (Q)uit: ");
                string choosemove = Console.ReadLine().ToUpper();
                while (choosemove != "C" && choosemove != "Q" && choosemove != "T" && choosemove != "S")
                {
                    Console.Write("What would you like to do to it? (C)lothesline (T)ouch (S)uplex (Q)uit: ");
                    choosemove = Console.ReadLine().ToUpper();
                }
                switch (choosemove)
                {
                    case "C":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You decided to clothesline the CokeMan can and you ruined his dreams of becoming the sodaweight champion.");
                        Console.ResetColor();
                        fanta.Bite();
                        break;
                    case "T":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You decided to touch the CokeMan.");
                        sodaobj.Attack();           // calls the attack method for cokeman
                        Console.ResetColor();
                        fanta.Bite();
                        break;
                    case "S":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You decided to suplex the CokeMan can and you ruined his dreams of becoming the sodaweight champion. ");
                        Console.ResetColor();
                        fanta.Bite();
                        break;
                    case "Q":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        configobj.GameEnd();
                        Console.ResetColor();

                        break;
                }
            }
        }
    }
}
