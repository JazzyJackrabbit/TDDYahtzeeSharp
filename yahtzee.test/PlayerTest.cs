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
			// arrange
			Player player = new Player();

			// act
			Dice dice = player.launchDice();

			// assert
			Assert.NotNull(dice);
		}

		[Fact]
		public void NewPlayerShouldReturnNewScore()
		{
			// arrange
			Player player = new Player();

			// act
			Score score = player.getScore();

			// assert
			Assert.NotNull(score);

		}

		[Fact]
		public void NewPlayerShouldReturnScoreZero()
		{
			// arrange
			Player player = new Player();

			// act
			Score score = player.getScore();
			double value = score.score;

			// assert
			Assert.Equal(0, value);
		}

	}
}
