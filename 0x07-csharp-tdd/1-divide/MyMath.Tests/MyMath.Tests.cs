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
        /// Test method basis for MyMath.Divide(int, int).
        /// </summary>
        public void Test1()
        {
            Assert.Pass();
        }
        
        [Test]
        /// <summary>
        /// Test method on division by zero.
        /// </summary>
        public void Test2()
        {
            Assert.AreEqual(null, MyMath.Matrix.Divide(new[,]{{1, 2}, {3, 4}}, 0));
        }
        
        [Test]
        /// <summary>
        /// Test method on division by one.
        /// </summary>
        public void Test3()
        {
            Assert.AreEqual(new[,]{{1, 2}, {3, 4}}, MyMath.Matrix.Divide(new[,]{{1, 2}, {3, 4}}, 1));
        }
        
        [Test]
        /// <summary>
        /// Test method for generically correct.
        /// </summary>
        public void Test4()
        {
            Assert.AreEqual(new[,]{{1, 1}, {3, 2}}, MyMath.Matrix.Divide(new[,]{{2, 2}, {6, 4}}, 2));
        }
        
        [Test]
        /// <summary>
        /// Test method for floats vs null.
        /// </summary>
        public void Test5()
        {
            Assert.AreNotEqual(null, MyMath.Matrix.Divide(new[,]{{1, 2}, {3, 4}}, 3));
        }
        
        [Test]
        /// <summary>
        /// Test method to determine if the matrix is null.
        /// </summary>
        public void Test6()
        {
            Assert.NotNull(MyMath.Matrix.Divide(new[,]{{1, 2}, {3, 4}}, 4));
        }
        [Test]
        /// <summary>
        /// Test method if the matrix is null
        /// </summary>
        public void Test7()
        {
            int[,] nuisance = null;
            Assert.IsNull(MyMath.Matrix.Divide(nuisance, 1));
        }
    }
}
