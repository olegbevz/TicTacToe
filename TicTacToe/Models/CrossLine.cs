// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CrossLine.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the CrossLine type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TicTacToe
{
    using TicTacToe.Interfaces;

    public class CrossLine : IDrawable
    {
        public CrossLine(int x1, int y1, int x2, int y2)
            : this(new Point(x1, y1), new Point(x2, y2))
        {
        }

        public CrossLine(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;

            EndPoint = endPoint;
        }

        /// <summary>
        /// Gets the start point.
        /// Начальная точка
        /// </summary>
        public Point StartPoint { get; private set; }

        /// <summary>
        /// Gets the end point.
        /// Конечная точка
        /// </summary>
        public Point EndPoint { get; private set; }
        
        public void Draw(IGraphics graphics, DrawingContext context)
        {
            Draw(graphics, context, Color.Black);
        }

        public void DrawShadow(IGraphics graphics, DrawingContext context)
        {
            DrawShadow(graphics, context, Color.Gray);
        }

        public void DrawShadow(IGraphics graphics, DrawingContext context, Color color)
        {
            var thikness = context.CellSize / 8;

            using (var pen = new MonoPen(color, thikness))
            {
                var pixelStartPoint = this.CalculatePixelStartPoint(context);
                pixelStartPoint.Shift(-context.ShadowShift, context.ShadowShift);

                var pixelEndPoint = this.CalculatePixelEndPoint(context);
                pixelEndPoint.Shift(-context.ShadowShift, context.ShadowShift);

                // graph.DrawLine(pen, startX, startY, endX, endY);
                graphics.DrawLine(pen, pixelStartPoint.X, pixelStartPoint.Y, pixelEndPoint.X, pixelEndPoint.Y);
            }
        }

        private void Draw(IGraphics graphics, DrawingContext context, Color color)
        {
            var thikness = context.CellSize / 8;

            using (var pen = new MonoPen(color, thikness))
            {
                var pixelStartPoint = this.CalculatePixelStartPoint(context);

                var pixelEndPoint = this.CalculatePixelEndPoint(context);

                // graph.DrawLine(pen, startX, startY, endX, endY);
                graphics.DrawLine(pen, pixelStartPoint.X, pixelStartPoint.Y, pixelEndPoint.X, pixelEndPoint.Y);
            }
        }

        public void Hide(IGraphics graphics, DrawingContext context)
        {
            Draw(graphics, context, Color.White);

            DrawShadow(graphics, context, Color.White);
        }

        public Point CalculatePixelStartPoint(DrawingContext context)
        {
            var startX = context.CellSize * (StartPoint.X - context.Origin.X - 1) + context.CellSize / 2;
            var startY = context.CellSize * (StartPoint.Y - context.Origin.Y - 1) + context.CellSize / 2;
               
            return new Point((int)startX, (int)startY);
        }

        public Point CalculatePixelEndPoint(DrawingContext context)
        {
            var endX = context.CellSize * (EndPoint.X - context.Origin.X - 1) + context.CellSize / 2;
            var endY = context.CellSize * (EndPoint.Y - context.Origin.Y - 1) + context.CellSize / 2;

            return new Point((int)endX, (int)endY);
        }
    }
}