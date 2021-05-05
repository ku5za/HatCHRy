using System.Collections.Generic;

namespace UseCases
{
    public abstract class PathFinderAlgorithm
    {
        protected readonly List<int>[] adjacencyList;
        public PathFinderAlgorithm(List<int>[] adjacencyList)
        {
            this.adjacencyList = adjacencyList;
        }

        public abstract List<int> GetShortestPathList(int source, int destination);
    }
}