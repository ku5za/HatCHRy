using System;
using System.Collections.Generic;
using System.Text;
using UseCases.Interfaces;

namespace UseCases
{
    public class BfsShortestPathFinder : ShortestPathFinder
    {
        public BfsShortestPathFinder(IShortestPathFinderInput input) : base(input)
        {
        }

        protected override ShortestPathFinderAlgorithm GetShortestPathFinderAlgorithmClass(List<int>[] adjacencyList)
        {
            return new BfsShortestPathFinderAlgorithm(adjacencyList);
        }
    }
}
