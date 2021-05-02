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
            List<string>[] bordersList = mapBuilderInput.GetBordersList();
            foreach(var borderPair in bordersList)
            {
                itsMap.AddBorder(borderPair[0], borderPair[1]);
            }
        }

        public Map GetMap()
        {
            return itsMap;
        }
    }
}
