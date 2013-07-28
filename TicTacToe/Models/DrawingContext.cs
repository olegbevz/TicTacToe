namespace TicTacToe
{
    public class DrawingContext
    {
        public Point Origin { get; set; }

        public int CellSize { get; set; }

        public int Distance { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Rows { get; set; }

        public int Columns { get; set; }

        public readonly int ShadowShift = 3;
    }
}