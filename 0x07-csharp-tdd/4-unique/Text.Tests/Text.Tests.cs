using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        /// <summary>
        /// Test the method defining the first unique instance within a string.
        /// </summary>
        public void Setup()
        {
        }
        [Test]
        /// <summary>
        /// Test the last character in a string
        /// </summary>
        public void Test1()
        {
            Assert.AreEqual(4, Text.Str.UniqueChar("xxxxy"));
        }
        [Test]
        /// <summary>
        /// Test the only.
        /// </summary>
        public void Test2()
        {
            Assert.AreEqual(0, Text.Str.UniqueChar("x"));
        }
        [Test]
        /// <summary>
        /// Test the foist.
        /// </summary>
        public void Test3()
        {
            Assert.AreEqual(0, Text.Str.UniqueChar("xyyyy"));
        }
        [Test]
        /// <summary>
        /// Test the middle.
        /// </summary>
        public void Test4()
        {
            Assert.AreEqual(1, Text.Str.UniqueChar("yxy"));
        }
                [Test]
        /// <summary>
        /// Test none.
        /// </summary>
        public void Test5()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar("xx"));
        }
                [Test]
        /// <summary>
        /// Test no string
        /// </summary>
        public void Test6()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar(""));
        }
    }
}
