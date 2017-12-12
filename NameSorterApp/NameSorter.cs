using System;
using System.Collections.Generic;
using System.Linq;

namespace NameSorterApp
{
    public class NameSorter : ISorter
    {
        // Sorting method from list of names by Last Name then Given Name
        public List<Name> Sort(List<Name> targetNames)
        {
            // Validation parameter
            if (targetNames == null)
            {
                throw new ArgumentNullException("targetNames");
            }
            // Sorting names list
            List<Name> returnNames = new List<Name>();
            var objectSorted = targetNames.OrderBy(n => n.LastName).ThenBy(n => n.GivenName);   // Order Names by Last Name and Given Name via linq
            returnNames = objectSorted.ToList();    // Cast object for returning
            return returnNames;
        }
    }
}
