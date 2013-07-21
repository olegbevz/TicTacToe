namespace TicTacToe
{
    using GamePanelApplication;

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
            // Начальные координаты
            var startX = 5 * context.Distance + context.CellSize * (this.X - 1);
            var startY = 5 * context.Distance + context.CellSize * (this.Y - 1);

            // Конечные координаты
            var endX = startX + context.CellSize - 8 * context.Distance;
            var endY = startY + context.CellSize - 8 * context.Distance;

            using (var pen = new MonoPen(Color.Gray, 8))
            {
                graphics.DrawLine(pen, startX - context.ShadowShift, startY + context.ShadowShift, endX - context.ShadowShift, endY + context.ShadowShift);
                graphics.DrawLine(pen, startX - context.ShadowShift, endY + context.ShadowShift, endX - context.ShadowShift, startY + context.ShadowShift);
            }

            using (var pen = new MonoPen(Color.Red, 8))
            {
                graphics.DrawLine(pen, startX, startY, endX, endY);
                graphics.DrawLine(pen, startX, endY, endX, startY);
            }
        }
    }
}