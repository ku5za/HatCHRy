using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Map
    {
        private readonly Dictionary<string, int> territoriesDictionary;
        private readonly UndirectedGraph graphRepresentation;
        public Map(string[] territories)
        {
            territoriesDictionary = new Dictionary<string, int>();
            for(int i = 0; i < territories.Length; i++)
                territoriesDictionary.Add(territories[i], i);

            graphRepresentation = new UndirectedGraph(territories.Length);
        }

        public List<int>[] GetAdjacencyList() => graphRepresentation.GetAdjacencyList();
        public Dictionary<string, int> GetTerritoriesDictionary() => territoriesDictionary;

        public void AddBorder(string firstTerritory, string secondTerritory)
        {
            int firstTerritoryIndex = territoriesDictionary[firstTerritory];
            int secondTerritoryIndex = territoriesDictionary[secondTerritory];
            List<int> firstTerritoryNeighbours =
                graphRepresentation.GetAdjacencyList()[firstTerritoryIndex];

            bool borderAlreadyExists = firstTerritoryNeighbours.Contains(secondTerritoryIndex);
            if (borderAlreadyExists) 
                return;
            graphRepresentation.AddEdge(firstTerritoryIndex,secondTerritoryIndex);
        }

        public IEnumerable<IEnumerable<string>> GetBordersList(IAdjacencyListToBordersListParser parser)
        {
            return parser.FromTerritoriesDictionary(territoriesDictionary);
        }
    }
}
