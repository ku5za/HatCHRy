using Models;
using System;
using System.Collections.Generic;
using System.Text;
using UseCases;
using UseCases.Interfaces;

namespace Tests.UseCasesTests.Mocks
{
    public class MockMapBuilderInput : IMapBuilderInput
    {
        public List<Border> GetBordersList()
        {
            return new List<Border>
            {
                new Border ( "CAN", "USA" ),
                new Border ( "USA", "MEX" ),
                new Border ( "MEX", "BLZ" )
            };
        }

        public string[] GetVerticesCodes()
        {
            return new string[] { "CAN", "USA", "MEX", "BLZ" };
        }
    }
}
