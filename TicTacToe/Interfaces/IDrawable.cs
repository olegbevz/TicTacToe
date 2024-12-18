// -----------------------------------------------------------------------
// <copyright file="IGraphics.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace TicTacToe.Interfaces
{
    public interface IDrawable
    {
        void Draw(IGraphics graphics, DrawingContext context);

        void Hide(IGraphics graphics, DrawingContext context);
    }
}
