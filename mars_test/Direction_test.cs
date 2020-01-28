using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using mars;

namespace mars_test
{
    [TestClass]
    public class Direction_test
    {
        [TestMethod]
        public void test_Init()
        {
            var rand = new Random();

            Direction dir = (Direction) rand.Next(0, 4);

            DirectionStateMachine dsm = new DirectionStateMachine(dir);

            Assert.AreEqual(dir, dsm.Get());

        }

        [TestMethod]
        public void test_DirectionFromString()
        {

            DirectionStateMachine dsm = new DirectionStateMachine(DirectionStateMachine.DirectionFromString("N").Value);
            Assert.AreEqual(Direction.North, dsm.Get());

            dsm = new DirectionStateMachine(DirectionStateMachine.DirectionFromString("S").Value);
            Assert.AreEqual(Direction.South, dsm.Get());

            dsm = new DirectionStateMachine(DirectionStateMachine.DirectionFromString("E").Value);
            Assert.AreEqual(Direction.East, dsm.Get());

            dsm = new DirectionStateMachine(DirectionStateMachine.DirectionFromString("W").Value);
            Assert.AreEqual(Direction.West, dsm.Get());

            Assert.AreEqual(null, DirectionStateMachine.DirectionFromString("X"));
            Assert.AreEqual(null, DirectionStateMachine.DirectionFromString(" "));
            Assert.AreEqual(null, DirectionStateMachine.DirectionFromString("3"));
            Assert.AreEqual(null, DirectionStateMachine.DirectionFromString("+"));

        }

        [TestMethod]
        public void test_Turn()
        {
            var rand = new Random();

            Direction dir = (Direction)rand.Next(0, 4);

            DirectionStateMachine dsm = new DirectionStateMachine(dir);

            dsm.TurnLeft();
            dsm.TurnRight();

            Assert.AreEqual(dir, dsm.Get());

            dsm.TurnRight();
            dsm.TurnLeft();

            Assert.AreEqual(dir, dsm.Get());

            dsm.TurnRight();
            dsm.TurnRight();
            dsm.TurnRight();
            dsm.TurnRight();

            Assert.AreEqual(dir, dsm.Get());

            dsm.TurnLeft();
            dsm.TurnLeft();
            dsm.TurnLeft();
            dsm.TurnLeft();

            Assert.AreEqual(dir, dsm.Get());


        }
    }
}
