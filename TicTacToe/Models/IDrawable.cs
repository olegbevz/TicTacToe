namespace TicTacToe
{
    using TicTacToe.Interfaces;

    public interface IDrawable
    {
        void Draw(IGraphics graphics, DrawingContext context);
    }
}