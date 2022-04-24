using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yahtzeeapi.Services
{
    public class Player
    {
        public string pseudo { get; set; }
        public Score score { get; set; }

        public Player(string _pseudo)
        {
            score = new Score();
            pseudo = _pseudo;
        }

        public Dices launchDices()
        {
            Dices dices = new Dices();
            dices.Launch();
            
            score.HandleDicesForScore(dices);
            return dices;
        }

        public Score getScore()
        {
            return score;
        }
    }
}
