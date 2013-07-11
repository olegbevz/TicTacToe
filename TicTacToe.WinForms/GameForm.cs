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

namespace GameApplication
{

  
    public partial class GameForm : Form
    {
        const int cellWidth = 32, dist = 2;
        public GameForm()
        {
            InitializeComponent();
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
            game._player1.HideTarget();
            game._player2.HideTarget();
            game._field.Move(0,-1);
            game._player1.MoveTargetXY(0, 1);
            game._player2.MoveTargetXY(0, 1);
            game._player1.DrawTarget();
            game._player2.DrawTarget();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            game._player1.HideTarget();
            game._player2.HideTarget();
            game._field.Move(0, +1);
            game._player1.MoveTargetXY(0, -1);
            game._player2.MoveTargetXY(0, -1);
            game._player1.DrawTarget();
            game._player2.DrawTarget();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            game._player1.HideTarget();
            game._player2.HideTarget();
            game._field.Move(-1, 0);
            game._player1.MoveTargetXY(1,0);
            game._player2.MoveTargetXY(1,0);
            game._player1.DrawTarget();
            game._player2.DrawTarget();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            game._player1.HideTarget();
            game._player2.HideTarget();
            game._field.Move(+1, 0);
            game._player1.MoveTargetXY(-1, 0);
            game._player2.MoveTargetXY(-1, 0);
            game._player1.DrawTarget();
            game._player2.DrawTarget();
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
             OptionPanel.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OptionPanel.Visible = false;
        }

        private void CancelProgramButton_Click(object sender, EventArgs e)
        {
            GameForm.ActiveForm.Close();
        }

        private void MultiGameButton_Click(object sender, EventArgs e)
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
            //MenuPanel.Visible = true;
           
        }      

        private void button4_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = true;
            
            game.Cancel(this);
        }

        private void ComputerGameButton_Click(object sender, EventArgs e)
        {
            OptionPanel.Visible = false;
            MenuPanel.Visible = false;
            game._gamers = 0;
            game.Start(this);
            game.ComputersGame(this);

        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            if (game._bPaintField == true)
            {
                game._field.Show();
            }
        }

        private void SingleGameButton_Click(object sender, EventArgs e)
        {
            OptionPanel.Visible = false;
            MenuPanel.Visible = false;
            game._gamers = 1;
            game.Start(this);
        }

    

       


      
      
        
   

    }
  
}
