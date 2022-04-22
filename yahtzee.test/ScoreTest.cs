using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using yahtzeeapi.Services;

namespace yahtzeeapi.test
{
    public class ScoreTest
    {
		[Fact]
		public void ScoresShouldHave5Dices()
		{
			// arrange
			Player player = new Player();

			// act
			Score score = player.getScore();
			List<Dice> dices = score.getDices();

			// assert
			Assert.Equal(5, dices.Count);
		}
	}
}
