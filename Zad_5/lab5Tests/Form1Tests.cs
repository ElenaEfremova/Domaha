using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test1()
        {
            //arrange
            Vector vector = new Vector(2, 1, 2);
            Vector vector2 = new Vector(3, 1, 3);
            Vector expected = new Vector(1, 0, -1);

            //act
            Vector actual = vector * vector2;

            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod()]
        public void FormTest2()
        {
            //arrange
            Vector vector = new Vector(2, 1, 2);
            Vector vector2 = new Vector(3, 1, 3);
            Vector expected = new Vector(5, 2, 5);
            Vector actual;

            //act
            actual = vector + vector2;

            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod()]
        public void Form1Test3()
        {
            //arrange
            Vector vector = new Vector(2, 1, 2);
            Vector vector2 = new Vector(3, 1, 3);
            double expected = 13;
            double actual;

            //act
            actual = vector ^ vector2;

            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}