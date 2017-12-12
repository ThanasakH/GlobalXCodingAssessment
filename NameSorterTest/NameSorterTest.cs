using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorterApp;
using System.Collections.Generic;

namespace NameSorterTest
{
    [TestClass]
    public class NameSorterTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void NameSorterPassNullValue()
        {
            ISorter nameSorter = new NameSorter();
            nameSorter.Sort(null);
        }

        [TestMethod]
        public void NameSorterCheckSortingResult()
        {
            List<Name> mockupNames = new List<Name>();
            Name name;
            name = new Name();
            name.GivenName = "Adonis Julius";
            name.LastName = "Archer";
            mockupNames.Add(name);
            name = new Name();
            name.GivenName = "Frankie Conner";
            name.LastName = "Ritter";
            mockupNames.Add(name);
            name = new Name();
            name.GivenName = "Beau Tristan";
            name.LastName = "Bentley";
            mockupNames.Add(name);

            List<Name> respectedNames = new List<Name>();
            name = new Name();
            name.GivenName = "Adonis Julius";
            name.LastName = "Archer";
            respectedNames.Add(name);
            name = new Name();
            name.GivenName = "Beau Tristan";
            name.LastName = "Bentley";
            respectedNames.Add(name);
            name = new Name();
            name.GivenName = "Frankie Conner";
            name.LastName = "Ritter";
            respectedNames.Add(name);

            ISorter nameSorter = new NameSorter();
            List<Name> sortedNames = nameSorter.Sort(mockupNames);

            Assert.AreEqual(sortedNames.Count, respectedNames.Count);
            for (int i = 0; i < sortedNames.Count; i++)
            {
                Assert.AreEqual(sortedNames[i].GivenName, respectedNames[i].GivenName);
                Assert.AreEqual(sortedNames[i].LastName, respectedNames[i].LastName);
            }
        }
    }
}
