using System;
using System.Collections.Generic;

namespace NameSorterApp
{
    public class ConsoleOutput : IOutput
    {
        // Method for generating output on a screen
        public void Generate(List<Name> targetNames)
        {
            // Validation parameter
            if (targetNames == null)
            {
                throw new ArgumentNullException("targetNames");
            }
            // Print out a result on screen
            Console.Clear();
            foreach (Name name in targetNames)
            {
                Console.WriteLine(name.GivenName + " " + name.LastName);
            }
        }
    }
}
