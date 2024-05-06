using System.Collections.Generic;

namespace Leetcode.BowlingGameCode
{
    public class OpenFrame : Frame
    {
        public OpenFrame(List<int> throws, int firstThrow, int secondThrow) : base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        public override int Score(List<int> throws)
        {
            return throws[startingpoint] + throws[startingpoint + 1];
        }

        protected override int FrameSize()
        {
            return 2;
        }
    }
}

