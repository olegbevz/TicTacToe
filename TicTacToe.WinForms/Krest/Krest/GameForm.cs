using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GamePanelApplication
{
    using System.Timers;

    using TicTacToe;
    using TicTacToe.Interfaces;

    public partial class GameForm : Form, Game.IGameView
    {
        const int cellWidth = 32, dist = 2;
        public GameForm()
        {
            InitializeComponent();
        }

        static Game game = new Game();
        /// <summary>
        /// Отобразить панель очков
        /// </summary>
        public void ShowScorePanel()
        {
            ScorePanel.Visible = true;
        }
        /// <summary>
        /// Отобразить очки игроков
        /// </summary>
        /// <param name="score1">очки первого игрока</param>
        /// <param name="score2">щчки второго игрока</param>
        public void ShowScore(int score1, int score2)
        {
            KrestScore.Text = Convert.ToString(score1);
            NullScore.Text = Convert.ToString(score2);
        }
        /// <summary>
        /// Убрать панель очков
        /// </summary>
        public void HideScorePanel()
        {
            ScorePanel.Visible = false;
        }
        /// <summary>
        ///Отобразить панель ходящего игрока 
        /// </summary>
        public void ShowStepPanel()
        {

            if (game._gamers == GameMode.TwoComputers)
            {
                ComputerGamePanel.Left = NullPanel.Left;
                ComputerGamePanel.Top = NullPanel.Top;
                ComputerGamePanel.Visible = true;
            }
            else
            {
                KrestPanel.Left = NullPanel.Left;
                KrestPanel.Top = NullPanel.Top;
                KrestPanel.Visible = true;
            }
        }
        /// <summary>
        /// Сменить картинку на панели
        /// </summary>
        public void ChangeStep()
        {
            //if (game._step == 1) //form1.label22.Text = "Ходят крестики";
            //if (game._step == 1) //form1.label22.Text = "Ходят нолики";
            if (KrestPanel.Visible == true)
            {
                NullPanel.Visible = true;
                KrestPanel.Visible = false;
            }
            else
            {
                KrestPanel.Visible = true;
                NullPanel.Visible = false;
            }
        }
        /// <summary>
        /// Убрать панель ходящего игрока
        /// </summary>
        public void HideStepPanel()
        {
            KrestPanel.Visible = false;
            NullPanel.Visible = false;
            ComputerGamePanel.Visible = false;
            KrestPanel.Left = -200;
        }
        /// <summary>
        /// Подготовить форму к игре
        /// </summary>
        public void PrepareForGame()
        {
            //Загружаем игровой фон формы
            var resources = new ComponentResourceManager(typeof(GameForm));
            this.BackgroundImage = ((Image)(resources.GetObject("White")));
            //Убираем ненужные панели и надписи
            SettingsPanel.Visible = false;
            MenuPanel.Visible = false;
            OptionPanel.Visible = false;
            FirstCaptionLable.Visible = false;
            SecondCaptionLable.Visible = false;
            //Подготовка внешнего вида формы для игры
            ShowStepPanel();
            if (game._rule == 2)
                ShowScorePanel();        
            
            GamePanel.Visible = true;
            MovePanel.Visible = true;
            MessagePanel.Visible = true;
            CancelPanel.Visible = true;
            MessageLabel.Text = "";
            
        }
        /// <summary>
        /// Переход в меню
        /// </summary>
        public void CancelGame()
        {
            //Убираем все ненужные панели после игры
            HideScorePanel();
            HideStepPanel();
            CancelPanel.Visible = false;
            MessagePanel.Visible = false;
            GamePanel.Visible = false;
            MovePanel.Visible = false;
            //Загружаем фоновую картинку
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            //Отображаем панель меню и надписи
            MenuPanel.Visible = true;            
            FirstCaptionLable.Visible = true;
            SecondCaptionLable.Visible = true;
        }

        private void GamePanel_MouseDown(object sender, MouseEventArgs e)
        {
            string Message = "";
            if ((e.Button == MouseButtons.Left)&&(game._gameIsGoing))
            {
                int X = 1 + (e.X - 2 * dist) / cellWidth;
                int Y = 1 + (e.Y - 2 * dist) / cellWidth;
                int Result = game.Go(X,Y,this,ref Message);
                MessageLabel.Text = Message;
                if (game._rule == 2)
                    ShowScore(game.Player1._score,game.Player2._score);
                if (game._gamers == GameMode.TwoPlayers)
                    if (Result!=0)
                        ChangeStep();
            }
        }

        private void MoveUpButton_Click(object sender, EventArgs e)
        {
            game.MoveGameField(0, 1);            
        }

        private void MoveDownButton_Click(object sender, EventArgs e)
        {
            game.MoveGameField(0, -1);           
        }

        private void MoveLeftButton_Click(object sender, EventArgs e)
        {
            game.MoveGameField(1, 0);            
        }

        private void MoveRigthButton_Click(object sender, EventArgs e)
        {
            game.MoveGameField(-1, 0);        
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
        }

        private void CancelProgramButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void MultiGameButton_Click(object sender, EventArgs e)
        {
            game._gamers = GameMode.TwoPlayers;
            PrepareForGame();
            game.Start(this);
        }

        private void SecondGameVariantCheckBox_Click(object sender, EventArgs e)
        {
            FirstGameVariantCheckBox.Checked = false;
            SecondGameVariantCheckBox.Checked = true;
            GameTimeListBox.Enabled = true;
            game._rule = 2;
        }

        private void FirstGameVariantCheckBox_Checked(object sender, EventArgs e)
        {
            SecondGameVariantCheckBox.Checked = false;
            GameTimeListBox.Enabled = false;
            game._rule = 1;
            
        }

        private void TimeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GameTimeListBox.GetSelected(0)) game._maxTime = 60*1000;
            if (GameTimeListBox.GetSelected(1)) game._maxTime = 2*60*1000;
            if (GameTimeListBox.GetSelected(2)) game._maxTime = 3*60*1000;
            if (GameTimeListBox.GetSelected(3)) game._maxTime = 5*60*1000;
            if (GameTimeListBox.GetSelected(4)) game._maxTime = 10*60*1000;
            
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            GameTimer.Stop();
            game.End(this);
            //MenuPanel.Visible = true;
           
        }      

        private void CancelButton_Click(object sender, EventArgs e)
        {
           
            CancelGame();
            game.Cancel();
        }

        private void ComputerGameButton_Click(object sender, EventArgs e)
        {
            game._gamers = GameMode.TwoComputers;
            PrepareForGame();
            game.Start(this);
            game.ComputersGame(this);
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            if (game._paintField == true)
            {
                GamePanel.Left = Convert.ToInt32(this.MessagePanel.Left + (this.MessagePanel.Width / 2) - GamePanel.Width / 2);
                GamePanel.Top = Convert.ToInt32(this.MessagePanel.Top/2 - this.GamePanel.Height/2);
                game.Field.SetFieldWidth(GamePanel.Height);

                
               
            }
        }

        private void SingleGameButton_Click(object sender, EventArgs e)
        {
            PrepareForGame();
            game._gamers = GameMode.OnePlayer;
            game.Start(this);
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.Shift)
            {
                MessageBox.Show("!!!");
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            this.MenuPanel.Location = new System.Drawing.Point((this.Width - this.MenuPanel.Width) / 2,135);
            this.SettingsPanel.Location = new System.Drawing.Point((this.Width - this.SettingsPanel.Width) / 2, (this.Height - this.SettingsPanel.Height) / 2);
            this.OptionPanel.Location = new System.Drawing.Point((this.Width - this.OptionPanel.Width) / 2, (this.Height - this.OptionPanel.Height) / 2);
        }

        private void RoolButton_Click(object sender, EventArgs e)
        {
            OptionPanel.Visible = true;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = false;
        }

        private void CancelOptionButton_Click(object sender, EventArgs e)
        {
            OptionPanel.Visible = false;
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (game._paintField == true)
            {                
                game.Field.SetFieldWidth(GamePanel.Height);
                game.Field.Draw();
            }
        }

        private void OnHomeButtonClick(object sender, EventArgs e)
        {
            if ((game.Field.Origin.X != 0) || (game.Field.Origin.Y != 0))
            {
                game.MoveGameField((int)game.Field.Origin.X, (int)game.Field.Origin.Y);
            }
        }

        public IGraphics CreateGraphics()
        {
            var graphics = this.GamePanel.CreateGraphics();

            return new WinFormsGraphics(graphics);
        }

        public void ShowMessage(string message)
        {
            label1.Text = message;
        }
    }
}
