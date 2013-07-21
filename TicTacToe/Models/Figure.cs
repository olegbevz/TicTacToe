namespace TicTacToe
{
    using GamePanelApplication;

    using TicTacToe.Interfaces;

    public abstract class Figure : IDrawable
    {
        protected Figure(int x, int y) : this(new Point(x, y))
        {
        }

        protected Figure(Point position)
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

        public FigureType Type { get; protected set; } 

        public abstract void Draw(IGraphics graphics, DrawingContext context);
    }
}