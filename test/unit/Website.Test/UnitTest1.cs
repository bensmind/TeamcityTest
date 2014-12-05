using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Website.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            1.Should().Be(1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            2.Should().Be(2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            3.Should().Be(3);
        }
        [TestMethod]
        public void TestMethod4()
        {
            4.Should().Be(4);
        }
        [TestMethod]
        public void TestMethod5()
        {
            5.Should().Be(5);
        }

    }
}
