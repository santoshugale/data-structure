using System.Collections.Generic;

namespace Leetcode.BowlingGameCode
{
    public class BowlingGame
    {
        private readonly List<int> throws;
        private readonly List<Frame> frames;
        public BowlingGame()
        {
            throws = new List<int>();
            frames = new List<Frame>();

        }

        public void OpenFrame(int firstThrow, int secondThrow)
        {
            frames.Add(new OpenFrame(throws, firstThrow, secondThrow));
        }
        public void Spare(int firstThrow, int secondThrow)
        {
            frames.Add(new Spare(throws, firstThrow, secondThrow));
        }
        public void Strike()
        {
            frames.Add(new Strike(throws));
        }

        public void BonusRoll(int pins)
        {
            frames.Add(new BonusRoll(throws, pins));
        }

        public int Score()
        {
            var totalScore = 0;
            foreach (var frame in frames)
            {
                totalScore += frame.Score(throws);
            }
            return totalScore;
        }
    }
}

