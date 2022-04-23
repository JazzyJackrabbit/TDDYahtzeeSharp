using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yahtzeeapi.Services
{
    public class Dice
    {
        public int value;

        public int getRoll()
        {
            return value;
        }

        public void roll()
        {
            Random random = new Random();
            value = random.Next(1, 7);
        }
            
    }
}
