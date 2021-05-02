using Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class UndirectedGraphTests
    {
        [Fact]
        public void AfterAddingEdgesReturnsProperAdjacencyList()
        {
            UndirectedGraph graph = new UndirectedGraph(4);
            graph.AddEdge(0, 1);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 3);
            Assert.Equal<List<int>>(
                    new List<int>[4] {
                        new List<int> { 1 },
                        new List<int> { 0, 2, 3 },
                        new List<int> { 1, 3 },
                        new List<int> { 1, 2 }
                    }
                    , graph.GetAdjacencyList()
                );
        }
    }
}
