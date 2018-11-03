using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// nested if statements and switch statements
namespace LouieS_HW9
{
    class Level1
    {
        Level2 lvl2obj = new Level2();
        // nested if statement
        // another while loop if user chooses invalid input
        public static Boolean Basement()
        {
            Level1 lvlobj = new Level1();
            Boolean lebutton = true;
            House houseobj = new House();
            Config configobj = new Config();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You have entered the 1st level. \nThere is a sign as you leave the door that says 'Welcome to Sewerville'. Inside Sewerville you see a floating door. You're unable to reach it but on the ground you find 3 different buttons you can press on which can lower the door. Or you can go back to the house for no reason.");
            Console.ResetColor();
            Console.Write("Which button will you press? Button(1), Button(2), Button(3), House(H) (Q)uit: ");
            string choosebutton = Console.ReadLine().ToUpper();
            //  while loop if user enters <ENTER>
            while (choosebutton == "")
            {
                Console.Write("Which button will you press? Button(1), Button(2), Button(3), House(H) (Q)uit: ");
                choosebutton = Console.ReadLine().ToUpper();
            }

            // another while loop if user enters anything else other than the correect values and <ENTER>
            while (choosebutton != "3" && choosebutton != "H" && choosebutton != "Q" && choosebutton != "1" && choosebutton != "2")

            {
                Console.Write("Which button will you press? Button(1), Button(2), Button(3), House(H) (Q)uit: ");
                choosebutton = Console.ReadLine().ToUpper();
            }
            // do while loop if user chooses a valid value
            do
            {
                switch (choosebutton)
                {
                    case "1":

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You pressed on the first button. You then realized that the button has poison in it. The poison is moving through your body as you panic. After a few seconds, you died.");
                        Console.ResetColor();
                        Environment.Exit(0);
                        break;

                    case "2":

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You pressed on the second button. The door lowered but it was still too high to reach. You notice a green laser right beneath the door. Out of curiosity, you decided to step on the green laser. Suddenly the floating door drops down with insane velocity and crushed you. You died.");
                        Console.ResetColor();
                        Environment.Exit(0);
                        break;
                    case "3":

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You pressed on the third button. The door lowered down to the perfect position. You turned the knob and you see something magical happen. You have teleported to Sewerville");
                        Console.ResetColor();
                        lebutton = false;
                        break;

                    case "Q":
                        configobj.GameEnd();
                        break;
                    case "H":

                        houseobj.ChooseDoor();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You have arrived back at the House doors.");
                        Console.ResetColor();
                        lebutton = false;
                        break;
                }
            }
            while (lebutton == true);
            // do while loop if user wants to go back to house
            do
            {
                lvlobj.FirstArea();
            }
            while (lebutton == false);
            return lebutton;
        }
        public void FirstArea()
        {
            bool correctchoice = true;
            Config configobj = new Config();
            // description of the first area
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("In Sewerville you see what you were expected to see: dirty water, rat infested homes, lots of mossy stone, pipes but most importantly a Buddha looklike figure on a high wall thats stuck onto cobwebs.");
            Console.WriteLine("You decided that you will attempt to touch the Buddha like figure as it might transport you somewhere else.");
            Console.WriteLine("But first you have to find a way to get there. There is a huge gap between you and another structure. It looks like you will need something to cross over the gap filled with dirty water. You decided to look around and you see three different objects you could choose to cross the gap.");
            Console.ResetColor();
            Console.Write("Which object will you choose? (P)lank , (T)oyboat, (W)ings, (Q)uit: ");
            string chooseboat = Console.ReadLine().ToUpper();

            // if user chooses another choice
            while (chooseboat != "T" && chooseboat != "Q" && chooseboat != "P" && chooseboat != "W")
            {
                Console.Write("Which object will you choose? (P)lank , (T)oyboat, (W)ings, (Q)uit: ");
                chooseboat = Console.ReadLine().ToUpper();
            }

            switch (chooseboat)
            {
                case "P":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You decided to choose a plank. You throw the plank onto the dirty water and jumped onto it. But since it's a plank, it can't support your weight. The plank sinks along with you. As you fall into the water, you feel something tingly. Just before you can react, the tingly thing turned into a tentacle and squeezed you to death.");
                    Console.ResetColor();
                    Environment.Exit(0);
                    break;
                case "T":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You decided to choose a toyboat. You decided to throw the toyboat onto the dirty water. Well what do you know! The toyboat turned into a huge sailboat. You go on the sailboat and easily cruise through the dirty water.");
                    Console.ResetColor();
                    correctchoice = false;
                    break;
                case "W":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You decided to choose the wings. You put them on your back and attempted to fly across the water. Halfway there, the wings decided to get stuck on the cobweb. Mini spiders start to appear and gobble the wings up. As the spiders finished eating the wings, you fell into the water and eventually drowned.");
                    Console.ResetColor();
                    Environment.Exit(0);
                    break;
                case "Q":
                    configobj.GameEnd();
                    break;
            }
            // if answer chooses right choice
            do
            {
                FirstArea2();
            }
            while (correctchoice == false);

        }

        // 2nd part of area 1
        // even more while loops
        public void FirstArea2()
        {
            bool correctchoice = true;
            Config configobj = new Config();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Great! You managed to pass the obstacle. You're closer to the Buddha figure. You walked and walked. You feel hungry. Just as your stomach growls, a few edible friends decided to come to you.");
            Console.WriteLine("There were lots of edible foods: pizza, congee, and donut");
            Console.ResetColor();
            Console.Write("Pick something you would like to eat (P)izza, (C)ongee, (D)onut, (Q)uit: ");
            string pickfood = Console.ReadLine().ToUpper();
            while (pickfood != "C" && pickfood != "Q" && pickfood != "D" && pickfood != "P")
            {
                Console.Write("Pick something you would like to eat (P)izza, (C)ongee, (D)onut, (Q)uit: ");
                pickfood = Console.ReadLine().ToUpper();
            }
            switch (pickfood)
            {
                case "P":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You decided to chase down the pizza. You ate the whole box of it and felt really full. When I mean really full, I actually mean really full. Your stomach expanded a lot. It begins to expand at a point where you couldn't take it anymore and then it explodes. You died.");
                    Console.ResetColor();
                    Environment.Exit(0);
                    break;
                case "C":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You decided to pick up the congee and eat it. Inside the congee there was only meat and rice combined with water. Well at least it's better then nothing right? You finished the congee and moved on with your adventure.");
                    Console.ResetColor();
                    correctchoice = false;
                    break;
                case "D":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You decided to eat the donut. Right as you finished eating the donut, a huge donut man appears from the floor. He said he was looking for his son. 'I have no idea where he is.' you said. But after that you let out a huge burp. This made donut man realize that you ate his son. He got pissed and used his donut powers to turn you into a donut. Now you're gonna be his son, FOREVER.");
                    Console.ResetColor();
                    Environment.Exit(0);
                    break;
                case "Q":
                    configobj.GameEnd();
                    break;
            }
            do
            {
                FirstArea3();
            }
            while (correctchoice == false);
        }

        // third part of area 1
        // while loop for invalid answer
        public void FirstArea3()
        {
            Config configobj = new Config();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You're almost there! You're right below the Buddha stone. You just need to find a way to get up there.");
            Console.WriteLine("Perhaps you could use materials on the wall?");
            Console.ResetColor();
            Console.Write("The wall has (L)adder, (R)ope, (S)piderweb Gadget Thing, (Q)uit: ");
            string chooseobject = Console.ReadLine().ToUpper();
            while (chooseobject != "S" && chooseobject != "Q" && chooseobject != "L" && chooseobject != "R" )
            {
                Console.Write("The wall has (L)adder, (R)ope, (S)piderweb Gadget Thing, (Q)uit: ");
                chooseobject = Console.ReadLine().ToUpper();
            }
            switch (chooseobject)
            {
                case "L":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You place the ladder and start climbing up. After three-quarters of the way you hear hissing sound coming from the Buddha figurine. You didn't care and kept climbing. You reached the Buddha figurine! Just as you were about to touch it a giantic spider popped up from the figurine and sucked up your blood.");
                    Console.ResetColor();
                    Environment.Exit(0);
                    break;
                case "R":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You used a rope and threw the other end towards the figurine. You begin to pull yourself up but then realize you were too heavy. The rope snapped and you fell down. The loud thud noise lured many spiders around you. The spiders begin to surround you ate trap you in their webs. Eventually you get spun up into a cocoon and stay in the state of crysalis forever.");
                    Console.ResetColor();
                    Environment.Exit(0);
                    break;
                case "S":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You used the Spiderweb Gadget Thing and got the web onto the Buddha figurine. When you use the Gadget, many mini spiders pop up. The mini spiders form together and pick you up towards the figure. After a few seconds you reached the figure and tapped onto it. The figure begins to glow and glow.");
                    Console.ResetColor();
                    lvl2obj.WhichMonster();
                    break;
                case "Q":
                    configobj.GameEnd();
                    break;
            }
        }
    }
}




