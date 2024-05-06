using System.Collections.Generic;

namespace Leetcode.BowlingGameCode
{
    public class BonusRoll : Frame
    {
        public BonusRoll(List<int> throws, int pins) : base(throws)
        {
            throws.Add(pins);
        }

        public override int Score(List<int> throws)
        {
            return 0;
        }

        protected override int FrameSize()
        {
            return 0;
        }
    }
}

