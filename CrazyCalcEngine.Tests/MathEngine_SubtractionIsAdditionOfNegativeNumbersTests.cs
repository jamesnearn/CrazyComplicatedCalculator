using CrazyCalcEngine;
using System;
using Xunit;

namespace CrazyCalcEngine.Tests
{
    public class MathEngine_SubtractionIsAdditionOfNegativeNumbersTests
    {
        [Theory]
        [InlineData("-3", "-3")]
        [InlineData("5-3", "5+-3")]
        [InlineData("-5-3", "-5+-3")]
        [InlineData("-5+3", "-5+3")]
        [InlineData("11-5-3", "11+-5+-3")]

        public void SubtractionIsAdditionOfNegativeNumbers_ShouldSucceed(string given, string expected)
        {
            var m = new MathEngine();
            string actual = m.SubtractionIsAdditionOfNegativeNumbers(given);
            Assert.Equal(expected, actual);
        }
    }
}
