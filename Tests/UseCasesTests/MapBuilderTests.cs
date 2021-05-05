using Models;
using System;
using System.Collections.Generic;
using System.Text;
using Tests.UseCasesTests.Mocks;
using UseCases;
using UseCases.Interfaces;
using Xunit;

namespace Tests.UseCasesTests
{
    public class MapBuilderTests
    {
        [Fact]
        public void GetAdjacencyList_SimpleMockMapBuilderInput_ReturnsMapWithProperAdjacencyList()
        {
            IMapBuilderInput mockMapBuilder = new MockMapBuilderInput();
            IMapBuilderOutput mapBuilder = new MapBuilder(mockMapBuilder);
            Map map = mapBuilder.GetMap();
            Assert.Equal(
                    map.GetAdjacencyList(),
                    new List<int>[]
                    {
                        new List<int> { 1 },
                        new List<int> { 0, 2 },
                        new List<int> { 1, 3 },
                        new List<int> { 2 },
                    }
                );
        }
    }
}
