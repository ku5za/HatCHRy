using System;
using System.Collections.Generic;
using System.Text;
using UseCases;
using UseCases.Interfaces;

namespace Tests.UseCasesTests.Mocks
{
    public class MockMapBuilderInput : IMapBuilderInput
    {
        public List<string>[] GetBordersList()
        {
            return new List<string>[]
            {
                new List<string> { "CAN", "USA" },
                new List<string> { "USA", "MEX" },
                new List<string> { "MEX", "BLZ" }
            };
        }

        public string[] GetVerticesCodes()
        {
            return new string[] { "CAN", "USA", "MEX", "BLZ" };
        }
    }
}
