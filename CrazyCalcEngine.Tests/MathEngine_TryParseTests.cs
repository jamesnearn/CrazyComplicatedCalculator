using CrazyCalcEngine;
using System;
using Xunit;

namespace CrazyCalcEngine.Tests
{
    public class MathEngine_TryParseTests
    {
        [Theory]
        [InlineData("2+3", 5)]

        [InlineData("2+3 + 4", 9)]
        [InlineData("2 + 3+4", 9)]
        [InlineData("2+3+4", 9)]
        [InlineData("2 + 3 + 4", 9)]

        [InlineData("2", 2)]
        [InlineData("-2", -2)]
        [InlineData("-2 + 3", 1)]
        [InlineData("3 + -2", 1)]

        [InlineData("5-3", 2)]
        [InlineData("11-5-3", 3)]

        public void TryParse_ShouldSucceed(string given, int expected)
        {
            var m = new MathEngine();
            int actual;
            bool parseResults = m.TryParse(given, out actual);
            Assert.True(parseResults, "TryParse should succeed.");
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("2++3")]
        [InlineData("+2")]
        [InlineData("+2+3")]
        [InlineData("+2+3+")]
        [InlineData("2+3+")]
        public void TryParse_ShouldFail(string given)
        {
            var m = new MathEngine();
            int actual;
            bool parseResults = m.TryParse(given, out actual);
            Assert.False(parseResults, "TryParse should fail.");
        }
    }
}
