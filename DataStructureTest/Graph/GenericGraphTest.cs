using DataStructure.Graph;

namespace DataStructureGraph.Tests
{
    public class GenericGraphTest
    {
        [Fact]
        public void AddEdge_ShouldAddEdgeToGraph()
        {
            // Arrange
            var graph = new GenericGraph<int>();

            // Act
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);

            // Assert
            Assert.Equal(2, graph.GetAdjacentVertices(0).Count);
            Assert.Single(graph.GetAdjacentVertices(1));
            Assert.Single(graph.GetAdjacentVertices(2));
            Assert.Empty(graph.GetAdjacentVertices(3));
            Assert.Empty(graph.GetAdjacentVertices(4));
        }

        [Fact]
        public void AddEdge_ShouldHandleDuplicateEdge()
        {
            // Arrange
            var graph = new GenericGraph<char>();

            // Act
            graph.AddEdge('0', '1');
            graph.AddEdge('0', '1');
            graph.AddEdge('0', '2');
            graph.AddEdge('1', '3');
            graph.AddEdge('2', '4');

            // Assert
            Assert.Equal("0 -> 1 -> 2\r\n1 -> 3\r\n2 -> 4\r\n", CaptureConsoleOutput(graph.PrintAdjacencyList));
        }

        [Fact]
        public void RemoveEdge_ShouldRemoveEdgeAndRemoveNodeIsNoEdgesForThatNode()
        {
            // Arrange
            var graph = new GenericGraph<char>();

            // Act
            graph.AddEdge('0', '1');
            graph.AddEdge('0', '2');
            graph.AddEdge('1', '3');
            graph.AddEdge('2', '4');
            graph.RemoveEdge('1', '3');

            // Assert
            Assert.Equal("0 -> 1 -> 2\r\n2 -> 4\r\n", CaptureConsoleOutput(graph.PrintAdjacencyList));
        }


        [Fact]
        public void RemoveEdge_ShouldRemoveNodeWithItsEdges()
        {
            // Arrange
            var graph = new GenericGraph<char>();

            // Act
            graph.AddEdge('0', '1');
            graph.AddEdge('0', '2');
            graph.AddEdge('1', '3');
            graph.AddEdge('2', '4');
            graph.RemoveNode('0');
            graph.RemoveNode('9'); // should not throw exception if node does not exist

            // Assert
            Assert.Equal("1 -> 3\r\n2 -> 4\r\n", CaptureConsoleOutput(graph.PrintAdjacencyList));
        }

        [Fact]
        public void PrintAdjacencyList_ShouldPrintAdjacencyList()
        {
            // Arrange
            var graph = new GenericGraph<char>();

            // Act
            graph.AddEdge('0', '1');
            graph.AddEdge('0', '2');
            graph.AddEdge('1', '3');
            graph.AddEdge('2', '4');

            // Assert
            Assert.Equal("0 -> 1 -> 2\r\n1 -> 3\r\n2 -> 4\r\n", CaptureConsoleOutput(graph.PrintAdjacencyList));
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
