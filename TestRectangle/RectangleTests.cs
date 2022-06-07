using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Teena_Thomas_8805388_Assignment2;

namespace TestRectangle
{
    public class RectangleTests
    {
        [TestFixture]
        public class RectangleTest
        { 
            
            [Test]
            public void GetLengthWithValue_2()
            {
                //Arrange
                Rectangle rect = new Rectangle(2,3);
                int expected = 2;
                //Act
                int actual = rect.GetLength();
                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetLengthWithValue_0()
            {
                //Arrange
                Rectangle rect = new Rectangle(0, 3);
                int expected = 0;
                //Act
                int actual = rect.GetLength();
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void GetLengthWithValue_negative1()
            {
                //Arrange
                Rectangle rect = new Rectangle(-1, 3);
                int expected = -1;
                //Act
                int actual = rect.GetLength();
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void SetLengthWithValue_2()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expected = 2;
                //Act
                int actual = rect.SetLength(2);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void SetLengthWithValue_6()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expected = 6;
                //Act
                int actual = rect.SetLength(6);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void SetLengthWithValue_10()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expected = 10;
                //Act
                int actual = rect.SetLength(10);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void GetWidthWithValue_3()
            {
                //Arrange
                Rectangle rect = new Rectangle(4, 3);
                int expected = 3;
                //Act
                int actual = rect.GetWidth();
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void GetWidthWithValue_0()
            {
                //Arrange
                Rectangle rect = new Rectangle(4, 0);
                int expected = 0;
                //Act
                int actual = rect.GetWidth();
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void GetWidthWithValue_negative1()
            {
                //Arrange
                Rectangle rect = new Rectangle(4, -1);
                int expected = -1;
                //Act
                int actual = rect.GetWidth();
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void SetWidthWithValue_10()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expected = 10;
                //Act
                int actual = rect.SetWidth(10);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void SetWidthWithValue_7()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expected = 7;
                //Act
                int actual = rect.SetWidth(7);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void SetWidthWithValue_9()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expected = 9;
                //Act
                int actual = rect.SetWidth(9);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void GetPerimeterValue_2_3()
            {
                //Arrange
                Rectangle rect = new Rectangle(2, 3);
                int expected = 10;
                //Act
                int actual = rect.GetPerimeter();
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void GetPerimeterValue_4_5()
            {
                //Arrange
                Rectangle rect = new Rectangle(4, 5);
                int expected = 18;
                //Act
                int actual = rect.GetPerimeter();
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void GetPerimeterValue_5_5()
            {
                //Arrange
                Rectangle rect = new Rectangle(5, 5);
                int expected = 20;
                //Act
                int actual = rect.GetPerimeter();
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void GetAreaValue_6_8()
            {
                //Arrange
                Rectangle rect = new Rectangle(6, 8);
                int expected = 48;
                //Act
                int actual = rect.GetArea();
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void GetAreaValue_2_5()
            {
                //Arrange
                Rectangle rect = new Rectangle(2, 5);
                int expected = 10;
                //Act
                int actual = rect.GetArea();
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void GetAreaValue_5_7()
            {
                //Arrange
                Rectangle rect = new Rectangle(5, 7);
                int expected = 35;
                //Act
                int actual = rect.GetArea();
                //Assert
                Assert.AreEqual(expected, actual);
            }

        }
    }
}
