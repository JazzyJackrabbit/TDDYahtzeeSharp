using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using yahtzeeapi.Services;

namespace yahtzeeapi.test
{
    [TestFixture]
    public class DiceTest
    {
        [Test]
        public void LancerDice()
        {
            var dice = Substitute.For<Dice>();
            dice.Launch();
            var diceValue = dice.value;
            DiceValueTest(diceValue);
        }

        [Test]
        public static void DiceValueTest(int desValeur)
        {
            Assert.True(desValeur >= 1 && desValeur <= 6);
        }
    }
}
