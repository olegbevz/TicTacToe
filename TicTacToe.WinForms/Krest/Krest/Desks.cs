using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desks
{
    public class StepDesk
    {
        public void Show(WindowsFormsApplication1.GameForm form1)
        {
            form1.KrestPanel.Left = 507;
            form1.KrestPanel.Top = 135;
            form1.KrestPanel.Visible = true;

        }
        public void ChangeStep(WindowsFormsApplication1.GameForm form1)
        {
            //if (game._step == 1) //form1.label22.Text = "Ходят крестики";
            //if (game._step == 1) //form1.label22.Text = "Ходят нолики";
            if (form1.KrestPanel.Visible == true)
            {
                form1.NullPanel.Visible = true;
                form1.KrestPanel.Visible = false;
            }
            else
            {
                form1.KrestPanel.Visible = true;
                form1.NullPanel.Visible = false;
            }
        }
        public void Hide(WindowsFormsApplication1.GameForm form1)
        {
            form1.KrestPanel.Visible = false;
            form1.NullPanel.Visible = false;
            form1.KrestPanel.Left = -200;
        }
    }
    public class ScoreDesk
    {
        public void Show(WindowsFormsApplication1.GameForm form1)
        {
            form1.ScorePanel.Visible = true;
        }
        public void ShowScore(int score1,int score2,WindowsFormsApplication1.GameForm form1)
        {
            form1.KrestScore.Text = Convert.ToString(score1);
            form1.NullScore.Text = Convert.ToString(score2);
        }
        public void Hide(WindowsFormsApplication1.GameForm form1)
        {
            form1.ScorePanel.Visible = false;
        }
    }
}
