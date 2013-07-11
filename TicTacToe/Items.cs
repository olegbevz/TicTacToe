using System;
using System.Collections.Generic;

using GamePanelApplication;
namespace ItemsApplication
{
    public enum FigureType { X, O, empty};
   
    public struct Directions
    {
        public int Hdir1, Hdir2, Vdir1, Vdir2, Ddir1, Ddir2, Ddir3, Ddir4;
    }

    public class FigureSequence
    {
        const int maxLength = 5;
        const int dist = 3;
        public Directions dir;
        public List<Figure> _cells = new List<Figure>();
      
        private int _maxLeft;
        public int MaxLeft
        {
            set
            {
                if ((value < 32767) & (value > -32768))
                    _maxLeft = value;
            }
            get
            {
                return _maxLeft;
            }
        }
        private int _maxRight;
        public int MaxRight
        {
            set
            {
                if ((value < 32767) & (value > -32768))
                    _maxRight = value;
            }
            get
            {
                return _maxRight;
            }
        }
        private int _maxHeight;
        public int MaxHeight
        {
            set
            {
                if ((value < 32767) & (value > -32768))
                    _maxHeight = value;
            }
            get
            {
                return _maxHeight;
            }
        }
        private int _maxLow;
        public int MaxLow
        {
            set
            {
                if ((value < 32767) & (value > -32768))
                    _maxLow = value;
            }
            get
            {
                return _maxLow;
            }
        }
        public FigureSequence()
        {
            MaxLeft = 1;
            MaxRight = 10;
            MaxHeight = 10;
            MaxLow = 1;
        }
        public int SetValue(int x, int y,int value)
        {
            //Проверка не занята ли клетка
            for (int i = 0; i < _cells.Count; i++)
            {
                if ((_cells[i].X == x) && (_cells[i].Y == y)) return 0;
            }

            //Проверка не указана ли клетка в не разрешенной области
            if (x < MaxLeft) return -1;
            if (x > MaxRight) return -1;
            if (y > MaxHeight) return -1;
            if (y < MaxLow) return -1;


            var Item = new Figure(x, y);
            Item._value = value;
            _cells.Add(Item);
            //_matr[_index]._x = x;
            //_matr[_index]._y = y;
            //_matr[_index]._value = value;
            //Установка новых границ
            if (x < MaxLeft + dist) MaxLeft = x - dist;

            if (x > MaxRight - dist) MaxRight = x + dist;
            if (y > _maxHeight - dist) _maxHeight = y + dist;
            if (y < _maxLow+dist) _maxLow = y-dist;
            //Console.Write("{0}.Клетке ({1},{2}) присвоено значение {3}\n", _index, matr[_index]._x, matr[_index]._y, matr[_index]._value);
            return 1;
        }
        public int GetValue(int x, int y)
        {
            for (int i = 0; i < _cells.Count; i++)
            {
                if ((_cells[i].X == x) && (_cells[i].Y == y)) 
                    return _cells[i]._value;
            }
            return 0;
        }
        public String Show()
        {
            String S = "";

            for (int i = 0; i < _cells.Count; i++)
            {
                S = S + Convert.ToString(i) + ". (" + Convert.ToString(_cells[i].X) + "." + Convert.ToString(_cells[i].Y) + ") = " + Convert.ToString(_cells[i]._value) + "\n";
            }
            return S;
        }
        public void Delete(int x, int y)
        {
            int delIndex = 0;
            for (int i = 0; i < _cells.Count; i++)
            {
                if ((_cells[i].X == x) && (_cells[i].Y == y))
                { delIndex = i; break; }
            }
            //Console.Write("{0}",delIndex);
            if (delIndex != 0)
                _cells.RemoveAt(delIndex);
            else
                DeleteAll();
        }
        public void DeleteAll()
        {
            _cells.RemoveRange(0, _cells.Count);
            MaxLeft = 1;
            MaxRight = 10;
            _maxHeight = 10;
            _maxLow = 1;
        }

        public int Check(int x, int y,int value)
        {

            dir.Hdir1 = 0;
            dir.Hdir2 = 0;
            dir.Vdir1 = 0;
            dir.Vdir2 = 0;
            dir.Ddir1 = 0;
            dir.Ddir2 = 0;
            dir.Ddir3 = 0;
            dir.Ddir4 = 0;
           
            do { dir.Hdir1++; } while (GetValue(x + dir.Hdir1, y) == value);
            do { dir.Hdir2++; } while (GetValue(x - dir.Hdir2, y) == value);
            do { dir.Vdir1++; } while (GetValue(x, y + dir.Vdir1) == value);
            do { dir.Vdir2++; } while (GetValue(x, y - dir.Vdir2) == value);
            do { dir.Ddir1++; } while (GetValue(x + dir.Ddir1, y + dir.Ddir1) == value);
            do { dir.Ddir2++; } while (GetValue(x - dir.Ddir2, y - dir.Ddir2) == value);
            do { dir.Ddir3++; } while (GetValue(x - dir.Ddir3, y + dir.Ddir3) == value);
            do { dir.Ddir4++; } while (GetValue(x + dir.Ddir4, y - dir.Ddir4) == value);
            dir.Hdir1--;
            dir.Hdir2--;
            dir.Vdir1--;
            dir.Vdir2--;
            dir.Ddir1--;
            dir.Ddir2--;
            dir.Ddir3--;
            dir.Ddir4--;
            if (dir.Hdir1 + dir.Hdir2 + 1 >= maxLength) return 1;
            if (dir.Vdir1 + dir.Vdir2 + 1 >= maxLength) return 1;
            if (dir.Ddir1 + dir.Ddir2 + 1 >= maxLength) return 1;
            if (dir.Ddir3 + dir.Ddir4 + 1 >= maxLength) return 1;
            return 0;
        }
        public int CalcScore()
        {
            return (dir.Hdir1 + dir.Hdir2 + dir.Vdir1 + dir.Vdir2 + dir.Ddir1 + dir.Ddir2 + dir.Ddir3 + dir.Ddir4);
        }
        public Figure ComputerStep(ref string message,int lowCell,int leftCell)
        {
            Random random = new Random();
          //  double res = GetCellValue(5,5,ref message);
            
            //Проверка последнего хода игрока
            message = "Размер матрицы:" + Convert.ToString(MaxLeft) + "," + Convert.ToString(MaxLow) + " -> "
             + Convert.ToString(MaxRight) + "," + Convert.ToString(MaxHeight);
            int maxX = MaxRight - MaxLeft;
            int maxY = MaxHeight - MaxLow;
           
         
           double[,] valueMatr = new  double[maxX,maxY];
           message = message + "\n Матрица: \n";
           
           Figure Item = null;

           double maxValue = 0; 

             //Поиск максимальной оценки
           for (int indY = MaxLow; indY <= MaxHeight; indY++)
            {
                for (int indX = MaxLeft; indX <= MaxRight; indX++)
                {
                    double CurValue = GetCellValue(indX,indY,ref message);
                    
                    message = message + Convert.ToString(CurValue) + " ";
                    if (maxValue<CurValue)
                    {
                        maxValue=CurValue;
                        Item = new Figure(indX - leftCell, indY - lowCell);
                    }
                    if (maxValue == CurValue)
                    {
                        if (random.Next(2) == 1)
                        {
                            Item = new Figure(indX - leftCell, indY - lowCell);
                        }
                    }
                }
                message = message + "\n" ;
            }
           Item._value = 0;
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
            return Item;
        }
        
        double CalcValue()
        {
            double value1 = Math.Pow(5,dir.Ddir1+dir.Ddir2);
            double value2 = Math.Pow(5,dir.Ddir3+dir.Ddir4);
            double value3 = Math.Pow(5,dir.Hdir1+dir.Hdir2);
            double value4 = Math.Pow(5,dir.Vdir1+dir.Vdir2);
            double value = value1 + value2 + value3 + value4;
            if (dir.Hdir1!=0&&dir.Hdir2!=0&&dir.Vdir1!=0&&dir.Vdir2!=0)
                value = value * 9999;
            return value;
        }
        double GetCellValue(int x,int y,ref string message)
        {
            if (GetValue(x, y) != 0) return 0;
            Check(x,y,2);
            double M = CalcValue();   
            Check(x,y,1);
            double N = CalcValue();          
            double Q = 1;
            double F = M + Q * N;
           // message =Convert.ToString(F)+"="+ Convert.ToString(M)+"+"+Convert.ToString(Q)+"*"+Convert.ToString(N);
            return F;
        }
        }
    }
  

