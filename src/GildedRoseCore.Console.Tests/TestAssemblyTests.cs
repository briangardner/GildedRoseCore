using System;
using ConsoleApplication;
using Xunit;

namespace Tests
{
    public class TestAssemblyTests
    {
        private readonly Program _program;
        public TestAssemblyTests()
        {
            _program = new Program();
        }
        [Fact]
        public void TestTheTruth() 
        {
            Assert.True(true);
        }
    }
}
