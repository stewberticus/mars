using Microsoft.VisualStudio.TestTools.UnitTesting;

using mars;
namespace mars_test
{

    [TestClass]
    public class Rover_test
    {
        [TestMethod]
        public void test_init()
        {

            Rover rover = new Rover(new Point(2, 2), new Point(0, 0), Direction.North);
            Assert.AreEqual(rover.ToString(), "0 0 N");

            try
            {
                rover = new Rover(new Point(0, 0), new Point(1, 1), Direction.North);
                Assert.Fail();

            }
            catch (Rover.RoverOutOfBoundsException){};

            try
            {
                rover = new Rover(new Point(0, 0), new Point(0, 1), Direction.North);
                Assert.Fail();

            }
            catch (Rover.RoverOutOfBoundsException) { };

            try
            {
                rover = new Rover(new Point(0, 0), new Point(1, 0), Direction.North);
                Assert.Fail();

            }
            catch (Rover.RoverOutOfBoundsException) { };

            try
            {
                rover = new Rover(new Point(0, 0), new Point(-1, 0), Direction.North);
                Assert.Fail();

            }
            catch (Rover.RoverOutOfBoundsException) { };

            try
            {
                rover = new Rover(new Point(0, 0), new Point(0, -1), Direction.North);
                Assert.Fail();

            }
            catch (Rover.RoverOutOfBoundsException) { };


        }

        [TestMethod]
        public void test_MoveOutofBounds()
        {
            Rover rover = new Rover(new Point(1, 1), new Point(0, 0), Direction.North);

            try
            {
                rover.Move();
                rover.Move();
                Assert.Fail();

            }
            catch (Rover.RoverOutOfBoundsException) { };


            rover = new Rover(new Point(1, 1), new Point(0, 0), Direction.East);

            try
            {
                rover.Move();
                rover.Move();
                Assert.Fail();

            }
            catch (Rover.RoverOutOfBoundsException) { };

            rover = new Rover(new Point(1, 1), new Point(0, 0), Direction.North);

            try
            {
                rover.Move();
                rover.Move();
                Assert.Fail();

            }
            catch (Rover.RoverOutOfBoundsException) { };


            rover = new Rover(new Point(1, 1), new Point(1, 1), Direction.South);

            try
            {
                rover.Move();
                rover.Move();
                Assert.Fail();

            }

            catch (Rover.RoverOutOfBoundsException) { };
            rover = new Rover(new Point(1, 1), new Point(1, 1), Direction.West);

            try
            {
                rover.Move();
                rover.Move();
                Assert.Fail();

            }

            catch (Rover.RoverOutOfBoundsException) { };


        }

        [TestMethod]
        public void test_MoveBasic()
        {

            Rover rover = new Rover(new Point(2, 2), new Point(0, 0), Direction.North);
            rover.TurnRight();
            rover.Move();
            rover.Move();
            rover.TurnLeft();
            rover.Move();
            rover.Move();

            Assert.AreEqual("2 2 N", rover.ToString());

            rover = new Rover(new Point(2, 2), new Point(0, 0), Direction.North);
            rover.TurnRight();
            rover.Move();
            rover.Move();
            rover.TurnLeft();
            rover.Move();
            rover.Move();
            rover.TurnLeft();
            rover.Move();
            rover.Move();

            Assert.AreEqual("0 2 W", rover.ToString());

            rover = new Rover(new Point(2, 2), new Point(0, 0), Direction.North);
            rover.TurnRight();
            rover.Move();
            rover.Move();
            rover.TurnLeft();
            rover.Move();
            rover.Move();
            rover.TurnLeft();
            rover.Move();
            rover.Move();
            rover.TurnLeft();
            rover.Move();
            rover.Move();

            Assert.AreEqual("0 0 S", rover.ToString());
        }
    }
}
















