
using System.Collections.Generic;

namespace WFPainting.Api
{
    public interface IFileSO
    {
        void Save(List<TabMemento> saveList);
        List<TabMemento> Open();
    }
}
