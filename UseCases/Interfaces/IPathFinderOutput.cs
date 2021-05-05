using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.Interfaces
{
    public interface IPathFinderOutput
    {
        public List<string> GetVisitedTerritoriesCodesList(string source, string destination);
    }
}
