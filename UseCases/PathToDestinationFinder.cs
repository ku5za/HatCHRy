using System;
using System.Collections.Generic;
using System.Text;
using UseCases.Interfaces;

namespace UseCases
{
    public class PathToDestinationFinder : IPathToDestinationFinderOutput
    {
        public PathToDestinationFinder(IPathToDestinationFinderInput input) 
        {
            
        }
        public List<int> GetVisitedVerticesList()
        {
            throw new NotImplementedException();
        }
    }
}
