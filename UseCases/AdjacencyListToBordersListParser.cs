﻿using Models;
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
            string[] territoriesCodes = GetTerritoriesCodes(territoriesDictionary);

            return adjacencyList.Select(
                vertexNeighboursList => GetVertexNeighboursTerritoriesCodes(
                    vertexNeighboursList, territoriesCodes));
        }

        public string[] GetTerritoriesCodes(Dictionary<string, int> territoriesDictionary)
        {
            string[] territoriesCodes = new string[territoriesDictionary.Keys.Count];
            territoriesDictionary.Keys.CopyTo(territoriesCodes, 0);
            return territoriesCodes;
        }

        public List<string> GetVertexNeighboursTerritoriesCodes(List<int> vertexNeighboursList, string[] territoriesCodes)
        {
            return vertexNeighboursList.Select(
                    neighbourNumber => territoriesCodes[neighbourNumber]
                ).ToList();
        }
    }
}
