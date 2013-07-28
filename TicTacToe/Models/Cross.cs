namespace TicTacToe
{
    using TicTacToe.Interfaces;

    public class Cross : Figure
    {
        public Cross(int x, int y)
            : base(x, y)
        {
            this.Type = FigureType.X;
        }

        public Cross(Point position)
            : base(position)
        {
            this.Type = FigureType.X;
        }

        public override void Draw(IGraphics graphics, DrawingContext context)
        {
            var borderOffset = context.CellSize / 5;

            // Начальные координаты
            var startPoint = CalculatePixelPoint(Position, context);
            startPoint.Shift(borderOffset, borderOffset);

            // Конечные координаты
            var endPoint = CalculatePixelPoint(new Point(Position.X + 1, Position.Y + 1), context);
            endPoint.Shift(-borderOffset, -borderOffset);

            var thikness = context.CellSize / 8;

            using (var pen = new MonoPen(Color.Gray, thikness))
            {
                graphics.DrawLine(
                    pen, 
                    startPoint.X - context.ShadowShift, 
                    startPoint.Y + context.ShadowShift, 
                    endPoint.X - context.ShadowShift,
                    endPoint.Y + context.ShadowShift);
                
                graphics.DrawLine(
                    pen, 
                    startPoint.X - context.ShadowShift,
                    endPoint.Y + context.ShadowShift,
                    endPoint.X - context.ShadowShift, 
                    startPoint.Y + context.ShadowShift);
            }

            using (var pen = new MonoPen(Color.Red, thikness))
            {
                graphics.DrawLine(
                    pen, 
                    startPoint.X, 
                    startPoint.Y,
                    endPoint.X,
                    endPoint.Y);

                graphics.DrawLine(
                    pen, 
                    startPoint.X,
                    endPoint.Y,
                    endPoint.X, 
                    startPoint.Y);
            }
        }
    }
}