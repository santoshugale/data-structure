using System;
using System.Collections.Generic;

namespace Leetcode
{
    class Program1
    {
        static void Main(string[] args)
        {
            Performance.Test();
            //var list = new List<int>() { 2, 2, 1, 0, 2, 1, 0 };
            //DutchNationalFlagProblem.SortByCounting(list);
            //list.ForEach((x) => Console.WriteLine(x));

            //Console.WriteLine(FindSumOfDigitsTillSingleDigit.Calculate(111));

            //var linkedList = new Node<int>(1, new Node<int>(2, new Node<int>(44, new Node<int>(14, new Node<int>(100)))));
            //SwapElementsOfGivenLinkedList.Swap(linkedList);
            //SwapElementsOfGivenLinkedList.Print(linkedList);

            //var list = new List<int>() { 2, 12, 31, 20, 22, 1, 0 };
            //var list1 = new List<int>() { 2, 2, 2, 0, 2, 1, 0 };
            //Console.WriteLine(FindMajorityElementInList.Find(list));
            //Console.WriteLine(FindMajorityElementInList.Find(list1));

            //var tree = new BinarySearchTree();
            //tree.Insert(50);
            //tree.Insert(30);
            //tree.Insert(20);
            //tree.Insert(40);
            //tree.Insert(70);
            //tree.Insert(60);
            //tree.Insert(80);
            //BinarySearchTree.PrintInOrder(tree.Root);
            //Console.WriteLine();
            //BinarySearchTree.PrintPreOrder(tree.Root);
            //Console.WriteLine();
            //BinarySearchTree.PrintPostOrder(tree.Root);

            //var bt = new BinarySearchTree();
            //bt.Insert(50);
            //bt.Insert(30);
            //bt.Insert(20);
            //bt.Insert(40);
            //bt.Insert(70);
            //bt.Insert(60);
            //bt.Insert(80);
            //Console.WriteLine(FindPairWithGivenSumInBalancedBinarySearchTree.IsPairExist(bt, 100));
            //Console.WriteLine(FindPairWithGivenSumInBalancedBinarySearchTree.IsPairExist(bt, 1000));


            //TowersOfHanoi.TowerOfHanoi(4, 'A', 'C', 'B'); // A, B and C are names of rods

            //char[,] grid = {
            //    {
            //        '0' , '*' , '0' , 's'
            //    },
            //    {
            //        '*' , '0' , '*' , '*'
            //    },
            //    {
            //        '0' , '*' , '*' , '*'
            //    },
            //    {
            //        'd' , '*' , '*' , '*'
            //    }
            //};
            //Console.WriteLine(Maze.MinDistance(grid));

            //AllBinaryStringsOfNBits.GenerateAllBinaryStrings(2, new int[2]);
            //AllBinaryStringsOfNBits.GenerateAllBinaryStrings(3, new int[3]);
            //AllBinaryStringsOfNBits.GenerateAllBinaryStrings(4, new int[4]);


            //var a = new Exception();
            //var b = new Exception();
            //UpdateExceptionSource(a);
            //UpdateExceptionSourceByRef(ref b);
            //Console.WriteLine(a.Source);
            //Console.WriteLine(b.Source);


            //a aa = new a2();
            //a2 a2 = (a2)aa;
            //a2.pr();

            //Child objC = new Child();


            //StringProblems.FindOccurancesOfChars("santoshugale");
            //StringProblems.RemoveDuplicateFromString("santoshugale");

            //AllBinaryStringsOfNBits.GenerateAllBinaryStrings(3, new int[3], 0);
            //AllBinaryStringsOfNBits.GenerateAllBinaryStrings(3, new int[3]);
            //Console.Read();
        }

        private static void UpdateExceptionSourceByRef(ref Exception exception)
        {
            exception = new Exception()
            {
                Source = "created new object with source"
            };
        }

        private static void UpdateExceptionSource(Exception exception)
        {
            exception = new Exception()
            {
                Source = "created new object with source"
            };
        }

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int uniqueArrayIndex = 0;
            for (int index = 1; index < nums.Length; index++)
            {
                if (nums[uniqueArrayIndex] != nums[index])
                {
                    uniqueArrayIndex++;
                    nums[uniqueArrayIndex] = nums[index];
                }
            }
            return uniqueArrayIndex + 1;
        }

    }

    public class a2 : a
    {
        public void pr()
        {
            base.pr();
            Console.WriteLine("a2");
        }
    }

    public class a
    {
        public new void pr()
        {
            Console.WriteLine("a");
        }
    }

    interface a1
    {
        void pr();
    }

    class Parent
    {
        Child objCh = new Child();
        public Parent()
        {
            Console.WriteLine("Parent Class Constructor");
        }
    }
    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child class Constructor");
        }
        //Parent objP = new Parent();
    }

    //public interface IInterface
    //{
    //    void SigngleMethod();
    //}

    //public static class StaticClass : IInterface
    //{

    //}
}
