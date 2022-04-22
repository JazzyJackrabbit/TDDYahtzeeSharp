using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yahtzeeapi.Services
{
    public class Score
    {
        public double score { get; set; }
        private List<Dice> dices { get; set; }

        public void setDices(List<Dice> _dices)
        {
            dices = _dices;
        }
        public List<Dice> getDices()
        {
            return dices;
        }

        public double getScore(List<Dice> _dices)
        {
            setDices(_dices);

            return 0;
        }
    }
}
