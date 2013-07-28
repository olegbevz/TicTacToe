namespace TicTacToe
{
    using System;

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

        public static Point CalculatePixelPoint(Point point, DrawingContext context)
        {
            var x = context.Distance + (context.CellSize * (point.X - context.Origin.X - 1));
            var y = context.Distance + (context.CellSize * (point.Y - context.Origin.Y - 1));

            return new Point((int)x, (int)y);
        }

        public abstract void Draw(IGraphics graphics, DrawingContext context);

        public void Hide(IGraphics graphics, DrawingContext context)
        {
            // Начальные координаты
            var startPixelPoint = CalculatePixelPoint(Position, context);
            startPixelPoint.Shift(0, context.CellSize / 2);
            var endPoint = CalculatePixelPoint(new Point(Position.X + 1, Position.Y), context);
            startPixelPoint.Shift(0, context.CellSize / 2);

            // Конечные координаты
            //for (var i = 0; i <= (context.CellSize - 2); i++)
                graphics.DrawLine(
                    new MonoPen(Color.White, context.CellSize), 
                    startPixelPoint.X, 
                    startPixelPoint.Y, 
                    endPoint.X, 
                    endPoint.Y);
        }
    }
}