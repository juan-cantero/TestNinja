using NUnit.Framework;
using TestNinja.Fundamentals;
using System;
using System.Collections.Generic;
using System.Text;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        Math _math;
       
        // setup runs before each method, so math is a new instance each time
        [SetUp]
        public void Set_up()
        {
            _math = new Math();
        }


        [Test]
        public void Add_WhenCalled_SumTheArguments()
        {

            var result = _math.Add(2, 2);

            Assert.That(result, Is.EqualTo(4));

        }


        //test cases are useful to write cleaner tests, and allows us to create
        // paremetizer tests

        [Test]
        [TestCase(1,2,2)]
        [TestCase(4,2,4)]
        [TestCase(2,2,2)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expected)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(5)]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit(int limit)
        {
            var result = _math.GetOddNumbers(limit);
            Assert.That(result, Is.EquivalentTo(new [] { 1, 3, 5 }));
        }


        
    }
}
