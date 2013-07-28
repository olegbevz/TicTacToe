namespace TicTacToe
{
    using TicTacToe.Interfaces;

    public class Tic : Figure
    {
        public Tic(int x, int y)
            : base(x, y)
        {
            this.Type = FigureType.X;
        }

        public Tic(Point position)
            : base(position)
        {
            this.Type = FigureType.X;
        }

        public override void Draw(IGraphics graphics, DrawingContext context)
        {
            Draw(graphics, context, Color.Red, Color.Gray);
        }

        public override void Hide(IGraphics graphics, DrawingContext context)
        {
            Draw(graphics, context, Color.White, Color.White);
        }

        private void Draw(IGraphics graphics, DrawingContext context, Color color, Color shadowColor)
        {
            var borderOffset = context.CellSize / 5;

            // Начальные координаты
            var startPoint = CalculatePixelPoint(this.Position, context);
            startPoint.Shift(borderOffset, borderOffset);

            // Конечные координаты
            var endPoint = CalculatePixelPoint(new Point(this.Position.X + 1, this.Position.Y + 1), context);
            endPoint.Shift(-borderOffset, -borderOffset);

            var thikness = context.CellSize / 8;

            using (var pen = new MonoPen(shadowColor, thikness))
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

            using (var pen = new MonoPen(color, thikness))
            {
                graphics.DrawLine(pen, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);

                graphics.DrawLine(pen, startPoint.X, endPoint.Y, endPoint.X, startPoint.Y);
            }
        }
    }
}