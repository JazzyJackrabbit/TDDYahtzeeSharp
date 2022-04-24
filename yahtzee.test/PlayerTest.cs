using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using yahtzeeapi.Services;

namespace yahtzeeapi.test
{
    public class PlayerTest
    {

		[Fact]
		public void PlayerLaunchDicesShouldReturnNewDices()
		{
			Player player = new Player("toto");
			Dices dices = player.launchDices();
			Assert.NotNull(dices);
		}

		[Fact]
		public void NewPlayerShouldReturnNewScore()
		{
			Player player = new Player("toto");
			Score score = player.getScore();
			Assert.NotNull(score);
		}

		[Fact]
		public void NewPlayerShouldReturnScoreZero()
		{
			Player player = new Player("toto");
			Score score = player.getScore();
			double value = score.GlobalScore;
			Assert.Equal(0, value);
		}

	}
}
