using NUnit.Framework;

namespace Calculator.NUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Test1() {
            //Arrange
            var calculator = new Testing.Example.Calculator();
            //Act
            var result = calculator.SumNumbers(4, 7);
            //Asset
            Assert.AreEqual(result, 11);
            Assert.That(result, Is.EqualTo(11));
        }
    }
}