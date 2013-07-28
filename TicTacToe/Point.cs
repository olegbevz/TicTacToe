// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Point.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Point type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TicTacToe
{
    public class Point
    {
        public Point()
            : this(0, 0)
        {
            
        }

        public Point(int x, int y)
        {
            X = x;

            Y = y;
        }

        public int X { get; private set; }

        public int Y { get; private set;}

        public void Shift(int x, int y)
        {
            X += x;

            Y += y;
        }

        public void Set(int x, int y)
        {
            X = x;

            Y = y;
        }

        public void Set(Point point)
        {
            Set(point.X, point.Y);
        }

        public override bool Equals(object obj)
        {   
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var point = obj as Point;

            if (point != null)
            {
                return point.X == X && point.Y == Y;
            }

            return false;
        }
    }

    public class FloatPoint
    {
        public FloatPoint()
            : this(0, 0)
        {
        }

        public FloatPoint(double x, double y)
        {
            X = x;

            Y = y;
        }

        public double X { get; private set; }

        public double Y { get; private set; } 
    }
}
