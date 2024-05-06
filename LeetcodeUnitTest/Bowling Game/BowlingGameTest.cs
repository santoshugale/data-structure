using Leetcode.BowlingGameCode;
using Xunit;

namespace BowlingGameTest
{
    public class BowlingGameTest
    {
        private readonly BowlingGame game;

        public BowlingGameTest()
        {
            game = new BowlingGame();
        }

        [Fact]
        public void GutterBalls()
        {
            OpenFrames(10, 0, 0);
            Assert.Equal(0, game.Score());
        }

        [Fact]
        public void AllThree()
        {
            OpenFrames(10, 3, 3);
            Assert.Equal(60, game.Score());
        }

        [Fact]
        public void Spare()
        {
            game.Spare(4,6);
            game.OpenFrame(3,5);
            OpenFrames(8, 0,0);
            Assert.Equal(21, game.Score());
        }

        [Fact]
        public void Spare2()
        {
            game.Spare(4, 6);
            game.OpenFrame(5, 3);
            OpenFrames(8, 0, 0);
            Assert.Equal(23, game.Score());
        }


        [Fact]
        public void PerfectGame()
        {
            for (int i = 0; i < 10; i++)
                game.Strike();
            game.BonusRoll(10);
            game.BonusRoll(10);
            Assert.Equal(300, game.Score());
        }

        [Fact]
        public void Alternating()
        {
            for (int i = 0; i < 5; i++)
            {
                game.Strike();
                game.Spare(4, 6);
            }
            game.BonusRoll(10);
            Assert.Equal(200, game.Score());
        }

        [Fact]
        public void SpareFinalFrame()
        {
            OpenFrames(9, 0, 0);
            game.Spare(4, 6);
            game.BonusRoll(5);
            Assert.Equal(15, game.Score());
        }

        [Fact]
        public void StrikeFinalFrame()
        {
            OpenFrames(9, 0, 0);
            game.Strike();
            game.BonusRoll(5);
            game.BonusRoll(3);
            Assert.Equal(18, game.Score()); // note that this is different from test Strike()
        }

        [Fact]
        public void Strike()
        {
            game.Strike();
            game.OpenFrame(5, 3);
            OpenFrames(8, 0, 0);
            Assert.Equal(26, game.Score());
        }

        private void OpenFrames(int count, int firstThrow, int secondThrow)
        {
            for (int i = 0; i < count; i++)
            {
                game.OpenFrame(firstThrow, secondThrow);
            }
        }
    }
}
