using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using UseCases;
using UseCases.Interfaces;
using Xunit;

namespace Tests.UseCasesTests
{
    public class NorthAmericaMapBuilderInputTests
    {
        [Fact]
        public void GetVerticesCodes_ReturnsProperCodesForNorthAmericaCountries()
        {
            IMapBuilderInput mapBuilderInput = new NorthAmericaMapBuilderInput();
            Assert.Equal(
                    new string[]
                    {
                        "CAN",
                        "USA",
                        "MEX",
                        "BLZ",
                        "GTM",
                        "SLV",
                        "HND",
                        "NIC",
                        "CRI",
                        "PAN"
                    },
                    mapBuilderInput.GetVerticesCodes()
                );
        }

        [Fact]
        public void GetBordersList_ReturnsProperBordersListWithCountriesCodes()
        {
            IMapBuilderInput mapBuilderInput = new NorthAmericaMapBuilderInput();
            List<Border> expectedBorders = new List<Border>
                    {
                        new Border ("CAN", "USA"),
                        new Border ("USA", "MEX"),
                        new Border ("MEX", "GTM"),
                        new Border ("MEX", "BLZ"),
                        new Border ("BLZ", "GTM"),
                        new Border ("GTM", "SLV"),
                        new Border ("GTM", "HND"),
                        new Border ("SLV", "HND"),
                        new Border ("HND", "NIC"),
                        new Border ("NIC", "CRI"),
                        new Border ("CRI", "PAN")
                    };
            List<Border> actualBorders = mapBuilderInput.GetBordersList();
            string expoectedBordersString = JsonSerializer.Serialize(expectedBorders);
            string actualBordersString = JsonSerializer.Serialize(actualBorders);
            Assert.Equal(expoectedBordersString,
                    actualBordersString
                );
        }
    }
}
