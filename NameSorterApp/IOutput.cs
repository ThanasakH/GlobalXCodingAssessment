using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorterApp
{
    public interface IOutput
    {
        void Generate(List<Name> targetNames);
    }
}
