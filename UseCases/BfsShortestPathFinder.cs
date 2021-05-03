using System;
using System.Collections.Generic;
using System.Text;
using UseCases.Interfaces;

namespace UseCases
{
    public class BfsShortestPathFinder : ShortestPathFinder
    {
        public BfsShortestPathFinder(IMapBuilderOutput mapBuilderOutput) : base(mapBuilderOutput)
        {
        }

        protected override ShortestPathFinderAlgorithm GetShortestPathFinderAlgorithmClass(List<int>[] adjacencyList)
        {
            return new BfsShortestPathFinderAlgorithm(adjacencyList);
        }
    }
}
