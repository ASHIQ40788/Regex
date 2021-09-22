using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RegexDemo058;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Addition add = null;
        [TestInitialize]
        
        public void SetUp()
        {
            add = new Addition();
        }

        [TestMethod]
        public void TestSum()
        {
            ///AAA methodology

            /// Arrange
            int first = 12;
            int second = 34;
            int expected = 156;

            //Act
            int actualResult=add.Sum(first, second);

            //Assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        public void TestSum1()
        {
            ///AAA methodology

            /// Arrange
            int first = 12;
            int second = 34;
            int expected = 156;

            //Act
            int actualResult = add.Sum(first, second);

            //Assert
            Assert.AreEqual(expected, actualResult);
        }
    }
}

