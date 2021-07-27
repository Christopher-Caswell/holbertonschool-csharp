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
        /// Test number in middle of list
        /// </summary>
        public void Test5()
        {
            Assert.AreEqual(2, MyMath.Operations.Max(new List<int> {1, 1, 2, 1, 1}));
        }
        [Test]
        /// <summary>
        /// Test number in empty list
        /// </summary>
        public void Test6()
        {
            Assert.AreEqual(0, MyMath.Operations.Max(new List<int> {}));
        }
    }
}
