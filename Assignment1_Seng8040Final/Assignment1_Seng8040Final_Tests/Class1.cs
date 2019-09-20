using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_Seng8040Final;
using NUnit.Framework;

namespace Assignment1_Seng8040Final_Tests
{
    [TestFixture]
    class Assignment1_Seng8040Final_Tests
    {
        [Test]
        public void GetLength_input3_expectedLEngthEquals3()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);
            //Act
            int length = testRectangle.GetLength();
            //Assert
            Assert.AreEqual(l, length);
        }
    }
}
