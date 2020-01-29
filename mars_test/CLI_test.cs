using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

using mars;

namespace mars_test
{
    [TestClass]
    public class CLI_test
    {
        [TestMethod]
        public void test_Input1()
        {
            var sw = new StringWriter();
            var sr = new StringReader("5 5" + Environment.NewLine + "1 2 N" + Environment.NewLine + "LMLMLMLMM");

            Console.SetOut(sw);
            Console.SetIn(sr);

            var arg = new String[0];
            mars.Program.Main(arg);

            var result = sw.ToString();
            Assert.AreEqual(result, "1 3 N" + Environment.NewLine);

        }
        [TestMethod]
        public void test_Input2()
        {
            var sw = new StringWriter();
            var sr = new StringReader("5 5" + Environment.NewLine + "3 3 E" + Environment.NewLine + "MMRMMRMRRM");

            Console.SetOut(sw);
            Console.SetIn(sr);

            var arg = new String[0];
            mars.Program.Main(arg);

            var result = sw.ToString();
            Assert.AreEqual(result, "5 1 E" + Environment.NewLine);

        }
        [TestMethod]
        public void test_Input3()
        {
            var sw = new StringWriter();
            var sr = new StringReader("10 10" + Environment.NewLine + "0 0 N" + Environment.NewLine + "MMRMM");

            Console.SetOut(sw);
            Console.SetIn(sr);

            var arg = new String[0];
            mars.Program.Main(arg);

            var result = sw.ToString();
            Assert.AreEqual(result, "2 2 E" + Environment.NewLine);

        }
        [TestMethod]
        public void test_Input4()
        {
            var sw = new StringWriter();
            var sr = new StringReader("10 10" + Environment.NewLine + "0 0 N" + Environment.NewLine + "MMMMMMMMMMRMMMMMMMMMMR");

            Console.SetOut(sw);
            Console.SetIn(sr);

            var arg = new String[0];
            mars.Program.Main(arg);

            var result = sw.ToString();
            Assert.AreEqual(result, "10 10 S" + Environment.NewLine);

        }
        [TestMethod]
        public void test_Input5()
        {
            var sw = new StringWriter();
            var sr = new StringReader("1 1" + Environment.NewLine + "0 0 N" + Environment.NewLine + "RRRRLLLL");

            Console.SetOut(sw);
            Console.SetIn(sr);

            var arg = new String[0];
            mars.Program.Main(arg);

            var result = sw.ToString();
            Assert.AreEqual(result, "0 0 N" + Environment.NewLine);


        }
    }
}
