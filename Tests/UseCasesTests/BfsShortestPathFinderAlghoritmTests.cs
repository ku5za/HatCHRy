using System;
using System.Collections.Generic;
using System.Text;
using Tests.UseCasesTests.Mocks;
using UseCases;
using Xunit;

namespace Tests.UseCasesTests
{
    public class BfsShortestPathFinderAlghoritmTests
    {
        [Theory]
        [InlineData(1, 3, new int[] { 1, 2, 3 })]
        [InlineData(1, 6, new int[] { 1, 2, 4, 6})]
        public void GetShortestPathList_MockMapInput_ReturnsProperVisitedVerticesList(int source, int destination, int[] expectedOutput)
        {
            MockMapBuilderOutput mockShortestPathFinderInput = new MockMapBuilderOutput();
            List<int>[] adjacencyList = mockShortestPathFinderInput.GetMap().GetAdjacencyList();
            BfsShortestPathFinderAlgorithm bfsShortestPath = new BfsShortestPathFinderAlgorithm(adjacencyList);
            int[] bfsShortestPathArray = bfsShortestPath.GetShortestPathList(source, destination).ToArray();
            Assert.Equal(expectedOutput, bfsShortestPathArray);
        }
    }
}
