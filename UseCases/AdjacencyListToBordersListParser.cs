using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseCases
{
    public class AdjacencyListToBordersListParser : IAdjacencyListToBordersListParser
    {
        private readonly List<int>[] adjacencyList;
        public AdjacencyListToBordersListParser(List<int>[] adjacencyList)
        {
            this.adjacencyList = adjacencyList;
        }

        public IEnumerable<IEnumerable<string>> FromTerritoriesDictionary(Dictionary<string, int> territoriesDictionary)
        {
            string[] territoriesCodes = territoriesDictionary.Keys.ToArray();

            return adjacencyList.Select(
                vertexNeighboursList => GetVertexNeighboursTerritoriesCodes(
                    vertexNeighboursList, territoriesCodes));
        }

        public List<string> GetVertexNeighboursTerritoriesCodes(List<int> vertexNeighboursList, string[] territoriesCodes)
        {
            return vertexNeighboursList.Select(
                    neighbourNumber => territoriesCodes[neighbourNumber]
                ).ToList();
        }
    }
}
