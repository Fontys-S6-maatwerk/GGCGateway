using GGCGateway.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GGCGatewayTest
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void SampleMethod()
        {
            int number = 1;
            int number2 = 2;

            CodeCoverageHaver codeCoverageHaver = new CodeCoverageHaver();
            Assert.IsTrue(codeCoverageHaver.GiveACoolNumber(number, number2) == 5);
        }
    }
}
