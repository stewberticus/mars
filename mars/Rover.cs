using System;

namespace mars
{

    public class Rover
    {
        Point _grid_ext;
        Point _cur_pos;
        DirectionStateMachine _dir_sm;

        public Rover(Point grid_ext, Point start_pos, Direction d)
        { 
            _grid_ext = grid_ext;
            _cur_pos = start_pos;

            if (_cur_pos.Y() > _grid_ext.Y())
            {
                throw new RoverOutOfBoundsException();
            }
            if (_cur_pos.Y() < 0)
            {
                throw new RoverOutOfBoundsException();
            }
            if (_cur_pos.X() > _grid_ext.X())
            {
                throw new RoverOutOfBoundsException();
            }
            if (_cur_pos.X() < 0)
            {
                throw new RoverOutOfBoundsException();
            }

            _dir_sm = new DirectionStateMachine(d);

        }

        public void Move()
        {
            switch (_dir_sm.Get())
            {
                case Direction.North:
                    if(_cur_pos.Y() >= _grid_ext.Y())
                    {
                        throw new RoverOutOfBoundsException();
                    }
                    _cur_pos.IncY();

                    return;
                case Direction.South:
                    if (_cur_pos.Y() <= 0)
                    {
                        throw new RoverOutOfBoundsException();
                    }
                    _cur_pos.DecY();

                    return;
                case Direction.East:
                    if (_cur_pos.X() >= _grid_ext.X())
                    {
                        throw new RoverOutOfBoundsException();
                    }
                    _cur_pos.IncX();

                    return;
                case Direction.West:
                    if (_cur_pos.X() <= 0)
                    {
                        throw new RoverOutOfBoundsException();
                    }
                    _cur_pos.DecX();

                    return;
            }
        }

        public void TurnLeft()
        {
            _dir_sm.TurnLeft();

        }

        public void TurnRight()
        {
            _dir_sm.TurnRight();

        }

        override public String ToString()
        {
            return _cur_pos.ToString() + " " + _dir_sm.ToString();
        }

        public class RoverOutOfBoundsException : System.Exception
        {
            public RoverOutOfBoundsException() { }
        }
    }
}
