namespace BattleGround
{
    using TicTacToe.Interfaces;

    public class Line
    {
        //Ширина ячейки и отступ от краев поля
        public int cellSize = 32, dist = 2;
        //Использовать линию зачеркивания или нет
        public bool bUseLine;
        //Координаты линии
        private int _x1, _y1, _x2, _y2;
        private IGraphics _e;

        public Line(IGraphics e)
        {
            this._e = e;
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
        //Нарисовать линию
        public void DrawLine()
        {
            using (MonoPen pen = new MonoPen(Color.Black, 4))
            {
                int startX = dist + cellSize * (this._x1 - 1) + cellSize / 2;
                int startY = dist + cellSize * (this._y1 - 1) + cellSize / 2;
                int endX = dist + cellSize * (this._x2 - 1) + cellSize / 2;
                int endY = dist + cellSize * (this._y2 - 1) + cellSize / 2;
                //graph.DrawLine(pen, startX, startY, endX, endY);
                this._e.DrawLine(pen, startX - cellSize / 6, startY - cellSize / 6, endX + cellSize / 6, endY + cellSize / 6);
                this._e.DrawLine(pen, startX + cellSize / 6, startY + cellSize / 6, endX - cellSize / 6, endY - cellSize / 6);
            }
        }
        //Спрятать линию
        public void HideLine()
        {
            
            using (MonoPen pen = new MonoPen(Color.White, 4))
            {

                int startX = dist + cellSize * (this._x1 - 1) + cellSize / 2;
                int startY = dist + cellSize * (this._y1 - 1) + cellSize / 2;
                int endX = dist + cellSize * (this._x2 - 1) + cellSize / 2;
                int endY = dist + cellSize * (this._y2 - 1) + cellSize / 2;
                //graph.DrawLine(pen, startX, startY, endX, endY);
                this._e.DrawLine(pen, startX - cellSize / 6, startY - cellSize / 6, endX + cellSize / 6, endY + cellSize / 6);
                this._e.DrawLine(pen, startX + cellSize / 6, startY + cellSize / 6, endX - cellSize / 6, endY - cellSize / 6);
            }
        }
        //Переместить линию
        public void MoveLineXY(int dx,int dy)
        {
            
            this._x1 = this._x1 - dx;
            this._y1 = this._y1 - dy;
            this._x2 = this._x2 - dx;
            this._y2 = this._y2 - dy;
            
        }
    }
}