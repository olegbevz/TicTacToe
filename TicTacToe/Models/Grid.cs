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
            var startPoint = new Point(0, 0);

            for (var y = 0; y < context.Rows; y++)
            {
                graphics.DrawLine(
                    new MonoPen(color, 1),
                    0,
                    startPoint.Y + ((y + 1) * context.CellSize),
                    context.Width,
                    startPoint.Y + ((y + 1) * context.CellSize));
            }
        }

        private void DrawVerticalLines(IGraphics graphics, DrawingContext context, Color color)
        {
            var startPoint = new Point(0, 0);

            for (var x = 0; x <= context.Columns; x++)
            {
                graphics.DrawLine(
                    new MonoPen(color, 1),
                    startPoint.X + ((x + 1) * context.CellSize),
                    0,
                    startPoint.X + ((x + 1) * context.CellSize),
                    context.Height);
            }
        }
    }
}