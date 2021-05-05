using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Border
    {
        public string FirstTerritory { get; private set; }
        public string SecondTerritory { get; private set; }
        public Border(string firstTerritory, string secondTerritory)
        {
            FirstTerritory = firstTerritory;
            SecondTerritory = secondTerritory;
        }
    }
}
