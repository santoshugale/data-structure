using DataStructure.Tree;

namespace DataStructureTest.Tree
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void Insert_WhenCalled_InsertsDataIntoBST()
        {
            // Arrange
            var bst = new BinarySearchTree();
            bst.Insert(5);
            bst.Insert(3);
            bst.Insert(7);

            // Act
            var root = bst.Root;

            // Assert
            Assert.Equal(5, root.Data);
            Assert.Equal(3, root.Left.Data);
            Assert.Equal(7, root.Right.Data);
        }

        [Fact]
        public void InsertUsingLoop_WhenCalled_InsertsDataIntoBST()
        {
            // Arrange
            var bst = new BinarySearchTree();
            bst.InsertUsingLoop(5);
            bst.InsertUsingLoop(3);
            bst.InsertUsingLoop(7);

            // Act
            var root = bst.Root;

            // Assert
            Assert.Equal(5, root.Data);
            Assert.Equal(3, root.Left.Data);
            Assert.Equal(7, root.Right.Data);
        }

        [Fact]
        public void PrintPostOrder_WhenCalled_PrintsPostOrderTraversal()
        {
            // Arrange
            var bst = new BinarySearchTree();
            bst.Insert(5);
            bst.Insert(3);
            bst.Insert(7);

            // Act
            var output = CaptureConsoleOutput(() => BinarySearchTree.PrintPostOrder(bst.Root));

            // Assert
            Assert.Equal("3 7 5 ", output);
        }

        [Fact]
        public void PrintPreOrder_WhenCalled_PrintsPreOrderTraversal()
        {
            // Arrange
            var bst = new BinarySearchTree();
            bst.Insert(5);
            bst.Insert(3);
            bst.Insert(7);

            // Act
            var output = CaptureConsoleOutput(() => BinarySearchTree.PrintPreOrder(bst.Root));

            // Assert
            Assert.Equal("5 3 7 ", output);
        }

        [Fact]
        public void PrintInOrder_WhenCalled_PrintsInOrderTraversal()
        {
            // Arrange
            var bst = new BinarySearchTree();
            bst.Insert(5);
            bst.Insert(3);
            bst.Insert(7);

            // Act
            var output = CaptureConsoleOutput(() => BinarySearchTree.PrintInOrder(bst.Root));

            // Assert
            Assert.Equal("3 5 7 ", output);
        }

        private string CaptureConsoleOutput(Action action)
        {
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            action.Invoke();

            return consoleOutput.ToString();
        }
    }
}
