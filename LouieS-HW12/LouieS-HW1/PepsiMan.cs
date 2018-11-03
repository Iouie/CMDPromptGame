using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouieS_HW9
{
    class PepsiMan:SodaMan      // inherits from sodaman class
    {
        const int skillLevel = 5;

        public override void Attack()
        {
            IsAttackSuccessful();          // calls the parent class to see if it's true or false
            if (IsAttackSuccessful() == true)
            {
                Console.WriteLine("PepsiMan forces you to look at his commercial.");
                Console.WriteLine("You realized how bad the Pepsi commercial was and died.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("PepsiMan proceeds to run away.");
            }
        }

        public PepsiMan(int skilllvl):base(5)     // constructor + base constructor
        {
            int skillLevel = skilllvl;
        }
    }
}
