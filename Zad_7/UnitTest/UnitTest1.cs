using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba7;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Matrix r = new Matrix(3, 5, 5, 5, 7, 7, 7, 9, 9, 9);
            Matrix A = new Matrix(3, 1, 1, 1, 2, 2, 2, 3, 3, 3);
            Matrix B = new Matrix(3, 4, 4, 4, 5, 5, 5, 6, 6, 6);

            Matrix res = A + B;
            Assert.ReferenceEquals(r, res);
        }
        [TestMethod]
        public void TestMethod2()
        {

            Matrix r = new Matrix(3, -3, -3, -3, -3, -3, -3, -3, -3, -3);
            Matrix A = new Matrix(3, 1, 1, 1, 2, 2, 2, 3, 3, 3);
            Matrix B = new Matrix(3, 4, 4, 4, 5, 5, 5, 6, 6, 6);

            Matrix res = A - B;
            Assert.ReferenceEquals(r, res);
        }
        [TestMethod]
        public void TestMethod3()
        {

            Matrix r = new Matrix(3, 24, 24, 24, 30, 30, 30, 36, 36, 36);
            Matrix A = new Matrix(3, 1, 1, 1, 2, 2, 2, 3, 3, 3);
            Matrix B = new Matrix(3, 4, 4, 4, 5, 5, 5, 6, 6, 6);

            Matrix res = A * B;
            Assert.ReferenceEquals(r, res);
        }

    }
}
