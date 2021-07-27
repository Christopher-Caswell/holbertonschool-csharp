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
        /// Test if the method returns true if the string is a palindrome, generic basis of tests
        /// </summary>
        public void Test1()
        {
            Assert.Pass();
        }
        
        [Test]
        /// <summary>
        /// Test uppercase and lowercase
        /// </summary>
        public void Test2()
        {
            Assert.True(Text.Str.IsPalindrome("Level"));
        }
        
        [Test]
        /// <summary>
        /// Test empty string
        /// </summary>
        public void Test3()
        {
            Assert.True(Text.Str.IsPalindrome(""));
        }
        
        [Test]
        /// <summary>
        /// Test with a string with spaces
        /// </summary>
        public void Test4()
        {
            Assert.True(Text.Str.IsPalindrome("a a"));
        }
        
        [Test]
        /// <summary>
        /// Test with punctuation
        /// </summary>
        public void Test5()
        {
            Assert.True(Text.Str.IsPalindrome("a,a"));
        }
    }
}
