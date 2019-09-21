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
        public void GetLength_Input99_Returns99()
        {
            //Arrange
            int length = 99;
            int width = 89;
            Rectangle sampleRectangle = new Rectangle(length, width);

            //Act
            int expected= sampleRectangle.GetLength();

            //Assert
            Assert.AreEqual(expected, length);
        }

        [Test]
        public void SetLength_Input1000_Returns1000()
        {
            //Arrange
            int length = 1000;
            int width = 200;
            Rectangle sampleRectangle = new Rectangle(length, width);

            //Act
            int expected = sampleRectangle.SetLength(1000);

            //Assert
            Assert.AreEqual(expected, length);
        }

        [Test]
        public void GetWidth_Input5_Returns5()
        {
            //Arrange
            int length = 20;
            int width = 5;
            Rectangle sampleRectangle = new Rectangle(length, width);

            //Act
            int expected = sampleRectangle.GetWidth();

            //Assert
            Assert.AreEqual(expected,width);
        }

        [Test]
        public void SetWidth_Input900_Returns900()
        {
            //Arrange
            int length = 200;
            int width = 900;
            Rectangle sampleRectangle = new Rectangle(length, width);

            //Act
            int expected = sampleRectangle.SetWidth(900);

            //Assert
            Assert.AreEqual(expected, width);
        }

        [Test]
        public void GetPerimeter_Input20And5_Returns50()
        {
            //Arrange
            int length = 20;
            int width = 5;
            Rectangle sampleRectangle = new Rectangle(length, width);
            int expected = 2 * (length + width);

            //Act
            int perimeter = sampleRectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected,perimeter);
        }

        [Test]
        public void GetArea_Input100And7_Returns700()
        {
            //Arrange
            int l = 20;
            int w = 5;
            Rectangle sampleRectangle = new Rectangle(l, w);
            int expected = l*w;

            //Act
            int area = sampleRectangle.GetArea();

            //Assert
            Assert.AreEqual(expected, area);
        }

    }
}
