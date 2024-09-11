using System;
using System.Collections.Generic;

namespace DataStructure.Graph
{
    // un-weighted directional graph whose nodes value is integer
    public class BasicGraph
    {
        private readonly int totalNodes;
        private readonly LinkedList<int>[] _adjacencyList;
        private readonly int[,] _adjacencyMatrixCreatedFromAdjucencyList;

        public BasicGraph(int nodes)
        {
            totalNodes = nodes;
            _adjacencyList = new LinkedList<int>[nodes];
            _adjacencyMatrixCreatedFromAdjucencyList = new int[nodes, nodes];
            // generate the adjucency list for all the vertext node 
            for (int i = 0; i < nodes; i++)
            {
                _adjacencyList[i] = new LinkedList<int>();
            }
        }

        public void GenerateAdjacencyMatrix()
        {
            for (int i = 0; i < totalNodes; i++)
            {
                foreach (var item in _adjacencyList[i])
                {
                    if (i != item)
                    {
                        _adjacencyMatrixCreatedFromAdjucencyList[i, item] = 1;
                    }
                }
            }
        }

        public void PrintAdjacencyMatrix()
        {
            for (int i = 0; i < totalNodes; i++)
            {
                for (int j = 0; j < totalNodes; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"x ");
                    }
                    else
                    {
                        Console.Write($"{_adjacencyMatrixCreatedFromAdjucencyList[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void AddEdge(int source, int destination)
        {
            _adjacencyList[source].AddLast(destination);
        }

        public LinkedList<int> GetAdjacentVertices(int vertex)
        {
            return _adjacencyList[vertex];
        }

        public void PrintAdjacencyList()
        {
            for (int i = 0; i < _adjacencyList.Length; i++)
            {
                Console.Write($"{i}");

                foreach (var item in _adjacencyList[i])
                {
                    Console.Write($" -> {item}");
                }
                Console.WriteLine();
            }
        }
    }
}
