using System;
namespace mars
{
    public struct Point
    {
        //private by default 
        int _x;
        int _y;

        public Point(int x, int y)
        {

            _x = x;
            _y = y; 

        }

        public int X()
        {
            return _x;
        }

        public int Y()
        {
            return _y;
        }

        public void IncX()
        {
            _x++;
        }

        public void IncY()
        {
            _y++;
        }

        public void DecX()
        {
            _x--;
        }

        public void DecY()
        {
            _y--;
        }

        override public String ToString() 
        {
            return _x.ToString() + " " + _y.ToString();
        }

    }
}
