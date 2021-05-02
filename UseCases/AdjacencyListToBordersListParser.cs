using Models;
using System;
using System.Collections.Generic;
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

            List<List<string>> bordersList = new List<List<string>>();
            for(int vertex = 0; vertex < this.adjacencyList.Length; vertex++)
            {
                bordersList.Add(GetVertexNeighboursTerritoriesCodes(this.adjacencyList[vertex], territoriesCodes));
            }
            return bordersList;
        }

        public string[] GetTerritoriesCodes(Dictionary<string, int> territoriesDictionary)
        {
            string[] territoriesCodes = new string[territoriesDictionary.Keys.Count];
            territoriesDictionary.Keys.CopyTo(territoriesCodes, 0);
            return territoriesCodes;
        }

        public List<string> GetVertexNeighboursTerritoriesCodes(List<int> vertexNeighboursList, string[] territoriesCodes)
        {
            List<string> vertexNeighboursTerritoriesCodes = new List<string>();
            foreach(var neighbourIndex in vertexNeighboursList)
            {
                string neighbourCode = territoriesCodes[neighbourIndex];
                vertexNeighboursTerritoriesCodes.Add(neighbourCode);
            }
            return vertexNeighboursTerritoriesCodes;
        }
    }
}
