using System.Collections.Generic;

namespace Leetcode.BowlingGameCode
{
    public abstract class Frame
    {
        //protected List<int> throws;
        protected readonly int startingpoint;

        protected Frame(List<int> throws)
        {
            //this.throws = throws;
            startingpoint = throws.Count;
        }
        protected int FirstBonusBall(List<int> throws)
        {
            return throws[startingpoint + FrameSize()];
        }
        protected int SecondBonusBall(List<int> throws)
        {
            return throws[startingpoint + FrameSize() + 1];
        }

        protected abstract int FrameSize();


        public abstract int Score(List<int> throws);
    }
}

