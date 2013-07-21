namespace TicTacToe
{
    using TicTacToe.Interfaces;

    public class Grid : IDrawable
    {
        public void Draw(IGraphics graphics, DrawingContext context)
        {
            this.DrawHorizontalLines(graphics, context);

            this.DrawVerticalLines(graphics, context);
        }

        public void Hide(IGraphics graphics, DrawingContext context)
        {
            throw new System.NotImplementedException();
        }

        private void DrawHorizontalLines(IGraphics graphics, DrawingContext context)
        {
            for (var y = 0; y < context.Rows; y++)
            {
                graphics.DrawLine(
                    new MonoPen(Color.Black, 1),
                    context.Distance,
                    context.Distance + y * context.CellSize,
                    context.Width - 2 * context.Distance - 1,
                    context.Distance + y * context.CellSize);
            }

            graphics.DrawLine(
                new MonoPen(Color.Black, 1),
                context.Distance,
                context.Height - context.Distance,
                context.Width - 2 * context.Distance - 1,
                context.Height - context.Distance);
        }

        private void DrawVerticalLines(IGraphics graphics, DrawingContext context)
        {
            for (var x = 0; x <= context.Columns; x++)
            {
                graphics.DrawLine(
                    new MonoPen(Color.Black, 1),
                    context.Distance + x * context.CellSize,
                    context.Distance,
                    context.Distance + x * context.CellSize,
                    context.Height - 2 * context.Distance - 1);
            }

            graphics.DrawLine(
                new MonoPen(Color.Black, 1),
                context.Width - context.Distance,
                context.Distance,
                context.Width - context.Distance,
                context.Height - 2 * context.Distance - 1);
        }
    }
}