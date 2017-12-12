using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorterApp;

namespace NameSorterTest
{
    [TestClass]
    public class ConsoleOutputTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void ConsoleOutputPassNullValue()
        {
            IOutput consoleOutput = new ConsoleOutput();
            consoleOutput.Generate(null);
        }
    }
}
