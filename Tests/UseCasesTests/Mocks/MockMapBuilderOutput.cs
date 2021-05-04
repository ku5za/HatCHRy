using Models;
using System;
using System.Collections.Generic;
using System.Text;
using UseCases.Interfaces;

namespace Tests.UseCasesTests.Mocks
{
    public class MockMapBuilderOutput : IMapBuilderOutput
    {
        public Map GetMap()
        {
            Map map = new Map(new string[] { "CAN", "USA", "MEX", "BLZ", "GTM", "SLV", "HND", "NIC", "CRI", "PAN" });
            map.AddBorder("CAN", "USA");
            map.AddBorder("USA", "MEX");
            map.AddBorder("MEX", "BLZ");
            map.AddBorder("MEX", "GTM");
            map.AddBorder("BLZ", "GTM");
            map.AddBorder("GTM", "SLV");
            map.AddBorder("GTM", "HND");
            map.AddBorder("SLV", "HND");
            map.AddBorder("HND", "NIC");
            map.AddBorder("NIC", "CRI");
            map.AddBorder("CRI", "PAN");

            return map;
        }
    }
}
