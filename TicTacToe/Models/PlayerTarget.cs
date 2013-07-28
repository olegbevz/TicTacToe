namespace TicTacToe
{
    using System;

    using TicTacToe.Interfaces;

    public class PlayerTarget : Figure
    {
        public PlayerTarget(int x, int y, FigureType type)
            : base(x, y)
        {
            this.Type = type;
        }

        public PlayerTarget(Point position, FigureType type)
            : base(position)
        {
            this.Type = type;
        }

        public override void Draw(IGraphics graphics, DrawingContext context)
        {
            var borderOffset = context.CellSize / 5;

            // Начальные координаты
            var startPoint = CalculatePixelPoint(this.Position, context);
            startPoint.Shift(borderOffset, borderOffset);

            // Конечные координаты
            var endPoint = CalculatePixelPoint(new Point(this.Position.X + 1, this.Position.Y + 1), context);
            endPoint.Shift(-borderOffset, -borderOffset);

            var color = Color.White;

            switch (this.Type)
            {
                case FigureType.X:
                    color = Color.Blue;
                    break;
                case FigureType.O:
                    color = Color.Red;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            using (MonoPen pen = new MonoPen(color, borderOffset))
                graphics.DrawRectangle(
                    pen, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
        }
    }
}