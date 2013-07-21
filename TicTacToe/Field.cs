namespace TicTacToe 
{
    using System;

    using TicTacToe.Interfaces;

    public class Field
    {
        //Ширина ячейки и отступ от краев поля
        public int cellSize = 32;
        public int dist = 3;
        //Координаты текущего положения матрицы просмотра
        public int _leftCell;
        public int _lowCell;
        //Размеры поля в пикселах
        private int _width;
        private int height;
        //Список ячеек
        public FigureSequence Figures = new FigureSequence();
        public IGraphics _e;
        //Зачеркивающая линия
        public CrossLine _line;

        public int Columns
        {
            get
            {
                return this._width / this.cellSize;
            }
        }

        public int Rows
        {
            get
            {
                return this.height / this.cellSize;
            }
        }

        public Field(IGraphics e, int width, int height)
        {
            this._e = e;
            this._leftCell = 0;
            this._lowCell = 0;
            this._line = new CrossLine(this._e);
            this._width = width;
            this.height = height;
            //this.Left = 76;
            //this.Top = 14;
            //this.Width = 423;
            //this.Height = 423;
            //this.BackColor = Color.White;
            //this.Visible = true;
            //form1.Controls.Add(this);
        }

        public void HitPosition(int positionX, int positionY, out int x, out int y)
        {
            x = 1 + (positionX - 2 * this.dist) / this.cellSize;
            y = 1 + (positionY - 2 * this.dist) / this.cellSize;
        }

        public void SetFieldWidth(int Width)
        {
            this._width = Width;
        }
        //Конвертирование координат на матрице просмотра в мировые координаты
        private int ConvertXToWorld(int X)
        {
            return (X + this._leftCell);
        }
        private int ConvertYToWorld(int Y)
        {
            return (Y + this._lowCell);
        }

        /// <summary>
        /// Нарисовать поле
        /// </summary>
        public void Draw()
        {
            // Рисуем решетку
            this.DrawVerticalLines();

            this.DrawHorizontalLines();

            var context = new DrawingContext { CellSize = cellSize, Distance = dist };

            this.Figures.Draw(_e, context);

            //Вывод линии
            if (_line.bUseLine)
            {
                _line.Draw(_e, context);
            }
        }

        private void DrawHorizontalLines()
        {
            for (var y = 0; y < this.Rows; y++)
            {
                this._e.DrawLine(
                    new MonoPen(Color.Black, 1), 
                    this.dist, 
                    this.dist + y * this.cellSize, 
                    this._width - 2 * this.dist - 1, 
                    this.dist + y * this.cellSize);
            }

            this._e.DrawLine(
                new MonoPen(Color.Black, 1), 
                this.dist, 
                this.height - this.dist, 
                this._width - 2 * this.dist - 1, 
                this.height - this.dist);
        }

        private void DrawVerticalLines()
        {
            for (var x = 0; x <= this.Columns; x++)
            {
                this._e.DrawLine(
                    new MonoPen(Color.Black, 1), 
                    this.dist + x * this.cellSize, 
                    this.dist, 
                    this.dist + x * this.cellSize, 
                    this.height - 2 * this.dist - 1);
            }

            this._e.DrawLine(
                new MonoPen(Color.Black, 1), 
                this._width - this.dist, 
                this.dist, 
                this._width - this.dist, 
                this.height - 2 * this.dist - 1);
        }

        /// <summary>
        /// Очистка поля
        /// </summary>
        public void Clear()
        {
            for (var x = 1; x <= this.Columns; x++)
                for (var y = 1; y <= this.Rows; y++)
                {
                    //Если ячейка занята очистить её
                    if (this.Figures.GetFigureType(this.ConvertXToWorld(x), this.ConvertYToWorld(y)) != FigureType.Empty) 
                        this.ClearItem(x, y);
                }
            //Спрятать линию
            var context = new DrawingContext { CellSize = cellSize, Distance = dist };

            if (this._line.bUseLine)
                this._line.HideLine(_e, context);
        }

        /// <summary>
        /// Проверка ячейки
        /// </summary>
        /// <param name="x">Координаты ячейки</param>
        /// <param name="y"></param>
        /// <param name="value">Значение ячейки</param>
        /// <returns></returns>
        public string TrySetFigure(int x, int y, int value)
        {
            try
            {
                Figures.SetFigure(this.ConvertXToWorld(x), this.ConvertYToWorld(y), value);

                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }     

        //Очистить клетку
        public void ClearItem(int x, int y)
        {
            //x = x - leftCell;
            //y = y - highCell;
            //Начальные координаты
            int startX = this.dist + 1 + this.cellSize * (x - 1);
            int startY = this.dist + 1 + this.cellSize * (y - 1);
            int endX = startX + this.cellSize - this.dist;
            int endY = startY + this.cellSize - this.dist;
            //Конечные координаты

            for (int i = 0; i <= (this.cellSize - 2); i++)
                this._e.DrawLine(new MonoPen(Color.White, 1), startX, startY + i, endX, startY + i);
        }

        /// <summary>
        /// Проверить поле на выигрышную ситуацию
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="gameRule">Правила игры</param>
        /// <returns></returns>
        public int Check(int x, int y, int gameRule)
        {
            var value = this.Figures.GetFigureType(this.ConvertXToWorld(x), this.ConvertYToWorld(y));
           
            if (this.Figures.Check(this.ConvertXToWorld(x),this.ConvertYToWorld(y), value) == 1)
            {
                if (gameRule == 2) return 0;
                int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
                //Если в ряд по горизонтали составлено более 5 фишек
                if (this.Figures.dir.Hdir1 + this.Figures.dir.Hdir2 + 1 >= 5)
                {
                    x1 = x + this.Figures.dir.Hdir1;
                    x2 = x - this.Figures.dir.Hdir2;
                    y1 = y; y2 = y;
                }
                //Если в ряд по вертикали составлено более 5 фишек
                if (this.Figures.dir.Vdir1 + this.Figures.dir.Vdir2 + 1 >= 5)
                {
                    y1 = y + this.Figures.dir.Vdir1;
                    y2 = y - this.Figures.dir.Vdir2;
                    x1 = x; x2 = x;
                }
                //Если в ряд по дигонали составлено более 5 фишек
                if (this.Figures.dir.Ddir1 + this.Figures.dir.Ddir2 + 1 >= 5)
                {

                    x1 = x + this.Figures.dir.Ddir1;
                    y1 = y + this.Figures.dir.Ddir1;
                    x2 = x - this.Figures.dir.Ddir2;
                    y2 = y - this.Figures.dir.Ddir2;
                    //MessageBox.Show("1.2(" + Convert.ToString(x1) + "," + Convert.ToString(y1) + ")-(" + Convert.ToString(x2) + "," + Convert.ToString(y2) + ")");

                }
                if (this.Figures.dir.Ddir3 + this.Figures.dir.Ddir4 + 1 >= 5)
                {

                    x1 = x - this.Figures.dir.Ddir3;
                    y1 = y + this.Figures.dir.Ddir3;
                    x2 = x + this.Figures.dir.Ddir4;
                    y2 = y - this.Figures.dir.Ddir4;
                    //MessageBox.Show("1.3(" + Convert.ToString(x1) + "," + Convert.ToString(y1) + ")-(" + Convert.ToString(x2) + "," + Convert.ToString(y2) + ")");

                }
                //Устанавливаем координаты линии зачеркивания
                this._line.SetXY(x1,y1,x2,y2);
                return 1;
            }
            return 0;
        }
        
        public void ShowList()
        {
            // MessageBox.Show(_cell.Show());
        }
        //Спрятать поле
        public void Hide()
        {
            this._line.bUseLine = false;
            //Очистка списка ячеек
            this.Figures.DeleteAll();
            this._leftCell = 0;
            this._lowCell = 0;
        }

        /// <summary>
        /// Переместить поле
        /// </summary>
        /// <param name="dX">Координаты</param>
        /// <param name="dY">отклонения</param>
        public void Move(int dX, int dY)
        {
            var context = new DrawingContext { CellSize = cellSize, Distance = dist };

            if (this._line.bUseLine)
            {
                this._line.HideLine(_e, context);
                this._line.MoveLineXY(dX, dY);
            }
          
            // Рисуем решетку
            for (int x = 0; x <= this.Columns; x++)
            {
                this._e.DrawLine(new MonoPen(Color.Black, 1), this.dist + x * this.cellSize, this.dist, this.dist + x * this.cellSize,this._width - 2 * this.dist - 1);
                this._e.DrawLine(new MonoPen(Color.Black, 1), this.dist, this.dist + x * this.cellSize, this._width - 2 * this.dist - 1, this.dist + x * this.cellSize);
            }

            foreach (var figure in Figures)
            {
                this.ClearItem(figure.X, figure.Y);

                figure.Draw(_e, context);
            }

            // Вывод линии
            this._lowCell = this._lowCell + dY;
            this._leftCell = this._leftCell + dX;
            if (this._line.bUseLine)
            {
                this._line.Draw(_e, context);
            }
        }

        // Ход игрока
        public Figure ComputerStep(ref string message)
        {
            return this.Figures.ComputerStep(ref message, this._lowCell, this._leftCell);
        }
    }
}
