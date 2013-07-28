namespace TicTacToe
{
    using TicTacToe.Interfaces;

    public class Grid : IDrawable
    {
        public void Draw(IGraphics graphics, DrawingContext context)
        {
            this.DrawHorizontalLines(graphics, context, Color.Black);

            this.DrawVerticalLines(graphics, context, Color.Black);
        }

        public void Hide(IGraphics graphics, DrawingContext context)
        {
            this.DrawHorizontalLines(graphics, context, Color.White);

            this.DrawVerticalLines(graphics, context, Color.White);
        }

        private void DrawHorizontalLines(IGraphics graphics, DrawingContext context, Color color)
        {
            var startPoint = Figure.CalculatePixelPoint(new Point(1, 1), context);

            for (var y = 0; y < context.Rows; y++)
            {
                graphics.DrawLine(
                    new MonoPen(color, 1),
                    0,
                    startPoint.Y + y * context.CellSize,
                    context.Width - 2 * context.Distance - 1,
                    startPoint.Y + y * context.CellSize);
            }

            graphics.DrawLine(
                new MonoPen(color, 1),
                context.Distance,
                context.Height - context.Distance,
                context.Width - 2 * context.Distance - 1,
                context.Height - context.Distance);
        }

        private void DrawVerticalLines(IGraphics graphics, DrawingContext context, Color color)
        {
            var startPoint = Figure.CalculatePixelPoint(new Point(1, 1), context);

            for (var x = 0; x <= context.Columns; x++)
            {
                graphics.DrawLine(
                    new MonoPen(color, 1),
                    startPoint.X + x * context.CellSize,
                    context.Distance,
                    startPoint.X + x * context.CellSize,
                    context.Height - 2 * context.Distance - 1);
            }

            graphics.DrawLine(
                new MonoPen(color, 1),
                context.Width - context.Distance,
                context.Distance,
                context.Width - context.Distance,
                context.Height - 2 * context.Distance - 1);
        }
    }
}