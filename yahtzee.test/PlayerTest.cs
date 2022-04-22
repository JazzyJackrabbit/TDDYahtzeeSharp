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
		public void PlayerLaunchDiceShouldReturnNewDice()
		{
			Player player = new Player();
			Dice dice = player.launchDice();
			Assert.NotNull(dice);
		}

		[Fact]
		public void NewPlayerShouldReturnNewScore()
		{
			// arrange
			Player player = new Player();
			Score score = player.getScore();
			Assert.NotNull(score);

		}

		[Fact]
		public void NewPlayerShouldReturnScoreZero()
		{
			Player player = new Player();
			Score score = player.getScore();
			double value = score.score;
			Assert.Equal(0, value);
		}

	}
}
