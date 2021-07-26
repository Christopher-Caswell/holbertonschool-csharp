using NUnit.Framework;

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
        /// Test if the method returns true if the string is a palindrome, generic basis
        /// </summary>
        public void Test1()
        {
            Assert.Pass();
        }
        
        [Test]
        /// <summary>
        /// Test my favorite palindrome
        /// </summary>
        public void Test1()
        {
            Assert.True(Text.Str.IsPalindrome("eva can i stack rods sad ass dork cats in a cave"));
        }

    }
}
