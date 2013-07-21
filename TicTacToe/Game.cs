using System;

namespace GamePanelApplication
{
    using TicTacToe;
    using TicTacToe.Interfaces;

    //Перечислимый тип - крестик или нолик или ничего.

    public class Game
    {   
        
        public GameMode _gamers;
        //Номер ходящего игрока
        public int _step;
        //Вариант правил игры
        public int _rule;
        //Предел времени
        public int _maxTime;
        //Запущена игра или нет
        public bool _gameIsGoing;
        //Отображать поле или нет
        public bool _paintField;
        //Игровое поле
        public Field _field;
        //Игроки
        public Player _player1;
        public Player _player2;
        
        //Графика
        public IGraphics _graph;
        public Game()
        {
            //Первые ходят крестики
            _step = 1;
            //Вариант правил игры по умолчанию
            _rule = 1;
            //Время по умолчанию
            _maxTime = 60 * 1000;
            _gameIsGoing = false;
            _paintField = false;
            
        }

        public interface IGameView
        {
            IGraphics CreateGraphics();

            int Width { get; }

            int Height { get; }

            void ShowMessage(string message);
        }

        /// <summary>
        /// Начало игры
        /// </summary>
        /// <param name="form1">форма</param>
        public void Start(IGameView gameForm)
        {
            //Инициализация переменных
            _field = new Field(gameForm.CreateGraphics(), gameForm.Width, gameForm.Height);
            _player1 = new Player(FigureType.X, gameForm.CreateGraphics());
            _player2 = new Player(FigureType.O, gameForm.CreateGraphics());
            _player1._bUseTarget = true;
            _player2._bUseTarget = true;
            _gameIsGoing = true;
            _paintField = true;
            _field.SetFieldWidth(gameForm.Width);
            //Отображение поля
            _field.Draw();
            if (_rule == 2)
            {
                //Обнуление очков перед началом игры
                _player1._score = 0;
                _player2._score = 0;
                //Запуск таймера
                var timer = new System.Timers.Timer();

                timer.Interval = _maxTime;
                timer.Start();
            }

        }
        /// <summary>
        /// Передвинуть игровое поле с целями игроков
        /// </summary>
        /// <param name="dx">отколонение по Х</param>
        /// <param name="dy">отклонение по У</param>
        public void MoveGameField(int dx,int dy)
        {
            //Спрятать цели игроков
            _player1.HideTarget();
            _player2.HideTarget();
            //Передвинуть само поле
            _field.Move(-dx, -dy);
            //Передвинуть координаты целей
            _player1.MoveTargetXY(dx, dy);
            _player2.MoveTargetXY(dx, dy);
            //Отображение целей
            if (_player1._bUseTarget)
                _player1.DrawTarget();
            if (_player2._bUseTarget)
                _player2.DrawTarget();
        }
        /// <summary>
        /// Игра двух компьютеров
        /// </summary>
        /// <param name="form1">Форма</param>
        public void ComputersGame(IGameView form1)
        {
            String Message="";
            //Результат игры
            int res = 0;
            do
            {
                //Ход первого игрока
                if (_step == 1)
                {
                    string str = "!!!";
                    //Нахождение координат ячейки
                    Figure Item = _field.Figures.ComputerStep(ref str, _field._lowCell, _field._leftCell);
                    //Ход компьютера
                    res = PlayerStep(Item.X, Item.Y, FigureType.X,ref Message);
                    //Если игра окончена
                    if (res == 2)
                    {
                        End(form1);
                        return;
                    }
                    _step = 2;
                    

                }
                //Ход второго игрока
                if (_step == 2)
                {
                    string str = "!!!";
                    Figure Item = _field.Figures.ComputerStep(ref str, _field._lowCell, _field._leftCell);
                    res = PlayerStep(Item.X, Item.Y, FigureType.O,ref Message);
                    if (res == 2)
                    {
                        End(form1);
                        return;
                    }
                    _step = 1;
                    
                }
            } while (res != 2); //До тех пор пока игра не будет закончена
            form1.ShowMessage(Message);
        }
        /// <summary>
        /// Ход в игре
        /// </summary>
        /// <param name="X,У">Координаты хода</param>
        /// <param name="form1">Форма</param>
        public int Go(int X, int Y, IGameView form1, ref string Message)
        {
           // string Message="";
            int Result = 0;
            
            //Если ходит первый игрок
            if (_step == 1)
            {
                Result = PlayerStep(X, Y, FigureType.X,ref Message);
                if (Result == 0) return Result;
                if (Result == 2) { End(form1); return Result; }
                //Смена хода
                if (_gamers == GameMode.TwoPlayers)
                {
                    _step = 2;                   
                }
                //Ход компьютера
                if (_gamers == GameMode.OnePlayer)
                {
                    
                    string str = "!!!";
                    Figure Item = _field.Figures.ComputerStep(ref str, _field._lowCell, _field._leftCell);

                    if (PlayerStep(Item.X, Item.Y, FigureType.O,ref Message) == 2) 
                    { 
                        _step = 2; 
                        End(form1); 
                        return Result; 
                    }
                    
                }
                form1.ShowMessage(Message);
                return Result;
            }
            if (_step == 2)
            {
                Result = PlayerStep(X, Y, FigureType.O,ref Message);
                if (Result == 0) return Result;
                if (Result == 2) { End(form1); return Result; }
                _step = 1;
                return Result;
            }
            return Result;
        }
        /// <summary>
        /// Ход игрока
        /// </summary>
        /// <param name="X,У">Координаты ячейки</param>
        /// <param name="value">Фишка ходящего игрока</param>
        /// <returns></returns>
        public int PlayerStep(int X, int Y, FigureType value,ref String Message)
        {
            //Наводим цель игрока
            _player1.SetTarget(X, Y);

            if ((Message = _field.TrySetFigure(X, Y, (int)value)) != string.Empty)
            {
                return 0;
            }

            var figure = _field.Figures[X, Y];
            
            // Нарисовать крестик
            var context = new DrawingContext { CellSize = _field.cellSize, Distance = _field.dist };

                figure.Draw(_field._e, context);

            //Проверка на победу игрока
            int end =_field.Check(X, Y, _rule);
            if (_rule == 2)
            {
                //Суммирование очков
                if (value == FigureType.X)
                    _player1.AddScore(_field.Figures.CalcScore());
                if (value == FigureType.O)
                    _player2.AddScore(_field.Figures.CalcScore());
            }
            if ((end == 1) & (_rule == 1))
            {
                return 2;
            }
            return 1;
        }
        /// <summary>
        /// Конец игры
        /// </summary>
        /// <param name="form1">Форма</param>
        public void End(IGameView form1)
        {
            //Блокирование поля
            _gameIsGoing = false;

            _player1.HideTarget();
            _player2.HideTarget();
            _player1._bUseTarget = false;
            _player2._bUseTarget = false;

            //Вывод сообщения
            if (_rule == 1)
            {
                _field.Draw();
                if (_step == 1) form1.ShowMessage("Победили 'крестики'! Нажмите 'Выход в меню'.");
                if (_step == 2) form1.ShowMessage("Победили 'нолики'! Нажмите 'Выход в меню'.");

            }

            if (_rule == 2)
            {
                string str = "";
                
                if (_player1._score > _player2._score)
                    str = str + " Победили 'крестики' ";
                if (_player1._score < _player2._score)
                    str = str + " Победили 'нолики' ";
                if (_player1._score == _player2._score)
                    str = str + " Никто не победил. ";
                str = str + "Нажмите 'Выход в меню'. ";
                form1.ShowMessage(str);
            }
          
            _step = 1;

        }

        /// <summary>
        /// Выход из игры
        /// </summary>
        /// <param name="form1">Форма</param>
        public void Cancel()
        {
            _paintField = false;
            _gameIsGoing = false;

            _field.Hide();
            _step = 1;
        }
    }  
}
