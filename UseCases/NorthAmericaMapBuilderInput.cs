using Models;
using System;
using System.Collections.Generic;
using System.Text;
using UseCases.Interfaces;

namespace UseCases
{
    public class NorthAmericaMapBuilderInput : IMapBuilderInput
    {
        public List<Border> GetBordersList()
        {
            return new List<Border>
            {
                new Border("CAN", "USA"),
                new Border ("USA", "MEX"),
                new Border ("MEX", "GTM"),
                new Border ("MEX", "BLZ"),
                new Border ("BLZ", "GTM"),
                new Border ("GTM", "SLV"),
                new Border ("GTM", "HND"),
                new Border ("SLV", "HND"),
                new Border ("HND", "NIC"),
                new Border ("NIC", "CRI"),
                new Border ("CRI", "PAN"),
            };
        }

        public string[] GetVerticesCodes()
        {
            return new string[]
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
            };
        }
    }
}
