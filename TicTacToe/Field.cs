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
        public Point Origin = new Point();
        //Размеры поля в пикселах
        private int _width;
        private int height;
        //Список ячеек
        public FigureSequence Figures = new FigureSequence();
        public Grid Grid = new Grid();
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
            return X + Origin.X;
        }
        private int ConvertYToWorld(int Y)
        {
            return Y + Origin.Y;
        }

        /// <summary>
        /// Нарисовать поле
        /// </summary>
        public void Draw()
        {
            var context = CreateDrawingContext();

            // Рисуем решетку
            Grid.Draw(_e, context);

            this.Figures.Draw(_e, context);

            // Вывод линии
            if (_line.bUseLine)
            {
                _line.Draw(_e, context);
            }
        }

        private DrawingContext CreateDrawingContext()
        {
            return new DrawingContext
                              {
                                  CellSize = this.cellSize,
                                  Distance = this.dist,
                                  Columns = this.Columns,
                                  Rows = this.Rows,
                                  Height = this.height,
                                  Width = this._width
                              };
        }

        /// <summary>
        /// Очистка поля
        /// </summary>
        public void Clear()
        {
            var context = this.CreateDrawingContext();

            Figures.Hide(_e, context);

            if (this._line.bUseLine)
                this._line.Hide(_e, context);
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
        
        //Спрятать поле
        public void Dispose()
        {
            this._line.bUseLine = false;
            //Очистка списка ячеек
            this.Figures.DeleteAll();
            Origin = null;
        }

        /// <summary>
        /// Переместить поле
        /// </summary>
        /// <param name="dX">Координаты</param>
        /// <param name="dY">отклонения</param>
        public void Move(int dX, int dY)
        {
            var context = this.CreateDrawingContext();

            if (this._line.bUseLine)
            {
                _line.Hide(_e, context);
                _line.Move(dX, dY);
            }

            Figures.Hide(_e, context);

            Origin = new Point(Origin.X + dX, Origin.Y + dY);

            // Рисуем решетку
            Grid.Draw(_e, context);

            this.Figures.Draw(_e, context);

            // Вывод линии
            if (_line.bUseLine)
            {
                _line.Draw(_e, context);
            }
        }

        // Ход игрока
        public Figure ComputerStep(ref string message)
        {
            return this.Figures.ComputerStep(ref message, Origin.X, Origin.Y);
        }
    }
}
