using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tests.UseCasesTests.Mocks;
using UseCases;
using UseCases.Interfaces;
using Xunit;

namespace Tests.UseCasesTests
{
    public class BfsShortestPathFinderTests
    {

        [Theory]
        [InlineData("USA", "BLZ", new string[] { "USA", "MEX", "BLZ" })]
        [InlineData("USA", "CAN", new string[] { "USA", "CAN" })]
        [InlineData("USA", "SLV", new string[] { "USA", "MEX", "GTM", "SLV" })]
        public void GetVisitedVerticesList_ToNearCountries_ReturnsListOfVisitedCountries(string source, string destination, string[] expectedOutput)
        {
            MockShortestPathFinderInput mockInput = new MockShortestPathFinderInput();
            BfsShortestPathFinder pathFinder = new BfsShortestPathFinder(mockInput);
            string[] shortestPath = pathFinder.GetVisitedVerticesList(source, destination).ToArray();
            Assert.Equal(expectedOutput, shortestPath);
        }

        [Theory]
        [InlineData("USA", "HND", new string[] { "USA", "MEX", "GTM", "HND" })]
        void GetVisitedVerticesList_ToHonduras_FindsShortestPath(string source, string destination, string[] expectedOutput)
        {
            MockShortestPathFinderInput mockInput = new MockShortestPathFinderInput();
            BfsShortestPathFinder pathFinder = new BfsShortestPathFinder(mockInput);
            string[] shortestPath = pathFinder.GetVisitedVerticesList(source, destination).ToArray();
            Assert.Equal(expectedOutput, shortestPath);
        }
    }
}
