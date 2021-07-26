using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        /// <summary>
        /// Test the Max function, generic basis
        /// </summary>
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        /// <summary>
        /// Test the simplest case of Max function
        /// </summary>
        public void Test2()
        {
            Assert.AreEqual(2, MyMath.Operations.Max(new List<int> {1, 2}));
        }
        [Test]
        /// <summary>
        /// Test the negative case of Max function
        /// </summary>
        public void Test3()
        {
            Assert.AreEqual(-2, MyMath.Operations.Max(new List<int> {-2, -3, -4, -10}));
        }
        [Test]
        /// <summary>
        /// Test all numbers the same
        /// </summary>
        public void Test4()
        {
            Assert.AreEqual(9, MyMath.Operations.Max(new List<int> {9, 9, 9, 9, 9}));
        }
        [Test]
        /// <summary>
        /// Test use with a mostly non int list
        /// </summary>
        public void Test5()
        {
            Assert.AreEqual(0, MyMath.Operations.Max(new List<int> {0, w, o, m, p}));
        }
    }
}
