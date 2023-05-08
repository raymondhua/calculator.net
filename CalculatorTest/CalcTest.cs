using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class CalcTest
    {
        Calc calculator = new Calc();
        double firstNum, secondNum, expected, actual;
        [TestMethod]
        public void AddShouldReturnCorrectSum()
        {
            firstNum = 2.0;
            secondNum = 3.0;
            expected = 5.0;
            actual = calculator.Add(firstNum, secondNum);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractShouldReturnCorrectSum()
        {
            firstNum = 453;
            secondNum = 78;
            expected = 375;
            actual = calculator.Subtract(firstNum, secondNum);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplyShouldReturnCorrectSum()
        {
            firstNum = 453;
            secondNum = 78;
            expected = 35334;
            actual = calculator.Multiply(firstNum, secondNum);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivideShouldReturnCorrectSum()
        {
            firstNum = 453;
            secondNum = 24;
            expected = 18.875;
            actual = calculator.Divide(firstNum, secondNum);
            Assert.AreEqual(expected, actual);
        }

    }
}