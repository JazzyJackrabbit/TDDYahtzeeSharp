using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yahtzeeapi.Services
{
    public class Dices
    {
        List<Dice> dices = new List<Dice>();

        public Dices()
        {
            dices.Clear();
            dices.Add(new Dice());
            dices.Add(new Dice());
            dices.Add(new Dice());
            dices.Add(new Dice());
            dices.Add(new Dice());
        }

        public List<Dice> getDices()
        {
            return dices;
        }

        public void Launch()
        {
            foreach (Dice dice in dices)
                dice.Launch();
            
        }
    }
}
