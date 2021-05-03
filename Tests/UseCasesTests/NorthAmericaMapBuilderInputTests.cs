using System;
using System.Collections.Generic;
using System.Text;
using UseCases;
using Xunit;

namespace Tests.UseCasesTests
{
    public class NorthAmericaMapBuilderInputTests
    {
        [Fact]
        public void GetVerticesCodes_ReturnsProperCodesForNorthAmericaCountries()
        {
            NorthAmericaMapBuilderInput mapBuilderInput = new NorthAmericaMapBuilderInput();
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
            NorthAmericaMapBuilderInput mapBuilderInput = new NorthAmericaMapBuilderInput();
            Assert.Equal(
                    new List<string>[]
                    {
                        new List<string> {"CAN", "USA"},
                        new List<string> {"USA", "MEX"},
                        new List<string> {"MEX", "GTM"},
                        new List<string> {"MEX", "BLZ"},
                        new List<string> {"BLZ", "GTM"},
                        new List<string> {"GTM", "SLV"},
                        new List<string> {"GTM", "HND"},
                        new List<string> {"SLV", "HND"},
                        new List<string> {"HND", "NIC"},
                        new List<string> {"NIC", "CIR"},
                        new List<string> {"CIR", "PAN"}
                    },
                    mapBuilderInput.GetBordersList()
                );
        }
    }
}
