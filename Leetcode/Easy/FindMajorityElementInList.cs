using System.Collections.Generic;

namespace Leetcode.Easy
{
    /// <summary>
    /// A majority element in an array A[] of size n is an element that appears more than n/2 times
    /// There is only majority element in array at time
    /// 
    /// BST approach 
    ///  Insert elements in BST one by one 
    ///  and if an element is already present then increment the count of the node. 
    ///  At any stage, if the count of a node becomes more than n/2 then return.
    /// </summary>
    public class FindMajorityElementInList
    {
        public static int Find(List<int> list)
        {
            var dict = new Dictionary<int, int>();
            foreach (int item in list)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                    if (dict[item] > list.Count / 2)
                    {
                        return item;
                    }
                }
                else
                {
                    dict[item] = 1;
                }
            }
            return -1;
        }
    }
}
