using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Items;
using BattleGround;
using Desks;

namespace WindowsFormsApplication1
{
       
    public partial class GameForm : Form
    {
        const int cellWidth = 32, dist = 2;
        public GameForm()
        {
            InitializeComponent();
        }
      
        
      
        public class Player
        {
           
            Graphics graph;
            public bool _bUseTarget;
            private int _x;
            private int _y;
            private int _value;
            public int _score;
            public Player(int Value)
            {
                _x = 0;
                _y = 0;
                _value = Value;
                _score = 0;
                _bUseTarget = true;
                //graph = form1.panel2.CreateGraphics(); 
            }
            public void Set(int x, int y)
            {
                _x = x;
                _y = y;
            }
            public void MoveTargetXY(int dx, int dy)
            {
                _x = _x + dx;
                _y = _y + dy;
            }
          
            public int Go(int X, int Y, GameForm form1)
            {

                //MessageBox.Show(Convert.ToString(lastX) + " , " + Convert.ToString(lastY) + " -> " + Convert.ToString(X) + " , " + Convert.ToString(Y));
                HideTarget(form1);
                Set(X, Y);
                DrawTarget(form1);

                if (_value == 1) if (game._field.DrawKrest(X, Y, form1) == 0) return 0;
                if (_value == 2) if (game._field.DrawNull(X, Y, form1) == 0) return 0;
                int end = game._field.Check(X, Y,game._rule, form1);
                if (game._rule == 2) CalcScore();
                if ((end == 1) & (game._rule == 1))
                {      
                    form1.MenuPanel.Visible = true;
                    return 2;
                }
                return 1;
            }
            public void CalcScore()
            {
                _score = _score + game._field._cell.CalcScore();
            }
            public void DrawTarget(GameForm form1)
            {
                if (!_bUseTarget) return;
                graph = form1.GamePanel.CreateGraphics();
                //Начальные координаты
                int startX = 2 * dist + cellWidth * (_x - 1);
                int startY = 2 * dist + cellWidth * (_y - 1);
                //Конечные координаты
                int endX = 2 * dist + cellWidth * _x - 1;
                int endY = 2 * dist + cellWidth * _y - 1;

                if (_value == 1)
                    using (Pen pen = new Pen(Color.Blue, 3))
                        graph.DrawRectangle(pen, startX, startY, cellWidth - 2 * dist, cellWidth - 2 * dist);
                if (_value == 2)
                    using (Pen pen = new Pen(Color.Red, 3))
                        graph.DrawRectangle(pen, startX, startY, cellWidth - 2 * dist, cellWidth - 2 * dist);
            }
            public void HideTarget(GameForm form1)
            {
                if (!_bUseTarget) return;
                graph = form1.GamePanel.CreateGraphics();
                using (Pen pen = new Pen(Color.White, 3))
                {
                    //Начальные координаты
                    int startX = 2 * dist + cellWidth * (_x - 1);
                    int startY = 2 * dist + cellWidth * (_y - 1);
                    //Конечные координаты
                    int endX = 2 * dist + cellWidth * _x - 1;
                    int endY = 2 * dist + cellWidth * _y - 1;
                    graph.DrawRectangle(pen, startX, startY, cellWidth - 2 * dist, cellWidth - 2 * dist);
                }
            }
        }
      
        public class Game
        {
            public int _gamers;
            public int _step;
            public int _rule;
            public int _maxTime;
            public bool _bGameIsGoing;
            public Field _field = new Field();
            public Player _player1 = new Player(1);
            public Player _player2 = new Player(2);
            public StepDesk _desk = new StepDesk();
            public ScoreDesk _scoreDesk = new ScoreDesk();
            public Game()
            {
                _step = 1;
                _rule = 1;
                _maxTime = 60 * 1000;
                _bGameIsGoing = true;
            }
            public void Start(GameForm form1)
            {
                _player1._bUseTarget = true;
                _player2._bUseTarget = true;
                _bGameIsGoing = true;
                form1.MessagePanel.Visible = true;
                form1.CancelPanel.Visible = true;
                form1.MessageLabel.Text = "";
                _desk.Show(form1);
                _field.Show(form1);
                if (_rule == 2)
                {
                    _scoreDesk.Show(form1);
                    form1.GameTimer.Interval = _maxTime;
                    form1.GameTimer.Start();
                }

            }
            public void ComputersGame(GameForm form1)
            {
                int res=0;
                do
                {
                    if (_step == 1)
                    {
                        string str = "!!!";
                        Cell Item = _field._cell.ComputerStep(ref str, _field._lowCell, _field._leftCell);
                        res = _player1.Go(Item._x, Item._y, form1);
                        if (res == 2)
                        {
                            End(form1); 
                            return;
                        }
                        _step = 2;
                        _desk.ChangeStep(form1);
                       
                    }
                    if (_step == 2)
                    {
                        string str = "!!!";
                        Cell Item = _field._cell.ComputerStep(ref str, _field._lowCell, _field._leftCell);
                        res = _player2.Go(Item._x, Item._y, form1);
                        if (res == 2)
                        {
                            End(form1);
                            return;
                        }
                        _step = 1;
                        _desk.ChangeStep(form1);
                    }
                } while (res != 2);
            }
            public void Go(int X, int Y, GameForm form1)
            {
               
                if (_step == 1)
                {
                    int res = _player1.Go(X, Y, form1);
                    if (res == 0) return;
                    if (res == 2){End(form1);return;}
                    if (_gamers == 2)
                    {
                        _step = 2;
                        _desk.ChangeStep(form1);
                    }
                    if (_gamers == 1)
                    {
                        _desk.ChangeStep(form1);
                        string str="!!!";
                        Cell Item = _field._cell.ComputerStep(ref str,_field._lowCell,_field._leftCell);
                       
                       // Item._x = 0;
                        //res =_player2.Go(Item._x, Item._y, form1);
                       /* if (Item._x <= 0)
                       {
                            _field.Move(-(Item._x + 1), 0, form1);
                            _player1.MoveTarget(+(Item._x + 1),0,form1);
                            _player2.MoveTarget(+(Item._x + 1),0,form1);
                            
                        }*/

                            if (_player2.Go(Item._x, Item._y, form1) == 2) { _step = 2; End(form1); return; }
                        _desk.ChangeStep(form1);
                    }
                    _scoreDesk.ShowScore(_player1._score,_player2._score,form1);
                    return;
                }
                if (_step == 2)
                {

                    int res = _player2.Go(X, Y, form1);
                    if (res == 0) return;
                    if (res == 2) { End(form1); return; }
                    _step = 1;
                    _desk.ChangeStep(form1);
                    _scoreDesk.ShowScore(_player1._score, _player2._score, form1);
                    return;
                }
            }
            public void End(GameForm form1)
            {
                _player2.HideTarget(form1);
                _player2.HideTarget(form1);
                _player1._bUseTarget = false;
                _player2._bUseTarget = false;
                _field._line.DrawLine(form1);
                _bGameIsGoing = false;
                if (_rule == 1)
                {
                    if (_step == 1) form1.MessageLabel.Text = "Победили 'крестики'! Нажмите 'Выход в меню'.";
                    if (_step == 2) form1.MessageLabel.Text = "Победили 'нолики'! Нажмите 'Выход в меню'.";
                    
                }

                if (_rule == 2)
                {
                    string str = "Время вышло.";
                    _scoreDesk.Hide(form1);
                    if (_player1._score > _player2._score)
                        str = str + " Победили 'крестики' ";
                    if (_player1._score < _player2._score)
                        str = str + " Победили 'нолики' ";
                    if (_player1._score == _player2._score)
                        str = str + " Никто не победил. ";
                    str = str + "Нажмите 'Выход в меню'. ";
                    form1.MessageLabel.Text = str;

                }
               // _desk.Hide(form1);
               // _field.Hide(form1);
               // form1.panel7.Visible = false;
                _step = 1;

            }
            public void Cancel(GameForm form1)
            {
                _desk.Hide(form1);
                _scoreDesk.Hide(form1);
                _field.Hide(form1);
                form1.CancelPanel.Visible = false;
                form1.MessagePanel.Visible = false;
                _step = 1;
            }
        }
        static Game game = new Game();
       
        
       
  



       
       
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left)&&(game._bGameIsGoing))
            {
                int X = 1 + (e.X - 2 * dist) / cellWidth;
                int Y = 1 + (e.Y - 2 * dist) / cellWidth;
                game.Go(X,Y,this);
            }
     
        }

        private void button6_Click(object sender, EventArgs e)
        {
            game._player1.HideTarget(this);
            game._player2.HideTarget(this);
            game._field.Move(0,-1,this);
            game._player1.MoveTargetXY(0, 1);
            game._player2.MoveTargetXY(0, 1);
            game._player1.DrawTarget(this);
            game._player2.DrawTarget(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            game._player1.HideTarget(this);
            game._player2.HideTarget(this);
            game._field.Move(0, +1, this);
            game._player1.MoveTargetXY(0, -1);
            game._player2.MoveTargetXY(0, -1);
            game._player1.DrawTarget(this);
            game._player2.DrawTarget(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            game._player1.HideTarget(this);
            game._player2.HideTarget(this);
            game._field.Move(-1, 0, this);
            game._player1.MoveTargetXY(1,0);
            game._player2.MoveTargetXY(1,0);
            game._player1.DrawTarget(this);
            game._player2.DrawTarget(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            game._player1.HideTarget(this);
            game._player2.HideTarget(this);
            game._field.Move(+1, 0, this);
            game._player1.MoveTargetXY(-1, 0);
            game._player2.MoveTargetXY(-1, 0);
            game._player1.DrawTarget(this);
            game._player2.DrawTarget(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
             OptionPanel.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OptionPanel.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GameForm.ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            OptionPanel.Visible = false;
            MenuPanel.Visible = false;
            game._gamers = 2;
            game.Start(this);
            
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            FirstGameVariantCheckBox.Checked = false;
            SecondGameVarianCheckBox.Checked = true;
            GameTimeListBox.Enabled = true;
            game._rule = 2;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SecondGameVarianCheckBox.Checked = false;
            GameTimeListBox.Enabled = false;
            game._rule = 1;
            //checkBox1.Checked = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GameTimeListBox.GetSelected(0)) game._maxTime = 60*1000;
            if (GameTimeListBox.GetSelected(1)) game._maxTime = 2*60*1000;
            if (GameTimeListBox.GetSelected(2)) game._maxTime = 3*60*1000;
            if (GameTimeListBox.GetSelected(3)) game._maxTime = 5*60*1000;
            if (GameTimeListBox.GetSelected(4)) game._maxTime = 10*60*1000;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameTimer.Stop();
            game.End(this);
            MenuPanel.Visible = true;
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OptionPanel.Visible = false;
            MenuPanel.Visible = false;
            game._gamers = 1;
            game.Start(this);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = true;
            game.Cancel(this);
        }

        private void TwoComputersButton_Click(object sender, EventArgs e)
        {
            OptionPanel.Visible = false;
            MenuPanel.Visible = false;
            game._gamers = 0;
            game.Start(this);
            game.ComputersGame(this);

        }

       

     

       

      

        
       

     

     
    
     
        
   

    }
}
