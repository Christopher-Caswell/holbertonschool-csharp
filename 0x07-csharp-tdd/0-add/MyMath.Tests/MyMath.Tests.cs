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
        public void Test1()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, MyMath.Operations.Add(1, 0));
        }
        
        [Test]
        public void Test3()
        {
            Assert.AreNotEqual(1, MyMath.Operations.Add(1, 6));
        }
        
        [Test]
        public void Test4()
        {
            Assert.NotNull(MyMath.Operations.Add(1, 6));
        }
        
        [Test]
        public void Test5()
        {
            Assert.IsTrue(MyMath.Operations.Add(1, 6) > 0);
        }
    }
}
