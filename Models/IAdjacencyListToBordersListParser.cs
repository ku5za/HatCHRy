using System.Collections.Generic;

namespace Models
{
    public interface IAdjacencyListToBordersListParser
    {
        public IEnumerable<IEnumerable<string>> FromTerritoriesDictionary(Dictionary<string, int> territoriesDictionary);
    }
}