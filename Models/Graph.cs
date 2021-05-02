using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public abstract class Graph
    {
        protected readonly List<int>[] adjacencyList;
        public Graph(int numberOfVertices)
        {
            adjacencyList = new List<int>[numberOfVertices];
            for (int i = 0; i < adjacencyList.Length; i++)
                adjacencyList[i] = new List<int>();
        }

        public abstract void AddEdge(int from, int to);

        public List<int>[] GetAdjacencyList()
        {
            return adjacencyList;
        }
    }
}
