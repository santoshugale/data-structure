using System.Collections.Generic;

namespace Leetcode.BowlingGameCode
{
    internal class Spare : Frame
    {
        public Spare(List<int> throws, int firstThrow, int secondThrow) : base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        public override int Score(List<int> throws)
        {
            return 10 + FirstBonusBall(throws);
        }

        protected override int FrameSize()
        {
            return 2;
        }
    }
}

