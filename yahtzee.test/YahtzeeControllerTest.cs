using System.Collections.Generic;
using System.Linq;
using api.Controllers;
using Moq;
using Services;
using Xunit;

namespace api.test
{
	public class YahtzeeControllerTest
	{
		private YahtzeeController controller;
		
		public YahtzeeControllerTest()
		{
			// arrange
			Mock PlayerMock = new Mock<Player>();
			Mock DiceMock = new Mock<Dice>();
			Mock ScoreMock = new Mock<Score>();
			
		}

		[Fact]
		public void ShouldReturnCharged()
		{
			// arrange
			// act
			// assert
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
