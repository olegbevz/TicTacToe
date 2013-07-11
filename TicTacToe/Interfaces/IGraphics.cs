// -----------------------------------------------------------------------
// <copyright file="IGraphics.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace TicTacToe.Interfaces
{
    using System;

    public enum Color
    {
        Black,

        Red,

        White,

        Blue,

        Gray
    }

    public class MonoPen : IDisposable
    {
        public MonoPen(Color color, int width)
        {
            Color = color;

            Width = width;
        }

        public Color Color { get; set; }

        public float Width { get; set; }

        public void Dispose()
        {
            
        }
    }

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface IGraphics
    {
        void DrawEllipse(MonoPen pen, int x, int y, int width, int height);

        void DrawLine(MonoPen pen, int x1, int y1, int x2, int y2);

        void DrawRectangle(MonoPen pen, int x, int y, int width, int height);
    }
}
