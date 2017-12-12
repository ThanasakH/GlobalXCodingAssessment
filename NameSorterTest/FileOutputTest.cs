using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorterApp;
using System.Collections.Generic;

namespace NameSorterTest
{
    [TestClass]
    public class FileOutputTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void FileOutputPassNullValue()
        {
            IOutput fileOutput = new FileOutput();
            fileOutput.Generate(null);
        }

        [TestMethod]
        public void FileOutputExistFile()
        {
            List<Name> mockupNames = new List<Name>();
            Name name = new Name();
            name.GivenName = "Adonis Julius";
            mockupNames.Add(name);
            IOutput fileOutput = new FileOutput();
            fileOutput.Generate(mockupNames);
            string pathFile = ((FileOutput)fileOutput).PathFile;
            Assert.IsTrue(System.IO.File.Exists(pathFile));
        }

        [TestMethod]
        public void FileOutputCheckFileResult()
        {
            // Add mock up data to mockupNames list
            List<Name> mockupNames = new List<Name>();
            Name name;
            name = new Name();
            name.GivenName = "Adonis Julius";
            name.LastName = "Archer";
            mockupNames.Add(name);
            name = new Name();
            name.GivenName = "Marin";
            name.LastName = "Alvarez";
            mockupNames.Add(name);
            name = new Name();
            name.GivenName = "Frankie Conner";
            name.LastName = "Ritter";
            mockupNames.Add(name);

            // Execute Generate method in FileOutput
            IOutput fileOutput = new FileOutput();
            fileOutput.Generate(mockupNames);

            // Compare generated text to respected result
            string fileResult = System.IO.File.ReadAllText(((FileOutput)fileOutput).PathFile);
            string respectedResult = "Adonis Julius Archer\r\nMarin Alvarez\r\nFrankie Conner Ritter\r\n";
            Assert.AreEqual(fileResult, respectedResult);
        }
    }
}
