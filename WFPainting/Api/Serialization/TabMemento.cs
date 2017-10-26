using System;
using System.Collections.Generic;

namespace WFPainting.Api
{
    [Serializable]
    public class TabMemento
    {
        public string tabName;
        public List<FigureMemento> mementoList = new List<FigureMemento>();
    }
}
