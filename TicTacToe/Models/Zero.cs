namespace TicTacToe
{
    using GamePanelApplication;

    using TicTacToe.Interfaces;

    public class Zero : Figure
    {
        public Zero(int x, int y)
            : base(x, y)
        {
            this.Type = FigureType.O;
        }

        public Zero(Point position)
            : base(position)
        {
            this.Type = FigureType.O;
        }

        public override void Draw(IGraphics graphics, DrawingContext context)
        {
            // Центр круга
            var rad = context.CellSize / 2;
            var centX = rad / 2 + context.Distance + context.CellSize * (this.X - 1);
            var centY = rad / 2 + context.Distance + context.CellSize * (this.Y - 1);

            var widthOffset = (int)(rad * 0.1);

            using (var pen = new MonoPen(Color.Gray, 8))
            {
                graphics.DrawEllipse(pen, centX - context.ShadowShift + widthOffset, centY + context.ShadowShift, rad - (widthOffset * 2), rad);
            }

            using (var pen = new MonoPen(Color.Blue, 8))
            {
                graphics.DrawEllipse(pen, centX + widthOffset, centY, rad - (widthOffset * 2), rad);
            }
        }
    }
}