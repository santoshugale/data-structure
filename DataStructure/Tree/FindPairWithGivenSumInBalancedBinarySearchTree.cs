using System.Collections.Generic;
using static DataStructure.Tree.BinarySearchTree;

namespace DataStructure.Tree
{
    public class FindPairWithGivenSumInBalancedBinarySearchTree
    {
        /// <summary>
        /// Given a BST and a sum, find if there is a pair with given sum.
        /// </summary>
        /// <param name="bt"></param>
        /// <param name="givenSum"></param>
        /// <returns></returns>
        public static bool IsPairExist(BinarySearchTree bt, int givenSum)
        {
            var sortedList = new List<int>();
            ToListInSortedOrder(bt.Root, sortedList);
            var startIndex = 0;
            var endIndex = sortedList.Count - 1;
            while (startIndex < endIndex)
            {
                var addition = sortedList[startIndex] + sortedList[endIndex];
                if (addition == givenSum)
                    return true;
                else if (addition < givenSum)
                    endIndex--;
                else
                    startIndex++;
            }

            return false;
        }

        // sorting is basically in-order traversal
        public static void ToListInSortedOrder(BSTNode node, List<int> list)
        {
            if (node == null) return;
            ToListInSortedOrder(node.Left, list); // recur to left
            list.Add(node.Data);
            ToListInSortedOrder(node.Right, list); // recur to right

        }
    }
}
