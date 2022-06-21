using Xunit;


namespace Grupa4_TicTacToe.Tests
{
    public class PlayerTest
    {


        [Fact]


        public void GetPlayerString_WhenPlayersNameEntered_ThenReturnsYes()
        {
            string response = Player.IsPlayerNameExist(1);

            Assert.Equal("True", response);
              
        }



        [Theory]
        [InlineData("Dace")]
        [InlineData("Anastasija")]
        [InlineData("Jev")]
        [InlineData(" ")]


        public void GetPlayerString_WhenPlayers2NameEntered_ThenReturnsYes(string playerName)

        {
            string response = Player.IsPlayer2NameExist(playerName);
            Assert.Equal("True", response);
        }
    }
}
