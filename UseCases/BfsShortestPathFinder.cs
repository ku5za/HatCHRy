using System;
using System.Collections.Generic;
using System.Text;
using UseCases.Interfaces;

namespace UseCases
{
    public class BfsShortestPathFinder : PathFinder
    {
        public BfsShortestPathFinder(IMapBuilderOutput mapBuilderOutput) : base(mapBuilderOutput)
        {
        }

        protected override PathFinderAlgorithm GetShortestPathFinderAlgorithmClass()
        {
            List<int>[] adjacencyList = map.GetAdjacencyList();
            return new BfsShortestPathFinderAlgorithm(adjacencyList);
        }
    }
}
