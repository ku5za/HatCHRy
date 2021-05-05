using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UseCases.Interfaces;

namespace UseCases
{
    public class MapBuilder : IMapBuilderOutput
    {
        private readonly Map itsMap;
        public MapBuilder(IMapBuilderInput mapBuilderInput)
        {
            itsMap = new Map(mapBuilderInput.GetVerticesCodes());
            List<Border> bordersList = mapBuilderInput.GetBordersList();
            foreach(Border border in bordersList)
            {
                itsMap.AddBorder(border);
            }
        }

        public Map GetMap()
        {
            return itsMap;
        }
    }
}
