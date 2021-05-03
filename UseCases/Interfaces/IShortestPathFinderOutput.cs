using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.Interfaces
{
    public interface IShortestPathFinderOutput
    {
        public List<string> GetVisitedVerticesList(string source, string destination);
    }
}
