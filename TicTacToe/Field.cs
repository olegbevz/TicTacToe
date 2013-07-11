namespace TicTacToe 
{
    using System;

    using BattleGround;

    using ItemsApplication;

    using GamePanelApplication;

    using TicTacToe.Interfaces;

    public class Field
    {
        private readonly int ShadowShift = 3;

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
        public FigureSequence _cell = new FigureSequence();
        IGraphics _e;
        //Зачеркивающая линия
        public Line _line;

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
            this._line = new Line(this._e);
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
        private int ConvertX(int X)
        {
            return (X + this._leftCell);
        }
        private int ConvertY(int Y)
        {
            return (Y + this._lowCell);
        }
        /// <summary>
        /// Нарисовать поле
        /// </summary>
        public void Show()
        {
            // Рисуем решетку
            this.DrawVerticalLines();

            this.DrawHorizontalLines();

            for (var x = 1; x <= this.Columns; x=x+1)
            {
                for (var y = 1; y <= this.Rows; y++)
                {
                    // Если в данной ячейке расположен нолик - вывести нолик
                    if (this._cell.GetValue(this.ConvertX(x), this.ConvertY(y)) == 2)
                    {                     
                        this.DrawNull(x, y);
                    }

                    // Если в данной ячейке расположен крестик - вывести крестик
                    if (this._cell.GetValue(this.ConvertX(x), this.ConvertY(y)) == 1)
                    {                        
                        this.DrawKrest(x, y);
                    }
                }
            }

            //Вывод линии
            if (_line.bUseLine)
            {
                _line.cellSize = this.cellSize;

                _line.DrawLine();
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
            for (int i = 1; i <= this.Columns; i++)
                for (int j = 1; j <= this.Columns; j++)
                {
                    //Если ячейка занята очистить её
                    if (this._cell.GetValue(this.ConvertX(i), this.ConvertY(j)) != 0) 
                        this.ClearItem(i, j);
                }
            //Спрятать линию
            if (this._line.bUseLine)
                this._line.HideLine();
        }
        /// <summary>
        /// Проверка ячейки
        /// </summary>
        /// <param name="x">Координаты ячейки</param>
        /// <param name="y"></param>
        /// <param name="value">Значение ячейки</param>
        /// <param name="Message">Сообщение на выходе</param>
        /// <returns></returns>
        public int CheckItem(int x, int y,int value, ref String Message)
        {
            int error = this._cell.SetValue(this.ConvertX(x), this.ConvertY(y), value);
            //MessageBox.Show("!!");
            //Если ячейка занята
            if (error == 0)
            {
                Message = "Ячейка уже занята";
                return 0;
            }
            //Если ячейка находится слишком далеко
            if (error == -1)
            {
                Message = "Ячейка находится слишком далеко";
                return 0;
            }
            if (error == 1) Message = "";
            return error;
        }
        //Нарисовать крестик
        public int DrawKrest(int x, int y)
        {    
            //Начальные координаты
            int startX = 5 * this.dist + this.cellSize * (x - 1);
            int startY = 5 * this.dist + this.cellSize * (y - 1);
            //Конечные координаты
            int endX = startX + this.cellSize - 8 * this.dist;
            int endY = startY + this.cellSize - 8 * this.dist;

            using (MonoPen pen = new MonoPen(Color.Gray, 8))
            {
                this._e.DrawLine(pen, startX - this.ShadowShift, startY + this.ShadowShift, endX - this.ShadowShift, endY + this.ShadowShift);
                this._e.DrawLine(pen, startX - this.ShadowShift, endY + this.ShadowShift, endX - this.ShadowShift, startY + this.ShadowShift);
            }

            using (MonoPen pen = new MonoPen(Color.Red, 8))
            {
                this._e.DrawLine(pen, startX, startY, endX, endY);
                this._e.DrawLine(pen, startX, endY, endX, startY);
            }
            return 1;
        }     
        //Нарисовать нолик
        public int DrawNull(int x, int y)
        {
            //Центр круга
            int rad = this.cellSize / 2;
            int centX = rad / 2 + this.dist + this.cellSize * (x - 1);
            int centY = rad / 2 + this.dist + this.cellSize * (y - 1);

            var widthOffset = (int)(rad * 0.1);

            using (MonoPen pen = new MonoPen(Color.Gray, 8))
            {
                this._e.DrawEllipse(pen, centX - this.ShadowShift + widthOffset, centY + this.ShadowShift, rad - (widthOffset * 2), rad);
            }

            using (MonoPen pen = new MonoPen(Color.Blue, 8))
            {
                this._e.DrawEllipse(pen, centX + widthOffset, centY, rad - (widthOffset * 2), rad);
            }
            return 1;
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
            int value = this._cell.GetValue(this.ConvertX(x), this.ConvertY(y));
           
            if (this._cell.Check(this.ConvertX(x),this.ConvertY(y),value) == 1)
            {
                if (gameRule == 2) return 0;
                int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
                //Если в ряд по горизонтали составлено более 5 фишек
                if (this._cell.dir.Hdir1 + this._cell.dir.Hdir2 + 1 >= 5)
                {
                    x1 = x + this._cell.dir.Hdir1;
                    x2 = x - this._cell.dir.Hdir2;
                    y1 = y; y2 = y;
                }
                //Если в ряд по вертикали составлено более 5 фишек
                if (this._cell.dir.Vdir1 + this._cell.dir.Vdir2 + 1 >= 5)
                {
                    y1 = y + this._cell.dir.Vdir1;
                    y2 = y - this._cell.dir.Vdir2;
                    x1 = x; x2 = x;
                }
                //Если в ряд по дигонали составлено более 5 фишек
                if (this._cell.dir.Ddir1 + this._cell.dir.Ddir2 + 1 >= 5)
                {

                    x1 = x + this._cell.dir.Ddir1;
                    y1 = y + this._cell.dir.Ddir1;
                    x2 = x - this._cell.dir.Ddir2;
                    y2 = y - this._cell.dir.Ddir2;
                    //MessageBox.Show("1.2(" + Convert.ToString(x1) + "," + Convert.ToString(y1) + ")-(" + Convert.ToString(x2) + "," + Convert.ToString(y2) + ")");

                }
                if (this._cell.dir.Ddir3 + this._cell.dir.Ddir4 + 1 >= 5)
                {

                    x1 = x - this._cell.dir.Ddir3;
                    y1 = y + this._cell.dir.Ddir3;
                    x2 = x + this._cell.dir.Ddir4;
                    y2 = y - this._cell.dir.Ddir4;
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
            this._cell.DeleteAll();
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
            if (this._line.bUseLine)
            {
                this._line.HideLine();
                this._line.MoveLineXY(dX, dY);
            }
          
            //Рисуем решетку
            for (int x = 0; x <= this.Columns; x++)
            {
                this._e.DrawLine(new MonoPen(Color.Black, 1), this.dist + x * this.cellSize, this.dist, this.dist + x * this.cellSize,this._width - 2 * this.dist - 1);
                this._e.DrawLine(new MonoPen(Color.Black, 1), this.dist, this.dist + x * this.cellSize, this._width - 2 * this.dist - 1, this.dist + x * this.cellSize);
            }
            for (int i = 1; i <= this.Columns; i=i+1)
            {
                for (int j = 1; j <= this.Columns; j++)
                { 
                    //Стираем старое положение
                    if (this._cell.GetValue(this.ConvertX(i), this.ConvertY(j)) != 0)
                    {
                        this.ClearItem(i,j);
                    }
                    //Если в данной ячейке расположен нолик - вывести нолик
                    if (this._cell.GetValue(this.ConvertX(i+dX), this.ConvertY(j+dY)) == 2)
                    {                     
                        this.DrawNull(i, j);
                    }
                    //Если в данной ячейке расположен крестик - вывести крестик
                    if (this._cell.GetValue(this.ConvertX(i+dX), this.ConvertY(j+dY)) == 1)
                    {                        
                        this.DrawKrest(i, j);
                    }
                }
            }
            //Вывод линии
            
        
            this._lowCell = this._lowCell + dY;
            this._leftCell = this._leftCell + dX;
            if (this._line.bUseLine)
            {
                this._line.DrawLine();
            }
           
        }
        //Ход игрока
        public Figure ComputerStep(ref string message)
        {
            return this._cell.ComputerStep(ref message,this._lowCell,this._leftCell);
        }
    }
}
