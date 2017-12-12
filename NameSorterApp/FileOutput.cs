using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorterApp
{
    public class FileOutput : IOutput
    {
        public string FileName { get; set; } = "sorted-names-list.txt";
        public string PathFile { get; set; }

        // Method for generating output to text file
        public void Generate(List<Name> targetNames)
        {
            // Validation parameter
            if (targetNames == null)
            {
                throw new ArgumentNullException("targetNames");
            }
            // Initial text file
            PathFile = System.IO.Directory.GetCurrentDirectory() + "\\" + FileName;
            if (System.IO.File.Exists(PathFile))
            {
                System.IO.File.Delete(PathFile);
            }
            // Writing list of name to text file
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(PathFile, true);
            foreach (Name name in targetNames)
            {
                outputFile.WriteLine(name.GivenName + " " + name.LastName);
            }
            outputFile.Close();
        }
    }
}
