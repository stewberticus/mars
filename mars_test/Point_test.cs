using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using mars;

namespace mars_test
{
    [TestClass]
    public class Point_test
    {
        [TestMethod]
        public void test_Init()
        {

            var rand = new Random();
            var x = rand.Next();
            var y = rand.Next();

            var point = new Point(x, y);

            Assert.AreEqual(point.X(), x);
            Assert.AreEqual(point.Y(), y);

        }

        [TestMethod]
        public void test_Inc()
        {
            var rand = new Random();
            var x = rand.Next();
            var y = rand.Next();

            var point = new Point(x, y);

            //1
            point.IncX();

            //2
            point.IncY();
            point.IncY();

            Assert.AreEqual(point.X(), x + 1);
            Assert.AreEqual(point.Y(), y + 2);

        }

        [TestMethod]
        public void test_Dec()
        {

            var rand = new Random();
            var x = rand.Next();
            var y = rand.Next();

            var point = new Point(x, y);

            //1
            point.DecX();

            //2
            point.DecY();
            point.DecY();

            Assert.AreEqual(point.X(), x - 1);
            Assert.AreEqual(point.Y(), y - 2);

        }

        [TestMethod]
        public void test_toString()
        {

            var p = new Point(1, 3);

            Assert.AreEqual(p.ToString(), "1 3");


        }
    }
}
