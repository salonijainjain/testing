using NUnit.Framework;
namespace TestingEx
{
    [TestFixture]
    public class Player
    {
        [Test]
        public void TestOne()
        {
            foreach (var Player in Program.ListPlayers())
            {
                Assert.IsNotNull(Player.Pid);
                Assert.IsNotNull(Player.Pname);
                Assert.IsNotNull(Player.Pteam);

            }
        }

    }
}
