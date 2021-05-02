using Models;
using System;
using System.Collections.Generic;
using System.Text;
using UseCases;
using Xunit;

namespace Tests.ModelsTests
{
    public class MapTests
    {
        [Fact]
        public void GetAdjacencyList_AddedBordersByCountryCodes_ReturnsProperAdjacencyList()
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

        [Fact]
        public void GetBordersList_AdjacencyListToBordersListParser_ReturnsProperAdjacencyListWithCountryCodes()
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

            List<int>[] mapAdjacencyList = map.GetAdjacencyList();

            AdjacencyListToBordersListParser parser = new AdjacencyListToBordersListParser(mapAdjacencyList);

            Assert.Equal(
                    new List<List<string>>()
                    {
                        new List<string> {"USA"},
                        new List<string> {"CAN", "MEX"},
                        new List<string> {"USA"}
                    },
                    map.GetBordersList(parser)
                );
        }

        [Fact]
        public void AddBorder_IgnoresAttemptToAddingAlreadyExistingBorder()
        {
            string[] territoryCodes = new string[] { "CAN", "USA" };
            Map map = new Map(territoryCodes);
            map.AddBorder("CAN", "USA");
            map.AddBorder("CAN", "USA");

            Assert.Equal(
                    new List<int>[] { new List<int> { 1 }, new List<int> { 0 } },
                    map.GetAdjacencyList()
                );
        }
    }
}
