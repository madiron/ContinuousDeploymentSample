using ContinuousDeploymentSample.WebApi.Controllers;
using System;
using Xunit;

namespace ContinuousDeploymentSample.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Sum_Test()
        {
            var sum = Calculator.Sum(1, 2);

            Assert.Equal(3, sum);
        }
    }
}
