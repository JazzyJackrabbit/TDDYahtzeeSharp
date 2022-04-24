using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yahtzeeapi.Services
{
    public class Score
    {

        public Dictionary<ScoresEnum, int> ScoresData { get; set; }

        public Score()
        {
            ScoresData = new Dictionary<ScoresEnum, int>();
        }
        public int GlobalScore
        {
            get => ScoresData.Sum(x => x.Value);
        }


        public Dictionary<ScoresEnum, int> HandleDicesForScore(Dices dices)
        {
            Dictionary<ScoresEnum, int> dataScore = new Dictionary<ScoresEnum, int>();

            Dictionary<ScoresEnum, int> data1 = Handler1(dices);
            Dictionary<ScoresEnum, int> data2 = Handler2(dices);

            foreach (var keyValuePair in data1)
                dataScore.Add(keyValuePair.Key, keyValuePair.Value);

            foreach (var keyValuePair in data2)
                dataScore.Add(keyValuePair.Key, keyValuePair.Value);

            return dataScore;
        }

        private Dictionary<ScoresEnum, int> Handler1(Dices dices)
        {
            Dictionary<ScoresEnum, int> dataScore = new Dictionary<ScoresEnum, int>();

            var data = dices.getDices().GroupBy(x => x.value).ToList();
            foreach (IGrouping<int, Dice> diceData in data)
            {
                ScoresEnum? scoreName = GetScoresBase(diceData.Key);
                if (scoreName != null)
                {
                    var name = (ScoresEnum)scoreName;
                    dataScore.Add(name, diceData.Sum(x => x.value));
                }
            }
            return dataScore;
        }

        private Dictionary<ScoresEnum, int> Handler2(Dices dices)
        {
            Dictionary<ScoresEnum, int> dataScore = new Dictionary<ScoresEnum, int>();

            var data = dices.getDices().GroupBy(x => x.value).ToList();

            if (data.Any(x => x.Count() == 3))
                dataScore.Add(ScoresEnum.ThreeOfAKind, dices.getDices().Sum(x => x.value));
            
            if (data.Any(x => x.Count() == 4))
                dataScore.Add(ScoresEnum.FourOfAKind, dices.getDices().Sum(x => x.value));

            if (data.Count == 2 && data.All(x => x.Count() > 1))
                dataScore.Add(ScoresEnum.FullHouse, 25);

            var orderedData = dices.getDices().OrderBy(x => x.value).ToList();

            var sequentialTest = orderedData.TakeWhile((x, i) =>
            {
                if (i == 0)
                    return true;   
                else
                    if (x.value != (orderedData[i - 1].value + 1))
                        return false;
                    else
                        return true;
            }).ToList();

            if (sequentialTest.Count == 4)
                dataScore.Add(ScoresEnum.SmallStraight, 30);

            if (sequentialTest.Count == 5)
                dataScore.Add(ScoresEnum.LargeStraight, 40);

            if (dices.getDices().Select(x => x.value).Distinct().Count() == 1)
                dataScore.Add(ScoresEnum.Yathzee, 50);

            dataScore.Add(ScoresEnum.Chance, dices.getDices().Sum(x => x.value));

            return dataScore;
        }


        public void CalculateScore(Dictionary<ScoresEnum, int> possibleScore, Score score, string input)
        {
            var choosableData = possibleScore.Where(x => score.ScoresData.All(y => y.Key != x.Key)).ToDictionary(x => x.Key, x => x.Value);

            int indexSelected;

            try { 
                if (input == null) input = "1";
                indexSelected = int.Parse(input) - 1;
            }
            catch
            {
                indexSelected = 0;
            }

            var selectedToAdd = choosableData.ElementAt(indexSelected);
            score.ScoresData.Add(selectedToAdd.Key, selectedToAdd.Value);
        }

        private ScoresEnum? GetScoresBase(int i)
        {
            switch (i)
            {
                case 1:
                    return ScoresEnum.Ones;
                case 2:
                    return ScoresEnum.Twos;
                case 3:
                    return ScoresEnum.Threes;
                case 4:
                    return ScoresEnum.Fours;
                case 5:
                    return ScoresEnum.Fives;
                case 6:
                    return ScoresEnum.Sixes;
                default:
                    return null;
            }
        }



    }

    public enum ScoresEnum
    {
        Ones,
        Twos,
        Threes,
        Fours,
        Fives,
        Sixes,
        ThreeOfAKind,
        FourOfAKind,
        FullHouse,
        SmallStraight,
        LargeStraight,
        Chance,
        Yathzee
    }

}
