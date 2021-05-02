using Models;
using System;
using System.Collections.Generic;
using System.Text;
using UseCases;
using UseCases.Interfaces;
using Xunit;

namespace Tests.UseCasesTests
{
    public class PathToDestinationFinderTests
    {
        private class MockPathToDestinationFinderInput : IPathToDestinationFinderInput
        {
            public Map GetMap()
            {
                return new Map(new string[] { "CAN", "USA", "MEX", "BLZ" });
            }
        }

        [Theory]
        [InlineData("USA", "BLZ", new string[] { "USA", "MEX", "BLZ" })]
        public void GetPath_ToNearCountries_ReturnsListOfVisitedCountries(string startingPoint, string destination, string[] expectedOutput)
        {
            MockPathToDestinationFinderInput mockInput = new MockPathToDestinationFinderInput();
            PathToDestinationFinder pathFinder = new PathToDestinationFinder(mockInput);
        }
    }
}
