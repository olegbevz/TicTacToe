using ItemsApplication;

namespace GamePanelApplication
{
    using TicTacToe.Interfaces;

    public class Player
    {
        //Ширина ячейки и отступ от краев поля
        const int cellWidth = 32, dist = 2;
        IGraphics _graph;
        //Использовать цели или нет
        public bool _bUseTarget;
        //Координаты последнего хода
        public int _x;
        public int _y;
        //Фишка игрока
        private FigureType _value;
        //Очки игрока
        public int _score;
        public Player(FigureType Value, IGraphics e)
        {
            //Присваивание начальных параметров
            _x = 0;
            _y = 0;
            _value = Value;
            _score = 0;
            _bUseTarget = true;
            _graph = e;
            //graph = form1.panel2.CreateGraphics(); 
        }
        /// <summary>
        /// Установка координат цели
        /// </summary>
        public void SetTargetXY(int x, int y)
        {
            _x = x;
            _y = y;
        }
        //Переместить указатель
        public void MoveTargetXY(int dx, int dy)
        {
            _x = _x + dx;
            _y = _y + dy;
        }
        //Установить указатель
        public void SetTarget(int X,int Y)
        {
            HideTarget();
            SetTargetXY(X, Y);
            DrawTarget();
        }
        //Добавить очки
        public void AddScore(int Score)
        {
            _score = _score + Score;
        }
        //Нарисовать указатель
        public void DrawTarget()
        {
            //if (!_bUseTarget) return;
            _bUseTarget = true;
            //Начальные координаты
            int startX = 2 * dist + cellWidth * (_x - 1);
            int startY = 2 * dist + cellWidth * (_y - 1);
            //Конечные координаты
            int endX = 2 * dist + cellWidth * _x - 1;
            int endY = 2 * dist + cellWidth * _y - 1;

            if (_value == FigureType.X)
                using (MonoPen pen = new MonoPen(Color.Blue, 3))
                    _graph.DrawRectangle(pen, startX, startY, cellWidth - 2 * dist, cellWidth - 2 * dist);
            if (_value == FigureType.O)
                using (MonoPen pen = new MonoPen(Color.Red, 3))
                    _graph.DrawRectangle(pen, startX, startY, cellWidth - 2 * dist, cellWidth - 2 * dist);
        }
        //Спрятать указатель
        public void HideTarget()
        {
            if (!_bUseTarget) return;
            using (MonoPen pen = new MonoPen(Color.White, 3))
            {
                //Начальные координаты
                int startX = 2 * dist + cellWidth * (_x - 1);
                int startY = 2 * dist + cellWidth * (_y - 1);
                //Конечные координаты
                int endX = 2 * dist + cellWidth * _x - 1;
                int endY = 2 * dist + cellWidth * _y - 1;
                _graph.DrawRectangle(pen, startX, startY, cellWidth - 2 * dist, cellWidth - 2 * dist);
            }
        }
    }
}
