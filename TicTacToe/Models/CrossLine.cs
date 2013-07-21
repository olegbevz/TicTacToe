namespace TicTacToe
{
    using TicTacToe.Interfaces;

    public class CrossLine : IDrawable
    {
        //Использовать линию зачеркивания или нет
        public bool bUseLine;
        //Координаты линии
        private int _x1, _y1, _x2, _y2;

        public CrossLine(IGraphics e)
        {
            this.bUseLine = false;
        }

        //Установить координаты линии
        public void SetXY(int x1, int y1, int x2, int y2)
        {
            this._x1 = x1;
            this._y1 = y1;
            this._x2 = x2;
            this._y2 = y2;
            this.bUseLine = true;
        }

        //Переместить линию
        public void Move(int dx,int dy)
        {
            this._x1 = this._x1 - dx;
            this._y1 = this._y1 - dy;
            this._x2 = this._x2 - dx;
            this._y2 = this._y2 - dy;
        }

        public void Draw(IGraphics graphics, DrawingContext context)
        {
            using (var pen = new MonoPen(Color.Black, 4))
            {
                var startX = context.Distance + context.CellSize * (this._x1 - 1) + context.CellSize / 2;
                var startY = context.Distance + context.CellSize * (this._y1 - 1) + context.CellSize / 2;
                var endX = context.Distance + context.CellSize * (this._x2 - 1) + context.CellSize / 2;
                var endY = context.Distance + context.CellSize * (this._y2 - 1) + context.CellSize / 2;
                //graph.DrawLine(pen, startX, startY, endX, endY);
                graphics.DrawLine(pen, startX - context.CellSize / 6, startY - context.CellSize / 6, endX + context.CellSize / 6, endY + context.CellSize / 6);
                graphics.DrawLine(pen, startX + context.CellSize / 6, startY + context.CellSize / 6, endX - context.CellSize / 6, endY - context.CellSize / 6);
            }
        }

        public void Hide(IGraphics graphics, DrawingContext context)
        {
            using (var pen = new MonoPen(Color.White, 4))
            {
                var startX = context.Distance + context.CellSize * (this._x1 - 1) + context.CellSize / 2;
                var startY = context.Distance + context.CellSize * (this._y1 - 1) + context.CellSize / 2;
                var endX = context.Distance + context.CellSize * (this._x2 - 1) + context.CellSize / 2;
                var endY = context.Distance + context.CellSize * (this._y2 - 1) + context.CellSize / 2;
                //graph.DrawLine(pen, startX, startY, endX, endY);
                graphics.DrawLine(pen, startX - context.CellSize / 6, startY - context.CellSize / 6, endX + context.CellSize / 6, endY + context.CellSize / 6);
                graphics.DrawLine(pen, startX + context.CellSize / 6, startY + context.CellSize / 6, endX - context.CellSize / 6, endY - context.CellSize / 6);
            }
        }
    }
}