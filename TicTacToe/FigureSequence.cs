namespace TicTacToe
{
    using System;
    using System.Collections.Generic;

    using GamePanelApplication;

    using System.Collections;
    using System.Linq;

    using TicTacToe.Interfaces;

    public struct Directions
    {
        public int Hdir1, Hdir2, Vdir1, Vdir2, Ddir1, Ddir2, Ddir3, Ddir4;
    }

    public class FigureSequence : IEnumerable<Figure>, IDrawable
    {
        const int maxLength = 5;
        const int dist = 3;
        public Directions dir;
        private List<Figure> _figures = new List<Figure>();

        public IEnumerable<Figure> Figures
        {
            get
            {
                return this._figures;
            }
        }

        public int MaxLeft { get; set; }

        public int MaxRight { get; set; }

        public int MaxHeight { get; set; }

        public int MaxLow { get; set; }

        public FigureSequence()
        {
            this.MaxLeft = 1;
            this.MaxRight = 10;
            this.MaxHeight = 10;
            this.MaxLow = 1;
        }

        public void SetFigure(Point point, FigureType figureType)
        {
            SetFigure(point.X, point.Y, figureType);
        }

        public void SetFigure(int x, int y, FigureType figureType)
        {
            // Проверка не занята ли клетка
            if (this.GetFigureType(x, y) != FigureType.Empty)
            {
                throw new Exception("Ячейка уже занята");
            }

            // Проверка не указана ли клетка в не разрешенной области
            if ((x < this.MaxLeft) || (x > this.MaxRight) || (y > this.MaxHeight) || (y < this.MaxLow))
            {
                throw new Exception("Ячейка находится слишком далеко");
            }

            _figures.Add(FigureFactory.Create(x, y, figureType));

            // Установка новых границ
            UpdateBoundsByLastPoint(x, y);
        }

        private void UpdateBoundsByLastPoint(int x, int y)
        {
            if (x < this.MaxLeft + dist)
            {
                this.MaxLeft = x - dist;
            }

            if (x > this.MaxRight - dist)
            {
                this.MaxRight = x + dist;
            }

            if (y > this.MaxHeight - dist)
            {
                this.MaxHeight = y + dist;
            }

            if (y < this.MaxLow + dist)
            {
                this.MaxLow = y - dist;
            }
        }

        public Figure this[int x, int y]
        {
            get
            {
                return this[new Point(x, y)];
            }
        }

        public Figure this[Point point]
        {
            get
            {
                return this._figures.FirstOrDefault(x => x.Position.Equals(point));
            }
        }

        public FigureType GetFigureType(int x, int y)
        {
            var point = new Point(x, y);

            var figure = this[point];

            if (figure == null)
            {
                return FigureType.Empty;
            }

            return figure.Type;
        }

        public override string ToString()
        {
            var s = string.Empty;

            for (var i = 0; i < this._figures.Count; i++)
            {
                s = s + Convert.ToString(i) + ". (" + Convert.ToString(this._figures[i].X) + "." + Convert.ToString(this._figures[i].Y) + ") = " + Convert.ToString(this._figures[i].Type) + "\n";
            }

            return s;
        }

        public void Draw(IGraphics graphics, DrawingContext context)
        {
            foreach (var figure in Figures)
            {
                figure.Draw(graphics, context);
            }
        }

        public void Hide(IGraphics graphics, DrawingContext context)
        {
            foreach (var figure in Figures)
            {
                figure.Hide(graphics, context);
            }
        }

        public void DeleteFigure(int x, int y)
        {
            var figure = this[new Point(x, y)];

            if (figure != null)
            {
                this._figures.Remove(figure);
            }
            else
            {
                this.DeleteAll();
            }
        }

        public void DeleteAll()
        {
            this._figures.RemoveRange(0, this._figures.Count);
            this.MaxLeft = 1;
            this.MaxRight = 10;
            this.MaxHeight = 10;
            this.MaxLow = 1;
        }

        public int Check(int x, int y, FigureType type)
        {
            this.dir.Hdir1 = 0;
            this.dir.Hdir2 = 0;
            this.dir.Vdir1 = 0;
            this.dir.Vdir2 = 0;
            this.dir.Ddir1 = 0;
            this.dir.Ddir2 = 0;
            this.dir.Ddir3 = 0;
            this.dir.Ddir4 = 0;
           
            do { this.dir.Hdir1++; } while (this.GetFigureType(x + this.dir.Hdir1, y) == type);
            do { this.dir.Hdir2++; } while (this.GetFigureType(x - this.dir.Hdir2, y) == type);
            do { this.dir.Vdir1++; } while (this.GetFigureType(x, y + this.dir.Vdir1) == type);
            do { this.dir.Vdir2++; } while (this.GetFigureType(x, y - this.dir.Vdir2) == type);
            do { this.dir.Ddir1++; } while (this.GetFigureType(x + this.dir.Ddir1, y + this.dir.Ddir1) == type);
            do { this.dir.Ddir2++; } while (this.GetFigureType(x - this.dir.Ddir2, y - this.dir.Ddir2) == type);
            do { this.dir.Ddir3++; } while (this.GetFigureType(x - this.dir.Ddir3, y + this.dir.Ddir3) == type);
            do { this.dir.Ddir4++; } while (this.GetFigureType(x + this.dir.Ddir4, y - this.dir.Ddir4) == type);
            this.dir.Hdir1--;
            this.dir.Hdir2--;
            this.dir.Vdir1--;
            this.dir.Vdir2--;
            this.dir.Ddir1--;
            this.dir.Ddir2--;
            this.dir.Ddir3--;
            this.dir.Ddir4--;
            if (this.dir.Hdir1 + this.dir.Hdir2 + 1 >= maxLength) return 1;
            if (this.dir.Vdir1 + this.dir.Vdir2 + 1 >= maxLength) return 1;
            if (this.dir.Ddir1 + this.dir.Ddir2 + 1 >= maxLength) return 1;
            if (this.dir.Ddir3 + this.dir.Ddir4 + 1 >= maxLength) return 1;
            return 0;
        }

        public int CalcScore()
        {
            return (this.dir.Hdir1 + this.dir.Hdir2 + this.dir.Vdir1 + this.dir.Vdir2 + this.dir.Ddir1 + this.dir.Ddir2 + this.dir.Ddir3 + this.dir.Ddir4);
        }
        public Point ComputerStep(ref string message)
        {
            Random random = new Random();
          //  double res = GetCellValue(5,5,ref message);
            
            //Проверка последнего хода игрока
            int maxX = this.MaxRight - this.MaxLeft;
            int maxY = this.MaxHeight - this.MaxLow;

            Point point = null;

            double maxValue = 0; 

             //Поиск максимальной оценки
            for (var y = this.MaxLow; y <= this.MaxHeight; y++)
            {
                for (var x = this.MaxLeft; x <= this.MaxRight; x++)
                {
                    double CurValue = this.GetCellValue(x, y, ref message);
                    
                    if (maxValue<CurValue)
                    {
                        maxValue=CurValue;
                        point = new Point(x, y);
                    }
                    if (maxValue == CurValue)
                    {
                        if (random.Next(2) == 1)
                        {
                            point = new Point(x, y);
                        }
                    }
                }
            }
             /*
             for (int indY = maxLow; indY <= maxHigh; indY++)
             {
                 for (int indX = maxLeft; indX <= maxRight; indX++)
                 {
                     double CurValue = GetCellValue(indX, indY, ref message);

                     message = message + Convert.ToString(CurValue) + " ";
                     if (maxValue < CurValue)
                     {
                         maxValue = CurValue;
                     }
                 }
                 message = message + "\n";
             }
             message=message + "Выбрана: " + Convert.ToString(maxValue);
           */
                 /*do
                    {
                        Item._x = random.Next(11);
                        Item._y = random.Next(11);

                    } while (GetValue(Item._x, Item._y) != 0);*/
            
             //Item._x = Item._x - leftCell;
            //Item._y = Item._y - lowCell;
        
            //MessageBox.Show("Ход компьютера");
            return point;
        }
        
        double CalcValue()
        {
            double value1 = Math.Pow(5,this.dir.Ddir1+this.dir.Ddir2);
            double value2 = Math.Pow(5,this.dir.Ddir3+this.dir.Ddir4);
            double value3 = Math.Pow(5,this.dir.Hdir1+this.dir.Hdir2);
            double value4 = Math.Pow(5,this.dir.Vdir1+this.dir.Vdir2);
            double value = value1 + value2 + value3 + value4;
            if (this.dir.Hdir1!=0&&this.dir.Hdir2!=0&&this.dir.Vdir1!=0&&this.dir.Vdir2!=0)
                value = value * 9999;
            return value;
        }

        double GetCellValue(int x,int y,ref string message)
        {
            if (this.GetFigureType(x, y) != FigureType.Empty) return 0;
            this.Check(x,y, FigureType.O);
            double M = this.CalcValue();   
            this.Check(x,y, FigureType.X);
            double N = this.CalcValue();          
            double Q = 1;
            double F = M + Q * N;
           // message =Convert.ToString(F)+"="+ Convert.ToString(M)+"+"+Convert.ToString(Q)+"*"+Convert.ToString(N);
            return F;
        }

        public IEnumerator<Figure> GetEnumerator()
        {
            return this._figures.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
    }
  

