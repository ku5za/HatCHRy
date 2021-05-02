using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.Interfaces
{
    public interface IPathToDestinationFinderOutput
    {
        public List<int> GetVisitedVerticesList();
    }
}
