using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorterApp
{
    public interface ISorter
    {
        List<Name> Sort(List<Name> targetNames);
    }
}
