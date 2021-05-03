using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UseCases.Interfaces;

namespace UseCases
{
    public abstract class ShortestPathFinder : IShortestPathFinderOutput
    {
        private readonly Map map;
        public ShortestPathFinder(IShortestPathFinderInput input)
        {
            map = input.GetMap();
        }

        protected abstract ShortestPathFinderAlgorithm GetShortestPathFinderAlgorithmClass(List<int>[] adjacencyList);

        public List<string> GetVisitedVerticesList(string source, string destination)
        {
            Dictionary<string, int> territoriesCodesDictionary = map.GetTerritoriesDictionary();
            List<int> visitedVerticesIndexesList =
                GetVisitedVerticesIndexesList(territoriesCodesDictionary[source], territoriesCodesDictionary[destination]);
            string[] territoriesCodes = territoriesCodesDictionary.Keys.ToArray();
            return visitedVerticesIndexesList.Select(vertexId => territoriesCodes[vertexId]).ToList();
        }

        protected List<int> GetVisitedVerticesIndexesList(int source, int destination)
        {
            List<int>[] adjacencyList = map.GetAdjacencyList();
            ShortestPathFinderAlgorithm pathFinder = GetShortestPathFinderAlgorithmClass(adjacencyList);
            return pathFinder.GetShortestPathList(
                source, destination);
        }
    }
}
