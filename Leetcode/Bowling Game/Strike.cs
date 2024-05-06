using System.Collections.Generic;

namespace Leetcode.BowlingGameCode
{
    internal class Strike : Frame
    {
        public Strike(List<int> throws) : base(throws)
        {
            throws.Add(10);
        }

        public override int Score(List<int> throws)
        {
            return 10 + FirstBonusBall(throws) + SecondBonusBall(throws);
        }

        protected override int FrameSize()
        {
            return 1;
        }
    }
}

