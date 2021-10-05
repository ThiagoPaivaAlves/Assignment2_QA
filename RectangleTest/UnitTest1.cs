using Assignment2_QA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RectangleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDefaultConstructor()
        {
            //instance obj
            Rectangle rectangle = new Rectangle();
            
            //getting default values
            int w = rectangle.Width;
            int h = rectangle.Height;

            //asserting

            Assert.AreEqual(1, w);
            Assert.AreEqual(1, h);
        }

        [TestMethod]
        public void TestCustomConstructor()
        {
            //instance obj
            Rectangle rectangle = new Rectangle(2, 4);

            //getting input values
            int w = rectangle.Width;
            int h = rectangle.Height;

            //asserting
            Assert.AreEqual(2, w);
            Assert.AreEqual(4, h);
        }

        [TestMethod]
        public void TestPerimeterDefaultConstructor()
        {
            //instance obj
            Rectangle rectangle = new Rectangle();

            //getting perimeter value
            int p = rectangle.getPerimeter();

            //asserting
            Assert.AreEqual(4, p);
        }

        [TestMethod]
        public void TestPerimeterCustomConstructor()
        {
            //instance obj
            Rectangle rectangle = new Rectangle(2, 4);

            //getting perimeter value
            int p = rectangle.getPerimeter();

            //asserting
            Assert.AreEqual(12, p);
        }

        [TestMethod]
        public void TestAreaDefaultConstructor()
        {
            //instance obj
            Rectangle rectangle = new Rectangle();

            //getting perimeter value
            int a = rectangle.getArea();

            //asserting
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestAreaCustomConstructor()
        {
            //instance obj
            Rectangle rectangle = new Rectangle(2, 4);

            //getting perimeter value
            int p = rectangle.getArea();

            //asserting
            Assert.AreEqual(8, p);
        }

    }
}
