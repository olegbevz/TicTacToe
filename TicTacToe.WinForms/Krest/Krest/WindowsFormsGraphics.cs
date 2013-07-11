// -----------------------------------------------------------------------
// <copyright file="WindowsFormsGraphics.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace GamePanelApplication
{
    using System;
    using System.Drawing;

    using TicTacToe.Interfaces;

    using Color = TicTacToe.Interfaces.Color;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class WinFormsGraphics : IGraphics
    {
        private Graphics graphics;

        public WinFormsGraphics(Graphics graphics)
        {
            

            this.graphics = graphics;
        }

        public void DrawEllipse(MonoPen monoPen, int x, int y, int width, int height)
        {
            using (var pen = this.GetPen(monoPen))
            {
                //graphics.DrawCurve();

                graphics.DrawEllipse(pen, x, y, width, height);
            }
        }

        public void DrawLine(MonoPen monoPen, int x1, int y1, int x2, int y2)
        {
            using (var pen = this.GetPen(monoPen))
            {
                graphics.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        public void DrawRectangle(MonoPen monoPen, int x, int y, int width, int height)
        {
            using (var pen = this.GetPen(monoPen))
            {
                graphics.DrawRectangle(pen, x, y, width, height);
            }
        }

        public System.Drawing.Color GetColor(Color color)
        {
            switch (color)
            {
                case Color.Black:
                    return System.Drawing.Color.Black;
                case Color.Red:
                    return System.Drawing.Color.Red;
                case Color.White:
                    return System.Drawing.Color.White;
                case Color.Blue:
                    return System.Drawing.Color.Blue;
                case Color.Gray:
                    return System.Drawing.Color.LightGray;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public System.Drawing.Pen GetPen(MonoPen pen)
        {
            return new System.Drawing.Pen(this.GetColor(pen.Color), pen.Width);
        }
    }
}
