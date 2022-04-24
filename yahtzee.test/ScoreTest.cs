using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using yahtzeeapi.Services;

namespace yahtzeeapi.test
{

    [TestFixture]
    public class ScoreTest
    {

        [Test]
        public void GetScoreAfterLaunch()
        {
            var player = new Player("toto");
            Dices dices = player.launchDices();

            dices.Launch();

            Score score = new Score();
            score.HandleDicesForScore(dices);

            Assert.IsTrue(score.GlobalScore >= 1);

        }

        [Test]
        [TestCase(ScoresEnum.Ones, 1, 1, 3, 4, 5)]
        [TestCase(ScoresEnum.Twos, 1, 2, 2, 4, 5)]
        [TestCase(ScoresEnum.Threes, 1, 2, 3, 3, 5)]
        [TestCase(ScoresEnum.Fours, 1, 2, 3, 4, 4)]
        [TestCase(ScoresEnum.Fives, 1, 2, 3, 4, 5)]
        [TestCase(ScoresEnum.Sixes, 1, 2, 3, 6, 6)]
        [TestCase(ScoresEnum.ThreeOfAKind, 1, 2, 5, 5, 5)]
        [TestCase(ScoresEnum.FourOfAKind, 2, 5, 5, 5, 5)]
        [TestCase(ScoresEnum.FullHouse, 1, 1, 1, 6, 6)]
        [TestCase(ScoresEnum.SmallStraight, 1, 2, 3, 4, 6)]
        [TestCase(ScoresEnum.LargeStraight, 1, 2, 3, 4, 5)]
        [TestCase(ScoresEnum.Yathzee, 5, 5, 5, 5, 5)]
        public void GestionScorePossible(ScoresEnum scoreEnum, params int[] diceValues)
        {
            var player = new Player("toto");
            Dices dices = player.launchDices();

            dices.getDices()[0].value = diceValues[0];
            dices.getDices()[1].value = diceValues[1];
            dices.getDices()[2].value = diceValues[2];
            dices.getDices()[3].value = diceValues[3];
            dices.getDices()[4].value = diceValues[4];

            Score score = new Score();
            var listScorePossible = score.HandleDicesForScore(dices);

            listScorePossible.ContainsKey(scoreEnum);

        }

        [Test]
        [TestCase(1, 2, 3, 4, 5)]
        [TestCase(1, 2, 3, 3, 5)]
        [TestCase(1, 2, 3, 4, 4)]
        [TestCase(1, 2, 3, 4, 5)]
        [TestCase(1, 2, 3, 6, 6)]
        public void CalculScorePlayer(params int[] diceValues)
        {
            var player = new Player("toto");
            Dices dices = player.launchDices();

            dices.getDices()[0].value = diceValues[0];
            dices.getDices()[1].value = diceValues[1];
            dices.getDices()[2].value = diceValues[2];
            dices.getDices()[3].value = diceValues[3];
            dices.getDices()[4].value = diceValues[4];

            Score score = new Score();
            var listScorePossible = score.HandleDicesForScore(dices);

            score.CalculateScore(listScorePossible, score, "1");

           
            int scoreValue = score.GlobalScore;

            Assert.IsTrue(scoreValue >= 1);
        }

    }
}
