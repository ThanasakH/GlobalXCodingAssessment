using System;
using System.Collections.Generic;

namespace NameSorterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Name> unsortedNames = new List<Name>();
                List<Name> sortedNames = new List<Name>();
                // Validation parameter
                if (args.Length == 0)
                {
                    throw new Exception("Please enter an argument.");
                }
                string inputPath = args[0];

                /// Read data from text file to unsortedNames list
                IInput fileInput = new FileInput();
                unsortedNames = fileInput.Read(inputPath);

                /// Sort unsortedNames to sortedNames list
                ISorter nameSorter = new NameSorter();
                sortedNames = nameSorter.Sort(unsortedNames);

                /// Print out sortedNames list to screen
                IOutput consoleOutput = new ConsoleOutput();
                consoleOutput.Generate(sortedNames);

                /// Write sortedNames list to text file
                IOutput fileOutput = new FileOutput();
                fileOutput.Generate(sortedNames);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message + e.StackTrace);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
