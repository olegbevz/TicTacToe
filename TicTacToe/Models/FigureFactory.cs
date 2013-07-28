namespace TicTacToe
{
    using System;

    public static class FigureFactory
    {
        public static Figure Create(int x, int y, int type)
        {
            return Create(x, y, (FigureType)type);
        }

        public static Figure Create(int x, int y, FigureType type)
        {
            switch (type)
            {
                case FigureType.X:
                    return new Tic(x, y);
                case FigureType.O:
                    return new Tac(x, y);
                default:
                    throw new ArgumentOutOfRangeException("type");
            }
        }
    }
}