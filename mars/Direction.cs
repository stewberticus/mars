using System;

namespace mars
{
    public enum Direction
    {
        North,
        East,
        South,
        West

    }

    public class DirectionStateMachine
    {
        //private by default 
        Direction _cur_dir;

        public DirectionStateMachine(Direction d)
        {
            _cur_dir = d;
        }

        public static Direction? DirectionFromString(String input)
        {
            switch (input)
            {
                case "N":
                    return Direction.North;
                case "S":
                    return Direction.South;
                case "W":
                    return Direction.West;
                case "E":
                    return Direction.East;
            }

            return null;
        }

        public Direction Get()
        {
            return _cur_dir;
        }

        override public String ToString()
        {
            switch (_cur_dir)
            {
                case Direction.North:
                    return "N";
                case Direction.South:
                    return "S";
                case Direction.East:
                    return "E";
                case Direction.West:
                    return "W";
                
            }
            return "";
        }

        public void TurnLeft()
        {
            switch (_cur_dir)
            {
                case Direction.North:
                    _cur_dir = Direction.West;
                    break;
                case Direction.West:
                    _cur_dir = Direction.South;
                    break;
                case Direction.South:
                    _cur_dir = Direction.East;
                    break;
                case Direction.East:
                    _cur_dir = Direction.North;
                    break;
            };
        }

        public void TurnRight()
        {
            switch (_cur_dir)
            {
                case Direction.North:
                    _cur_dir = Direction.East;
                    break;
                case Direction.East:
                    _cur_dir = Direction.South;
                    break;
                case Direction.South:
                    _cur_dir = Direction.West;
                    break;
                case Direction.West:
                    _cur_dir = Direction.North;
                    break;
            };
        }
    }
}
