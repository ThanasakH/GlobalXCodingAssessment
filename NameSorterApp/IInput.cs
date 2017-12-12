using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorterApp
{
    public interface IInput
    {
        List<Name> Read(string path);
    }
}
