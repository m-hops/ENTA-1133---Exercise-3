using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class GameManager
    {
        public void Play()
        {
            DieRoller dice = new DieRoller();
            dice.Roll();
        }
        
    }
}
