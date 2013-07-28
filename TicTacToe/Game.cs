using System;

namespace GamePanelApplication
{
    using TicTacToe;
    using TicTacToe.Interfaces;

    //Перечислимый тип - крестик или нолик или ничего.

    public class Game
    {   
        public GameMode _gamers;

        // Номер ходящего игрока
        public int _step;

        // Вариант правил игры
        public int _rule;

        // Предел времени
        public int _maxTime;

        // Запущена игра или нет
        public bool _gameIsGoing;

        // Отображать поле или нет
        public bool _paintField;

        // Игровое поле
        public Field Field;

        // Игроки
        public Player Player1;
        public Player Player2;
        
        // Графика
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
            Field = new Field(gameForm.CreateGraphics(), gameForm.Width, gameForm.Height);
            Player1 = new Player(FigureType.X, gameForm.CreateGraphics());
            Player2 = new Player(FigureType.O, gameForm.CreateGraphics());
            Player1._bUseTarget = true;
            Player2._bUseTarget = true;
            _gameIsGoing = true;
            _paintField = true;
            Field.SetFieldWidth(gameForm.Width);
            //Отображение поля
            Field.Draw();
            if (_rule == 2)
            {
                //Обнуление очков перед началом игры
                Player1._score = 0;
                Player2._score = 0;
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
        public void MoveGameField(int dx, int dy)
        {
            // Передвинуть само поле
            Field.Move(-dx, -dy);
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
                // Ход первого игрока
                if (_step == 1)
                {
                    string str = "!!!";
                    //Нахождение координат ячейки
                    Figure Item = Field.Figures.ComputerStep(ref str, (int)Field.Origin.X, (int)Field.Origin.Y);
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
                // Ход второго игрока
                if (_step == 2)
                {
                    string str = "!!!";
                    Figure Item = Field.Figures.ComputerStep(ref str, (int)Field.Origin.X, (int)Field.Origin.Y);
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
                    Figure Item = Field.Figures.ComputerStep(ref str, (int)Field.Origin.X, (int)Field.Origin.Y);

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
            var worldPoint = Field.ConvertToWorld(new Point(X, Y));

            // Наводим цель игрока
            Field.Player1Target.Position.Set(worldPoint);

            if ((Message = Field.TrySetFigure(worldPoint, value)) != string.Empty)
            {
                return 0;
            }

            var figure = Field.Figures[worldPoint];
            
            // Нарисовать крестик
            var context = Field.CreateDrawingContext();

            figure.Draw(Field._e, context);

            //Проверка на победу игрока
            int end = Field.Check(worldPoint.X, worldPoint.Y, _rule);
            if (_rule == 2)
            {
                //Суммирование очков
                if (value == FigureType.X)
                    Player1.AddScore(Field.Figures.CalcScore());
                if (value == FigureType.O)
                    Player2.AddScore(Field.Figures.CalcScore());
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

            Player1._bUseTarget = false;
            Player2._bUseTarget = false;

            //Вывод сообщения
            if (_rule == 1)
            {
                Field.Draw();
                if (_step == 1) form1.ShowMessage("Победили 'крестики'! Нажмите 'Выход в меню'.");
                if (_step == 2) form1.ShowMessage("Победили 'нолики'! Нажмите 'Выход в меню'.");

            }

            if (_rule == 2)
            {
                string str = "";
                
                if (Player1._score > Player2._score)
                    str = str + " Победили 'крестики' ";
                if (Player1._score < Player2._score)
                    str = str + " Победили 'нолики' ";
                if (Player1._score == Player2._score)
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

            Field.Dispose();
            _step = 1;
        }
    }  
}
