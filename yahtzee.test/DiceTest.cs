using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using yahtzeeapi.Services;

namespace yahtzeeapi.test
{
    public class DiceTest
    {
		[Fact]
		public void DiceRolledShouldBeReturn()
		{
			Dice dice = new Dice();
			dice.roll();

			int roll = dice.getRoll();

			Assert.NotEqual(0, roll);
		}

		[Fact]

		public void DiceRollShouldBeBetween1To6()
        {
			Dice dice = new Dice();
			dice.roll();
			int roll = dice.getRoll();

			Assert.True(roll >= 1 && roll <= 6);
		}
	}


}
