namespace TicTacToe
{
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;

            Y = y;
        }

        public int X { get; private set; }

        public int Y { get; private set;}
    }

    public class FloatPoint
    {
        public FloatPoint(double x, double y)
        {
            X = x;

            Y = y;
        }

        public double X { get; private set; }

        public double Y { get; private set; } 
    }
}
