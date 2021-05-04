using System;
using System.Collections.Generic;
using System.Text;
using UseCases.Interfaces;

namespace UseCases
{
    public class NorthAmericaMapBuilderInput : IMapBuilderInput
    {
        public List<string>[] GetBordersList()
        {
            return new List<string>[]
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
                new List<string> {"NIC", "CRI"},
                new List<string> {"CRI", "PAN"},
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
