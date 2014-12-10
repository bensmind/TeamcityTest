using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Website.Test
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod1()
        {
            1.Should().Be(1);
        }
        [Test]
        public void TestMethod2()
        {
            2.Should().Be(2);
        }
        [Test]
        public void TestMethod3()
        {
            3.Should().Be(3);
        }
        [Test]
        public void TestMethod4()
        {
            4.Should().Be(4);
        }
        [Test]
        public void TestMethod5()
        {
            5.Should().Be(5);
        }

    }
}
