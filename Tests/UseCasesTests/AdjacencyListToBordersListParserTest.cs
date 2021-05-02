using System;
using System.Collections.Generic;
using System.Text;
using UseCases;
using Xunit;

namespace Tests.UseCasesTests
{
    public class AdjacencyListToBordersListParserTest
    {
        [Fact]
        public void GetVertexNeighbourTerritoriesCodes_AdjacencyListAndTerritoriesCodes_ReturnsProperAdjacencyListWithCodesOfVertexNeighbours()
        {
            List<int>[] adjacencyList = new List<int>[] { new List<int> { 1 }, new List<int> { 0, 2 }, new List<int> { 1 } };
            string[] territoriesCodes = new string[] { "CAN", "USA", "MEX" };
            AdjacencyListToBordersListParser parser = new AdjacencyListToBordersListParser(adjacencyList);

            Assert.Equal(new string[] { "CAN", "MEX" },
                parser.GetVertexNeighboursTerritoriesCodes(adjacencyList[1], territoriesCodes));
        }

        [Fact]
        public void FromTerritoriesDictionary_AdjacencyListAndTerritoriesDictionary_ReturnsProperBordersList()
        {
            List<int>[] adjacencyList = new List<int>[3]
            {
                new List<int> {1},
                new List<int> {0, 2},
                new List<int> {1}
            };

            Dictionary<string, int> territoriesDictionary = new Dictionary<string, int>
            {
                { "CAN", 0 },
                { "USA", 1 },
                { "MEX", 2 }
            };

            AdjacencyListToBordersListParser parser = new AdjacencyListToBordersListParser(adjacencyList);
            Assert.Equal(
                    new List<List<string>>
                    {
                        new List<string> {"USA"},
                        new List<string> {"CAN", "MEX"},
                        new List<string> {"USA"}
                    },
                    parser.FromTerritoriesDictionary(territoriesDictionary)
                );
        }
    }
}
