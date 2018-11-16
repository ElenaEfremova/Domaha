using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3_EPAM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_EPAM.Tests
{
    [TestClass()]
    public class NodTests
    {
        [TestMethod()]
        public void GCDTest()
        {
            //arrange
            int x = 10;
            int y = 20;
            int z = 30;
            int expected = 10;

            //act
            int actual = Nod.nodBigInput(x, y, z);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}