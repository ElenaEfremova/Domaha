using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab4_epam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_epam.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            //arrange
            double x = 1;
            double y = 1;
            double z = 1;
            double expected = 3;
            Triangle obj = new Triangle(x, y, z);

            //act
            double actual = obj.perimeter();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Form2Test()
        {
            //arrange
            double x = 3;
            double y = 4;
            double z = 5;
            double expected = 6;
            Triangle obj = new Triangle(x, y, z);

            //act
            double actual = obj.value();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}