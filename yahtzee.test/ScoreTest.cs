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
			Player player = new Player();
			Score score = player.getScore();
			List<Dice> dices = score.getDices();
			Assert.Equal(5, dices.Count);
		}

		[Fact]
		public void ScoreShouldReturn()
		{
			Player player = new Player();
			Score score = player.getScore();
			List<Dice> dices = score.getDices();
			Assert.Equal(5, dices.Count);
		}
	}
}
