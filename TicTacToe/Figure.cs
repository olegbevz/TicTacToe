namespace GamePanelApplication
{
    public class Figure
    {
        public Figure(int x, int y) : this(new Point(x, y))
        {
        }

        public Figure(Point position)
        {
            this.Position = position;
        }

        public Point Position { get; private set; }

        public int X
        {
            get
            {
                return this.Position.X;
            }
        }

        public int Y
        {
            get
            {
                return this.Position.Y;
            }
        }

        public int _value;
    }
}