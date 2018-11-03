using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouieS_HW9
{
     abstract class SodaMan        // parent of Pepsiman and CokeMan
    {
        private int attackSkill;
        Random diceroll = new Random();
        public abstract void Attack();        // created an abstract attack method

        public int AttackSkill   // accessor and mutator to get attack
        {
            get
            {
                return attackSkill;
            }
            set
            {
                attackSkill = value;
            }
        }
        protected Boolean IsAttackSuccessful()    // boolean method to check if attack is successfull
        {

            int rolldice = diceroll.Next(1, 7);
            if (attackSkill >= rolldice)
            {
               // Console.WriteLine("The attack is successful.");
                return true;
            }
            else
            {
              //  Console.WriteLine("The attack failed.");
                return false;
            }
        }
        public SodaMan(int attSkill)    // constructor
        {
            attackSkill = attSkill;

        }
        

    }
}
