using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouieS_HW9
{
    class Level3
    {
        FantaMan fantaobj = new FantaMan();
        MouthWashMan brush = new MouthWashMan();
        public void Lvl3()
        {
            fantaobj.Bite();           
            brush.Bite();
        }
    }
}
