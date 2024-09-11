using DataStructure.Graph;

namespace DataStructureTest.Graph
{
    public class BasicGraphTests
    {
        [Fact]
        public void AddEdge_ShouldAddEdgeToGraph()
        {
            // Arrange
            int totalVertices = 5;
            BasicGraph graph = new BasicGraph(totalVertices);

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
        public void PrintAdjacencyList_ShouldPrintAdjacencyList()
        {
            // Arrange
            int totalVertices = 5;
            BasicGraph graph = new BasicGraph(totalVertices);

            // Act
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);

            // Assert
            Assert.Equal("0 -> 1 -> 2\r\n1 -> 3\r\n2 -> 4\r\n3\r\n4\r\n", CaptureConsoleOutput(graph.PrintAdjacencyList));
        }

        [Fact]
        public void PrintAdjacencyMatrix_ShouldPrintAdjacencyMatrix()
        {
            // Arrange
            int totalVertices = 5;
            BasicGraph graph = new BasicGraph(totalVertices);

            // Act
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);

            graph.GenerateAdjacencyMatrix();

            // Assert
            Assert.Equal("x 1 1 0 0 \r\n0 x 0 1 0 \r\n0 0 x 0 1 \r\n0 0 0 x 0 \r\n0 0 0 0 x \r\n", CaptureConsoleOutput(graph.PrintAdjacencyMatrix));
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
