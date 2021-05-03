using System.Collections.Generic;

namespace UseCases
{
    public abstract class ShortestPathFinderAlgorithm
    {
        protected readonly List<int>[] adjacencyList;
        public ShortestPathFinderAlgorithm(List<int>[] adjacencyList)
        {
            this.adjacencyList = adjacencyList;
        }

        public abstract List<int> GetShortestPathList(int source, int destination);
    }
}