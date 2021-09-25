using System;

namespace ArithmeticLibrary.AnthonysAwesomeArithmeticOperations
{
    public static class AnthonysAwesomeArithmeticOperations
    {
        /// <summary>
        /// Adds two values together to produce a result.
        /// </summary>
        /// <param name="a">First value to add.</param>
        /// <param name="b">Second value to add.</param>
        /// <returns>A float value indicating the sum of the two parameters passed in.</returns>
        public static float Add(float a, float b)
        {
            return a + b;
        }
        /// <summary>
        /// Subtracts two values from one another to produce a result.
        /// </summary>
        /// <param name="a">First value to subtract.</param>
        /// <param name="b">Second value to subtract.</param>
        /// <returns>A float value indicating the difference of the two parameters passed in.</returns>
        public static float Subtract(float a, float b)
        {
            return a - b;
        }
        /// <summary>
        /// Multiplies two values to produce a result.
        /// </summary>
        /// <param name="a">First value to multiply.</param>
        /// <param name="b">Second value to multiply.</param>
        /// <returns>A float value indicating the result of the multiplication of the two parameters passed in.</returns>
        public static float Multiply(float a, float b)
        {
            return a * b;
        }
        /// <summary>
        /// Divides two values to produce a result.
        /// </summary>
        /// <param name="a">First value to divide.</param>
        /// <param name="b">Second value to divide.</param>
        /// <returns>A float value indicating the result of the division of the two parameters passed in.</returns>
        public static float Divide(float a, float b)
        {
            return a / b;
        }
        /// <summary>
        /// Provides the square root of a given float number.
        /// </summary>
        /// <param name="a">Value to square.</param>
        /// <returns>A float value indicating the square root of the parameter passed in.</returns>
        public static float SquareRoot(float a)
        {
            if (a < 0)
            {
                return float.NaN;
            }

            float root = a / 3;
            int i;
            for (i = 0; i < 32; i++)
            {
                root = (root + a / root) / 2;
            }
            return root;
        }
        /// <summary>
        /// Provides the result of a number raised to a certain power.
        /// </summary>
        /// <param name="number">Value to raise to a specific power provided.</param>
        /// <param name="powerToRaiseTo">Value indicating power to raise number to.</param>
        /// <returns>A float value indicating the result of a number raised to the given power passed in.</returns>
        public static float Exponent(float number, float powerToRaiseTo)
        {
            if(powerToRaiseTo == 1)
            {
                return number;
            }
            else if(powerToRaiseTo < 0)
            {
                return float.Parse(Math.Pow(number, powerToRaiseTo).ToString());
            }
            float result = 1;
            while (powerToRaiseTo != 0)
            {
                result *= number;
                powerToRaiseTo--;
            }
            return result;
        }

        /// <summary>
        /// Converts binary number into integer equivalent.
        /// </summary>
        /// <param name="value">Binary value to convert.</param>
        /// <returns>An integer from a binary value.</returns>
        public static int BinaryToInteger(string value)
        {
            return Convert.ToInt32(value, 2);
        }
        /// <summary>
        /// Converts octal number into integer equivalent.
        /// </summary>
        /// <param name="value">Octal value to convert.</param>
        /// <returns>An integer from an octal value.</returns>
        public static int OctalToInteger(string value)
        {
            return Convert.ToInt32(value, 8);
        }
        /// <summary>
        /// Converts hexadecimal number into integer equivalent.
        /// </summary>
        /// <param name="value">Hexadecimal value to convert.</param>
        /// <returns>An integer from a hexadecimal value.</returns>
        public static int HexadecimalToInteger(string value)
        {
            return Convert.ToInt32(value, 16);
        }
        #region Private To Integer Method
        private static int ConvertToIntegerFromBase(string value, int fromBase)
        {
            return Convert.ToInt32(value, fromBase);
        }
        #endregion
        /// <summary>
        /// Converts integer number into octal equivalent.
        /// </summary>
        /// <param name="value">Integer value to convert.</param>
        /// <returns>An octal number from an integer value.</returns>
        public static string IntegerToOctal(int value)
        {
            return Convert.ToString(value, 8).PadLeft(3, '0');
        }
        /// <summary>
        /// Converts binary number into octal equivalent.
        /// </summary>
        /// <param name="value">Binary value to convert.</param>
        /// <returns>An octal number from a binary value.</returns>
        public static string BinaryToOctal(string value)
        {
            int intValue = Convert.ToInt32(value, 2);
            return Convert.ToString(intValue, 8).PadLeft(3, '0');
        }
        /// <summary>
        /// Converts hexadecimal number into octal equivalent.
        /// </summary>
        /// <param name="value">Hexadecimal value to convert.</param>
        /// <returns>An octal number from a hexadecimal value.</returns>
        public static string HexadecimalToOctal(string value)
        {
            int intValue = Convert.ToInt32(value, 16);
            return Convert.ToString(intValue, 8).PadLeft(3, '0'); 
        }
        /// <summary>
        /// Converts integer value into hexadecimal equivalent.
        /// </summary>
        /// <param name="value">Integer value to convert.</param>
        /// <returns>A hexadecimal number from an integer value.</returns>
        public static string IntegerToHexadecimal(int value)
        {
            return Convert.ToString(value, 16).PadLeft(2, '0');
        }
        /// <summary>
        /// Converts binary value into hexadecimal equivalent.
        /// </summary>
        /// <param name="value">Binary value to convert.</param>
        /// <returns>A hexadecimal number from a binary value.</returns>
        public static string BinaryToHexadecimal(string value)
        {
            int intValue = Convert.ToInt32(value, 2);
            return Convert.ToString(intValue, 16).PadLeft(2, '0');
        }
        /// <summary>
        /// Converts octal value into hexadecimal equivalent.
        /// </summary>
        /// <param name="value">Octal value to convert.</param>
        /// <returns>A hexadecimal number from an octal value.</returns>
        public static string OctalToHexadecimal(string value)
        {
            int intValue = Convert.ToInt32(value, 8);
            return Convert.ToString(intValue, 16).PadLeft(2, '0');
        }
        /// <summary>
        /// Converts integer number into binary equivalent.
        /// </summary>
        /// <param name="value">Integer value to convert.</param>
        /// <returns>A binary number from an integer value.</returns>
        public static string IntegerToBinary(int value)
        {
            return Convert.ToString(value, 2).PadLeft(8, '0'); ;
        }
        /// <summary>
        /// Converts octal number into binary equivalent.
        /// </summary>
        /// <param name="value">Octal value to convert.</param>
        /// <returns>A binary number from an octal value.</returns>
        public static string OctalToBinary(string value)
        {
            int intValue = Convert.ToInt32(value, 8);
            return Convert.ToString(intValue, 2).PadLeft(8, '0');
        }
        /// <summary>
        /// Converts hexadecimal number into binary equivalent.
        /// </summary>
        /// <param name="value">Hexadecimal value to convert.</param>
        /// <returns>A binary number from a hexadecimal value.</returns>
        public static string HexadecimalToBinary(string value)
        {
            int intValue = Convert.ToInt32(value, 16);
            return Convert.ToString(intValue, 2).PadLeft(8, '0');
        }
    }
}