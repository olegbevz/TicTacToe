// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Zero.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Zero type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TicTacToe
{
    using TicTacToe.Interfaces;

    public class Tac : Figure
    {
        public Tac(int x, int y)
            : base(x, y)
        {
            this.Type = FigureType.O;
        }

        public Tac(Point position)
            : base(position)
        {
            this.Type = FigureType.O;
        }

        public override void Draw(IGraphics graphics, DrawingContext context)
        {
            this.Draw(graphics, context, Color.Blue, Color.Gray);
        }

        public override void Hide(IGraphics graphics, DrawingContext context)
        {
            this.Draw(graphics, context, Color.White, Color.White);
        }

        private void Draw(IGraphics graphics, DrawingContext context, Color color, Color shadowColor)
        {
            // Центр круга
            var radius = context.CellSize / 2;
            var diameter = radius / 2;

            var startPoint = CalculatePixelPoint(this.Position, context);

            var pixelCenter = new Point(startPoint.X + diameter, startPoint.Y + diameter);

            var widthOffset = (int)(radius * 0.1);

            var thikness = context.CellSize / 8;

            using (var pen = new MonoPen(shadowColor, thikness))
            {
                graphics.DrawEllipse(
                    pen,
                    pixelCenter.X - context.ShadowShift + widthOffset,
                    pixelCenter.Y + context.ShadowShift,
                    radius - (widthOffset * 2),
                    radius);
            }

            using (var pen = new MonoPen(color, thikness))
            {
                graphics.DrawEllipse(pen, pixelCenter.X + widthOffset, pixelCenter.Y, radius - (widthOffset * 2), radius);
            }
        }
    }
}