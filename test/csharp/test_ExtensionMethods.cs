using Xunit;
using System;
using System.Management.Automation;

namespace PSTests.Parallel
{
    public static class PSTypeExtensionsTests
    {
        [Fact]
        public static void TestIsNumeric()
        {
            Assert.True(PSTypeExtensions.IsNumeric(42.GetType()));
        }
    }
}
