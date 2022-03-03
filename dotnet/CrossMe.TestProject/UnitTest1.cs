using crossmegame.Lib.DataClasses;
using NUnit.Framework;

namespace CrossMe.TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var game = new Game();
            string[,] levelCells = game.PrintLevel(1, 8);
            Assert.Pass();
        }
    }
}