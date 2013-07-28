namespace TicTacToe 
{
    using System;

    using TicTacToe.Interfaces;

    public class Field
    {
        //Ширина ячейки и отступ от краев поля
        public int cellSize = 32;
        public int dist = 3;
        
        // Координаты текущего положения матрицы просмотра
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

        public PlayerTarget Player1Target = new PlayerTarget(0, 0, FigureType.X);
        public PlayerTarget Player2Target = new PlayerTarget(0, 0, FigureType.O);

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

        // Конвертирование координат на матрице просмотра в мировые координаты
        public Point ConvertToWorld(Point localPoint)
        {
            return new Point(
                localPoint.X + Origin.X, 
                localPoint.Y + Origin.Y);
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
            if (_line != null)
            {
                _line.Draw(_e, context);
            }

            //Player1Target.Draw(_e, context);
            //Player2Target.Draw(_e, context);
        }

        public DrawingContext CreateDrawingContext()
        {
            return new DrawingContext
                              {
                                  CellSize = this.cellSize,
                                  Distance = this.dist,
                                  Columns = this.Columns,
                                  Rows = this.Rows,
                                  Height = this.height,
                                  Width = this._width,
                                  Origin = this.Origin
                              };
        }

        /// <summary>
        /// Очистка поля
        /// </summary>
        public void Hide()
        {
            var context = this.CreateDrawingContext();

            //Grid.Hide(_e, context);

            Figures.Hide(_e, context);

            if (_line != null)
            {
                this._line.Hide(_e, context);
            }

            //Player1Target.Hide(_e, context);
            //Player2Target.Hide(_e, context);
        }

        /// <summary>
        /// Проверка ячейки
        /// </summary>
        /// <param name="x">Координаты ячейки</param>
        /// <param name="y"></param>
        /// <param name="value">Значение ячейки</param>
        /// <returns></returns>
        public string TrySetFigure(Point point, FigureType figureType)
        {
            try
            {
                Figures.SetFigure(point, figureType);

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
            var value = this.Figures.GetFigureType(x, y);
           
            if (this.Figures.Check(x, y, value) == 1)
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
                this._line = new CrossLine(x1, y1, x2, y2);
                return 1;
            }
            return 0;
        }
        
        // Спрятать поле
        public void Dispose()
        {
            this._line = null;
            //Очистка списка ячеек
            this.Figures.DeleteAll();
            Origin = null;
        }

        /// <summary>
        /// Переместить поле
        /// </summary>
        /// <param name="shiftX">Координаты</param>
        /// <param name="shiftY">отклонения</param>
        public void Move(int shiftX, int shiftY)
        {
            this.Hide();

            Origin = new Point(Origin.X + shiftX, Origin.Y + shiftY);

            this.Draw();
        }

        // Ход игрока
        public Figure ComputerStep(ref string message)
        {
            return this.Figures.ComputerStep(ref message, (int)Origin.X, (int)Origin.Y);
        }
    }
}
