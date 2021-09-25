using NUnit.Framework;
using ArithmeticLibrary.AnthonysAwesomeArithmeticOperations;

namespace AnthonysAwesomeArithmeticOperationsTests
{
    public class AnthonysAwesomeArithmeticOperationsTestClass
    {
        [Test]
        public void AdditionTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.Add(1, 1), 2);
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.Add(-1, -1), -2);
        }
        [Test]
        public void SubtractionTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.Subtract(5, 4), 1);
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.Subtract(-2, -4), 2);
        }
        [Test]
        public void MultiplicationTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.Multiply(5, 5), 25);
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.Multiply(-5, 5), -25);
        }
        [Test]
        public void DivisionTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.Divide(25, 5), 5);
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.Divide(-25, 5), -5);
        }
        [Test]
        public void SquareRootTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.SquareRoot(9), 3);
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.SquareRoot(81), 9);
        }
        [Test]
        public void ExponentTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.Exponent(3, 3), 27);
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.Exponent(8, -1), .125);
        }
        #region To Integer Tests
        [Test]
        public void BinaryToIntegerTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.BinaryToInteger("00000001"), 1);
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.BinaryToInteger("00000010"), 2);
        }
        [Test]
        public void OctalToIntegerTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.OctalToInteger("001"), 1);
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.OctalToInteger("002"), 2);
        }
        [Test]
        public void HexadecimalToIntegerTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.HexadecimalToInteger("01"), 1);
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.HexadecimalToInteger("0B"), 11);
        }
        #endregion
        #region To Octal Tests
        [Test]
        public void IntegerToOctalTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.IntegerToOctal(1), "001");
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.IntegerToOctal(2), "002");
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.IntegerToOctal(9), "011");
        }
        [Test]
        public void BinaryToOctalTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.BinaryToOctal("00000001"), "001");
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.BinaryToOctal("00001001"), "011");
        }
        [Test]
        public void HexadecimalToOctalTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.HexadecimalToOctal("01"), "001");
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.HexadecimalToOctal("08"), "010");
        }
        #endregion
        #region To Hexadecimal Tests
        [Test]
        public void IntegerToHexadecimalTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.IntegerToHexadecimal(11).ToUpper(), "0B");
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.IntegerToHexadecimal(1).ToUpper(), "01");
        }
        [Test]
        public void BinaryToHexadecimalTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.BinaryToHexadecimal("00000001").ToUpper(), "01");
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.BinaryToHexadecimal("00001001").ToUpper(), "09");        }
        [Test]
        public void OctalToHexadecimalTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.OctalToHexadecimal("001"), "01");
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.OctalToHexadecimal("010"), "08");
        }
        #endregion
        #region To Binary Tests
        [Test]
        public void IntegerToBinaryTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.IntegerToBinary(1), "00000001");
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.IntegerToBinary(2), "00000010");
        }
        [Test]
        public void OctalToBinaryTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.OctalToBinary("001"), "00000001");
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.OctalToBinary("011"), "00001001");
        }
        [Test]
        public void HexadecimalToBinaryTest()
        {
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.HexadecimalToBinary("01"), "00000001");
            Assert.AreEqual(AnthonysAwesomeArithmeticOperations.HexadecimalToBinary("09"), "00001001");
        }
        #endregion
    }
}