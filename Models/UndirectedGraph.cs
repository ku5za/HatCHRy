using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class UndirectedGraph : Graph
    {
        public UndirectedGraph(int vertices) : base(vertices)
        {
        }

        public override void AddEdge(int from, int to)
        {
            adjacencyList[from].Add(to);
            adjacencyList[to].Add(from);
        }
    }
}
