using NUnit.Framework;
using System;

namespace AllHW.Test
{
    public class HW1Tests
    {
        [TestCase(4, 2, 2, 0)]
        [TestCase(11, 3, 3, 2)]
        [TestCase(5, 2, 2, 1)]
        public void FindResultOfDivisionTest(int dividend, int divider, int expected1, int expected2)
        {
            int actual1;
            int actual2;

            HW1.FindResultOfDivision(dividend, divider, out actual1, out actual2);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestCase(2, 2)]
        [TestCase(-2, -2)]
        public static void DivisionCalculationTest_WhenValuesAreZeroShouldExeption(double a, double b)
        {
            Assert.Throws<Exception>(() => HW1.DivisionCalculation(a, b));
        }

        [TestCase("qqq","www","www","qqq")]
        [TestCase("qwerty","","","qwerty")]
        [TestCase("wds","awe","awe","wds")]
        public static void SwapStringValuesTests(string a, string b, string expected1, string expected2)
        {
            HW1.SwapStringValues(a, b, out expected1, out expected2);
            Assert.AreEqual(expected1, b);
            Assert.AreEqual(expected2, a);
        }
    }
}