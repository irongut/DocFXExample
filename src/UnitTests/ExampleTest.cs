using DocFXExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ExampleTest
    {
        [TestMethod]
        public void DivideTest()
        {
            (int quotient, int remainder) = Example.Divide(10, 2);
            Assert.AreEqual(5, quotient);
            Assert.AreEqual(0, remainder);

            (quotient, remainder) = Example.Divide(10, 3);
            Assert.AreEqual(3, quotient);
            Assert.AreEqual(1, remainder);
        }
    }
}
