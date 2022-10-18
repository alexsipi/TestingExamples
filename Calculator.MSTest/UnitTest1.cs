using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.MSTest
{
    [TestClass]
    public class SumNumTests
    {
        [TestMethod]
        public void SumNumbers_ReturnsSum() {
            //Arrange
            var calculator = new Testing.Example.Calculator();
            //Act
            var result = calculator.SumNumbers(4, 7);
            //Asset
            Assert.AreEqual(result, 11);
        }
    }
}
