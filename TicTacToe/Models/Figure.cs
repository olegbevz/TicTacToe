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

        public void Hide(IGraphics graphics, DrawingContext context)
        {
            // Начальные координаты
            var startX = context.Distance + 1 + context.CellSize * (X - 1);
            var startY = context.Distance + 1 + context.CellSize * (Y - 1);
            var endX = startX + context.CellSize - context.Distance;
            var endY = startY + context.CellSize - context.Distance;

            // Конечные координаты
            for (var i = 0; i <= (context.CellSize - 2); i++)
                graphics.DrawLine(new MonoPen(Color.White, 1), startX, startY + i, endX, startY + i);
        }
    }
}