using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Product.Library.Unit.Tests
{
    public class CalculatorTests
    {
        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { 2, 2, 4 };
            yield return new object[] { 3, -3, 0 };
            yield return new object[] { 1.23m, 2.34m, 3.57m };
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void When_AddingTwoNumbers_Expect_TheSum(decimal a, decimal b, decimal sum)
        {
            new Calculator().Add(a, b).Should().Be(sum);
        }
    }
}
