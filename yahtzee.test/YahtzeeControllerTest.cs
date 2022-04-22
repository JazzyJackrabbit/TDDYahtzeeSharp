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
		public void ShouldReturnNotCharged()
		{
			// arrange
			// act
			// assert
		}
	}
}
