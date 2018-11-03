using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouieS_HW9
{
    class CokeMan: SodaMan        // inherits from SodaMan class
    {
        const int skillLvl = 3; 

        public override void Attack()
        {
            IsAttackSuccessful();        // calls parent class to see if true or false then follows if statements
            if (IsAttackSuccessful() == true)
            {
                Console.WriteLine("CokeMan sprays his Vanilla Diet Coke on you.");
                Console.WriteLine("You have died from heart disease because of all the Coke sprayed on you.");
                Environment.Exit(0);
            }
            else 
            {
                Console.WriteLine("CokeMan missed his shots on you and swifty ran away.");
            }
        }

        public CokeMan(int skillLevel): base(3)     // inherited constructor + base constructor
        {
            int skillLvl = skillLevel;
        }
    }
}
