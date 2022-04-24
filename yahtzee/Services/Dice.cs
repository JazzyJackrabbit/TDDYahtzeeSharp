using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yahtzeeapi.Services
{
    public class Dice
    {
        public int value { get; set; }

        public int Launch()
        {
            Random random = new Random();
            return value = random.Next(1, 7);
        }
    }
   
}
