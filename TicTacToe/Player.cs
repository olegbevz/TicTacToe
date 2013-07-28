namespace TicTacToe
{
    using TicTacToe.Interfaces;

    public class Player
    {
        //Использовать цели или нет
        public bool _bUseTarget;
        //Фишка игрока
        //Очки игрока
        public int _score;

        public Player(FigureType Value, IGraphics e)
        {
            //Присваивание начальных параметров
            this._score = 0;
            this._bUseTarget = true;
        }

        //Добавить очки
        public void AddScore(int Score)
        {
            this._score = this._score + Score;
        }
    }
}
