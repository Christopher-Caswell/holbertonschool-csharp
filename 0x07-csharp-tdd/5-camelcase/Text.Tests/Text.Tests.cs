using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        /// <summary>
        /// Initializes the test environment
        /// </summary>
        public void Setup()
        {
        }

        [Test]
        /// <summary>
        /// Tests the CamelCase method, 2 words
        /// </summary>
        public void Test1()
        {
            Assert.AreEqual(2, Text.Str.CamelCase("helloWorld"));
        }
        [Test]
        /// <summary>
        /// Tests the CamelCase method, 3 words
        /// </summary>
        public void Test2()
        {
            Assert.AreEqual(3, Text.Str.CamelCase("pingIsGreat"));
        }
        [Test]
        /// <summary>
        /// Tests the CamelCase method, 5 words
        /// </summary>
        public void Test3()
        {
            Assert.AreEqual(5, Text.Str.CamelCase("areYouReadyToGrumble"));
        }
        [Test]
        /// <summary>
        /// Tests the CamelCase method, empty
        /// </summary>
        public void Test4()
        {
            Assert.AreEqual(0, Text.Str.CamelCase(""));
        }
        [Test]
        /// <summary>
        /// Tests the CamelCase method, one word capitalized
        /// </summary>
        public void Test5()
        {
            Assert.AreEqual(2, Text.Str.CamelCase("Womp"));
        }
    }
}
