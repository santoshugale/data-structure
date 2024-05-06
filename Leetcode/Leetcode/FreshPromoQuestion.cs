using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Leetcode
{
    public static class FreshPromoQuestion
    {
        public static int IsWinner(List<string> codeList, List<string> cartItems)
        {
            if (!codeList.Any())
            {
                return 1;
            }
            if (!cartItems.Any())
            {
                return 0;
            }

            var codeGroups = new List<List<string>>();

            foreach (var code in codeList)
            {
                codeGroups.Add(code.Split(' ').ToList());
            }


            int groupIndex = 0;
            int codeIndex = 0;
            foreach (var cartItem in cartItems)
            {
                if (groupIndex == codeGroups.Count) break;
                var testCode = codeGroups[groupIndex][codeIndex];
                if (testCode == cartItem || testCode == "anything")
                {
                    if (codeIndex == codeGroups[groupIndex].Count)
                    {
                        groupIndex++;
                        codeIndex = 0;
                    }
                    else
                    {
                        codeIndex++;
                    }
                }
                else
                {
                    codeIndex = 0;
                }
            }
            return groupIndex == codeGroups.Count ? 1 : 0;
        }
    }
}
