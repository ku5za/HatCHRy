using Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests
{
    public class MapTests
    {
        [Fact]
        public void AfterAddingTerritoriesAndCommonBordersReturnsProperGraphAdjacencyList()
        {
            string[] territoryCodes = new string[]
            {
                "CAN",
                "USA",
                "MEX"
            };
            Map map = new Map(territoryCodes);
            map.AddBorder("CAN", "USA");
            map.AddBorder("USA", "MEX");


            Assert.Equal<List<int>>(
                    new List<int>[3] {
                        new List<int> { 1 },
                        new List<int> { 0, 2 },
                        new List<int> { 1 }
                    },
                    map.GetAdjacencyList()
                );
        }
    }
}
