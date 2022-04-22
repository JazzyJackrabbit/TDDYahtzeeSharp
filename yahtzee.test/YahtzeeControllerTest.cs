using System.Collections.Generic;
using System.Linq;
using api.Controllers;
using Moq;
using Services;
using Xunit;
using yahtzeeapi.Services;

namespace api.test
{
	public class YahtzeeControllerTest
	{
		private YahtzeeController controller;
		
		public YahtzeeControllerTest()
		{

		}

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

		[Fact]
		public void ScoresShouldBeValid()
		{
			// arrange
			

			// act

			// assert

			// todo
		}

	}
}
