using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UseCases.Exceptions;
using UseCases.Interfaces;

namespace UseCases
{
    public abstract class ShortestPathFinder : IShortestPathFinderOutput
    {
        private readonly Map map;
        public ShortestPathFinder(IMapBuilderOutput mapBuilderOutput)
        {
            map = mapBuilderOutput.GetMap();
        }

        protected abstract ShortestPathFinderAlgorithm GetShortestPathFinderAlgorithmClass(List<int>[] adjacencyList);

        public List<string> GetVisitedVerticesList(string source, string destination)
        {
            Dictionary<string, int> territoriesCodesDictionary = map.GetTerritoriesDictionary();
            ThrowExceptionIfCodeIsNotInTerritoriesDictionary(source);
            ThrowExceptionIfCodeIsNotInTerritoriesDictionary(destination);

            List<int> visitedVerticesIndexesList = 
                GetVisitedVerticesList(
                    territoriesCodesDictionary[source],
                    territoriesCodesDictionary[destination]
                );
            string[] territoriesCodes = territoriesCodesDictionary.Keys.ToArray();
            return visitedVerticesIndexesList
                .Select(vertexId => territoriesCodes[vertexId])
                .ToList();
        }

        private void ThrowExceptionIfCodeIsNotInTerritoriesDictionary(string code)
        {
            Dictionary<string, int> territoriesDictionary = map.GetTerritoriesDictionary();
            if(!territoriesDictionary.ContainsKey(code))
            {
                throw new NotSupportedCountryCodeException();
            }
        }

        protected List<int> GetVisitedVerticesList(int source, int destination)
        {
            List<int>[] adjacencyList = map.GetAdjacencyList();
            ShortestPathFinderAlgorithm algorithm = GetShortestPathFinderAlgorithmClass(adjacencyList);
            return algorithm.GetShortestPathList(source, destination);
        }
    }
}
