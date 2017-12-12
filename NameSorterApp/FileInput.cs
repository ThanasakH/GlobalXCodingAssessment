using System;
using System.Collections.Generic;

namespace NameSorterApp
{
    public class FileInput : IInput
    {
        private string PathFile { get; set; }
        public List<Name> Read(string path)
        {
            // Validation parameter
            List<Name> returnNames = new List<Name>();
            if (path == null)
            {
                throw new ArgumentNullException("Argument path can not be null");
            }
            else if (path.Trim() == "")
            {
                throw new ArgumentException("Argument path can not be empty string");
            }
            else if (!System.IO.File.Exists(path.ToString().Trim()))
            {
                throw new ArgumentException("Could not find input file");
            }
            else
            {
                // Reading data from text file
                this.PathFile = path.ToString().Trim();
                string line;
                Name name;
                System.IO.StreamReader file = new System.IO.StreamReader(PathFile);
                while ((line = file.ReadLine()) != null)
                {
                    // Casting line of data to object Name
                    name = CastStringToName(line);
                    // Skip empty line
                    if (name == null)
                    {
                        continue;
                    }
                    returnNames.Add(name);
                }
                file.Close();
            }
            return returnNames;
        }
        private Name CastStringToName(string textLine)
        {
            Name name = new Name();
            int firstIndexLastName;
            textLine = textLine.Trim();
            // Validation data
            if (textLine == "")
            {
                name = null;
            }
            // Case: at least 1 Given Name and 1 Last Name
            else if (textLine.Contains(" "))
            {
                firstIndexLastName = textLine.LastIndexOf(' ') + 1;         // Find start index of Last Name
                name.GivenName = textLine.Substring(0, firstIndexLastName - 1).TrimEnd();   // Cutting Given Name
                name.LastName = textLine.Substring(firstIndexLastName);     // Cutting Last Name
            }
            // Case: only 1 Given Name
            else
            {
                name.GivenName = textLine;
            }
            return (name);
        }
    }
}
