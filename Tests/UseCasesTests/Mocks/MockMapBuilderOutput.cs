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
            map.AddBorder(new Border("CAN", "USA"));
            map.AddBorder(new Border("USA", "MEX"));
            map.AddBorder(new Border("MEX", "BLZ"));
            map.AddBorder(new Border("MEX", "GTM"));
            map.AddBorder(new Border("BLZ", "GTM"));
            map.AddBorder(new Border("GTM", "SLV"));
            map.AddBorder(new Border("GTM", "HND"));
            map.AddBorder(new Border("SLV", "HND"));
            map.AddBorder(new Border("HND", "NIC"));
            map.AddBorder(new Border("NIC", "CRI"));
            map.AddBorder(new Border("CRI", "PAN"));

            return map;
        }
    }
}
