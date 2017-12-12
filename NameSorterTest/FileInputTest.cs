using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorterApp;
using System.Collections.Generic;

namespace NameSorterTest
{
    [TestClass]
    public class FileInputTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void FileInputPassNullValue()
        {
            string path = null;
            IInput fileInput = new FileInput();
            fileInput.Read(path);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void FileInputPassEmptyString()
        {
            string path = "";
            IInput fileInput = new FileInput();
            fileInput.Read(path);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void FileInputPassNotExistFile()
        {
            string path = "./NotExistFileName.txt";
            IInput fileInput = new FileInput();
            fileInput.Read(path);
        }

        [TestMethod]
        public void FileInputCheckReturnValue()
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

            // Write mock up data to file
            string mockupFile = "Adonis Julius Archer\r\nMarin Alvarez\r\nFrankie Conner Ritter\r\n";
            string pathFile = "./mockup-name-list.txt";
            System.IO.File.WriteAllText(pathFile, mockupFile);

            // Execute Read method in FileInput
            IInput fileInput = new FileInput();
            List<Name> readNames = fileInput.Read(pathFile);

            // Compare mockupNames and readNames list should be equal
            Assert.AreEqual(readNames.Count, mockupNames.Count);
            for(int i = 0; i < readNames.Count; i++)
            {
                Assert.AreEqual(readNames[i].GivenName, mockupNames[i].GivenName);
                Assert.AreEqual(readNames[i].LastName, mockupNames[i].LastName);
            }
            System.IO.File.Delete(pathFile);
        }
    }
}
