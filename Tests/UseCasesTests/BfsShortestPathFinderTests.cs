using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tests.UseCasesTests.Mocks;
using UseCases;
using UseCases.Exceptions;
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
            IMapBuilderOutput mapBuilderOutput = new MockMapBuilderOutput();
            BfsShortestPathFinder pathFinder = new BfsShortestPathFinder(mapBuilderOutput);
            string[] shortestPath = pathFinder.GetVisitedTerritoriesCodesList(source, destination).ToArray();
            Assert.Equal(expectedOutput, shortestPath);
        }

        [Theory]
        [InlineData("USA", "HND", new string[] { "USA", "MEX", "GTM", "HND" })]
        [InlineData("USA", "PAN", new string[] { "USA", "MEX", "GTM", "HND", "NIC", "CRI", "PAN" })]
        public void GetVisitedVerticesList_AlwaysFindsShortestPath(string source, string destination, string[] expectedOutput)
        {
            IMapBuilderOutput mapBuilderOutput = new MockMapBuilderOutput();
            BfsShortestPathFinder pathFinder = new BfsShortestPathFinder(mapBuilderOutput);
            string[] shortestPath = pathFinder.GetVisitedTerritoriesCodesList(source, destination).ToArray();
            Assert.Equal(expectedOutput, shortestPath);
        }

        [Theory]
        [InlineData("USA", "NOTSUPPORTED")]
        [InlineData("NOTSUPPORTED", "USA")]
        public void GetVisitedVerticesList_NotSuportedCode_ThrowsNotSupportedCountryCodeException(string source, string destination)
        {
            IMapBuilderOutput mapBuilderOutput = new MockMapBuilderOutput();
            BfsShortestPathFinder pathFinder = new BfsShortestPathFinder(mapBuilderOutput);
            Assert.Throws<NotSupportedCountryCodeException>(() => pathFinder.GetVisitedTerritoriesCodesList(source, destination));
        }
    }
}
