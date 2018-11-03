using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Stanley Louie
 * IGME 105
 * Purpose - to create a game using command lines
 * goal - loops
 */
namespace LouieS_HW9
{
    class TestGame
    {
        public static List<string> Userfood = new List<string>();  // creating list of food
        static void Main(string[] args)
        {


            // creating objects
            TestGame progobj = new TestGame();
            Setup setupobj = new Setup();
            Outside outsideobj = new Outside();
            House houseobj = new House();
            Level1 lvl1obj = new Level1();
            Level2 lvl2obj = new Level2();
            Creature creatureobj = new Creature();
            Creature creature2obj = new Creature();
            Config configobj = new Config();
            houseobj.randomfood = new Random();
            houseobj.outsideobj = outsideobj;
            CokeMan cokeobj = new CokeMan(3);
            PepsiMan pepsiobj = new PepsiMan(5);
            Level3 lvl3obj = new Level3();


            // calling the methods
            setupobj.GetName();
            setupobj.AskUser();
            setupobj.UserFoodInput();
            setupobj.Intro();
            outsideobj.OutsideHouse();
            creatureobj.feet = setupobj.GetUserNums;
            creatureobj.AnimalGreeting();
            creatureobj.ChooseStatement();
            outsideobj.DifferentDoors();
            houseobj.setupobj = setupobj;
            houseobj.GetLastName();
            houseobj.HouseLevel();

            // create 5 same methods for the 5 different rooms
            houseobj.ChooseDoor();
            if (configobj.DiceMethod() == true)
            {
                Level1.Basement();
            }
            else
            {
                configobj.GameEnd();
            }
            lvl1obj.FirstArea();
            lvl1obj.FirstArea2();
            lvl1obj.FirstArea3();
            lvl2obj.WhichMonster();
            lvl3obj.Lvl3();
        }

    }

}



