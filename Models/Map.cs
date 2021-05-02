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

        public List<int>[] GetAdjacencyList()
        {
            return graphRepresentation.GetAdjacencyList();
        }

        public void AddBorder(string from, string to)
        {
            graphRepresentation.AddEdge(territoriesDictionary[from],
                                        territoriesDictionary[to]);
        }
    }
}
