using CrazyCalcEngine;
using System;
using Xunit;

namespace CrazyCalcEngine.Tests
{
    public class MathEngine_AdditionTests
    {
        [Fact]
        public void Add_ShouldSucceed()
        {
            var m = new MathEngine();
            int actual = m.Add(2, 3);
            Assert.Equal(5, actual);
        }
    }
}
