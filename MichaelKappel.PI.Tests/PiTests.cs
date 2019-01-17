using Microsoft.VisualStudio.TestTools.UnitTesting;
using VariableBase.Mathematics;

namespace MichaelKappel.PI.Tests
{
    [TestClass]
    public class PiTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            PI test = new PI();
            Number pi = test.Get();

            Assert.IsNotNull(pi);
        }
    }
}
