using System;
using System.Collections.Generic;

namespace DataStructure.Graph
{
    // un-weighted directional graph whose nodes value is generic
    public class GenericGraph<T> where T : IComparable<T>
    {
        private readonly Dictionary<T, LinkedList<T>> _adjacencyList;

        public GenericGraph()
        {
            _adjacencyList = new Dictionary<T, LinkedList<T>>();
        }

        public void AddEdge(T source, T destination)
        {
            if (!_adjacencyList.TryGetValue(source, out LinkedList<T>? value))
            {
                // add new node
                value = new LinkedList<T>();
                value.AddLast(destination);
                _adjacencyList[source] = value;
            }
            else
            {
                // check if edge exist or add edge to existing node
                if (!value.Contains(destination))
                {
                    value.AddLast(destination);
                }
            }
        }

        public void RemoveEdge(T source, T destination)
        {
            if (_adjacencyList.TryGetValue(source, out LinkedList<T>? value))
            {
                // remove edge if exist
                value.Remove(destination);
                if (value.Count == 0)
                {
                    // remove node if no edge exist
                    _adjacencyList.Remove(source);
                }
            }
        }

        public void RemoveNode(T node)
        {
            _adjacencyList.Remove(node);
        }

        public LinkedList<T> GetAdjacentVertices(T node)
        {
            if (_adjacencyList.TryGetValue(node, out LinkedList<T>? result))
            {
                return result;
            }
            return new LinkedList<T>();
        }

        public void PrintAdjacencyList()
        {
            foreach (var key in _adjacencyList.Keys)
            {
                Console.Write($"{key}");

                foreach (var item in _adjacencyList[key])
                {
                    Console.Write($" -> {item}");
                }
                Console.WriteLine();
            }
        }
    }
}
