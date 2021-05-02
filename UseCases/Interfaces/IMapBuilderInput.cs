using System.Collections.Generic;

namespace UseCases.Interfaces
{
    public interface IMapBuilderInput
    {
        public string[] GetVerticesCodes();
        public List<string>[] GetBordersList();
    }
}