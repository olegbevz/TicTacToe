using GamePanelApplication;
namespace GamePanelApplication
{
    partial class GameForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.FirstCaptionLable = new System.Windows.Forms.Label();
            this.SecondCaptionLable = new System.Windows.Forms.Label();
            this.NullPanel = new System.Windows.Forms.Panel();
            this.NullStepLabel = new System.Windows.Forms.Label();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MovePanel = new System.Windows.Forms.Panel();
            this.GoHomeButton = new System.Windows.Forms.Button();
            this.MoveLeftButton = new System.Windows.Forms.Button();
            this.MoveRigthButton = new System.Windows.Forms.Button();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.NullScore = new System.Windows.Forms.Label();
            this.NullScoreLabel = new System.Windows.Forms.Label();
            this.KrestScore = new System.Windows.Forms.Label();
            this.KrestScoreLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.KrestPanel = new System.Windows.Forms.Panel();
            this.KrestStepLabel = new System.Windows.Forms.Label();
            this.CancelPanel = new System.Windows.Forms.Panel();
            this.CancelGameButton = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ComputerGamePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.OptionButton = new System.Windows.Forms.Button();
            this.ComputerGameButton = new System.Windows.Forms.Button();
            this.CancelProgramButton = new System.Windows.Forms.Button();
            this.RoolButton = new System.Windows.Forms.Button();
            this.MultiGameButton = new System.Windows.Forms.Button();
            this.SingleGameButton = new System.Windows.Forms.Button();
            this.OptionPanel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.RoolTextBox = new System.Windows.Forms.RichTextBox();
            this.CancelOptionButton = new System.Windows.Forms.Button();
            this.RoolsLabel = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.RoolSettingsLabel = new System.Windows.Forms.Label();
            this.SecondGameVariantCheckBox = new System.Windows.Forms.CheckBox();
            this.FirstGameVariantCheckBox = new System.Windows.Forms.CheckBox();
            this.SecondVariantTextBox = new System.Windows.Forms.RichTextBox();
            this.GameTimeListBox = new System.Windows.Forms.ListBox();
            this.FirstVariantTextBox = new System.Windows.Forms.RichTextBox();
            this.TimeSettingsLabel = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.NullPanel.SuspendLayout();
            this.MessagePanel.SuspendLayout();
            this.MovePanel.SuspendLayout();
            this.ScorePanel.SuspendLayout();
            this.KrestPanel.SuspendLayout();
            this.CancelPanel.SuspendLayout();
            this.ComputerGamePanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.OptionPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstCaptionLable
            // 
            this.FirstCaptionLable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstCaptionLable.AutoSize = true;
            this.FirstCaptionLable.BackColor = System.Drawing.SystemColors.Window;
            this.FirstCaptionLable.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstCaptionLable.ForeColor = System.Drawing.Color.Blue;
            this.FirstCaptionLable.Location = new System.Drawing.Point(129, -5);
            this.FirstCaptionLable.Name = "FirstCaptionLable";
            this.FirstCaptionLable.Size = new System.Drawing.Size(379, 47);
            this.FirstCaptionLable.TabIndex = 1;
            this.FirstCaptionLable.Text = "КРЕСТИКИ - НОЛИКИ";
            // 
            // SecondCaptionLable
            // 
            this.SecondCaptionLable.AutoSize = true;
            this.SecondCaptionLable.BackColor = System.Drawing.SystemColors.Window;
            this.SecondCaptionLable.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondCaptionLable.ForeColor = System.Drawing.Color.Red;
            this.SecondCaptionLable.Location = new System.Drawing.Point(393, 42);
            this.SecondCaptionLable.Name = "SecondCaptionLable";
            this.SecondCaptionLable.Size = new System.Drawing.Size(227, 24);
            this.SecondCaptionLable.TabIndex = 2;
            this.SecondCaptionLable.Text = "на неограниченном поле";
            // 
            // NullPanel
            // 
            this.NullPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NullPanel.BackColor = System.Drawing.SystemColors.Window;
            this.NullPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NullPanel.BackgroundImage")));
            this.NullPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NullPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NullPanel.Controls.Add(this.NullStepLabel);
            this.NullPanel.Location = new System.Drawing.Point(509, 135);
            this.NullPanel.Name = "NullPanel";
            this.NullPanel.Size = new System.Drawing.Size(127, 163);
            this.NullPanel.TabIndex = 2;
            this.NullPanel.Visible = false;
            // 
            // NullStepLabel
            // 
            this.NullStepLabel.AutoSize = true;
            this.NullStepLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NullStepLabel.Location = new System.Drawing.Point(-5, -1);
            this.NullStepLabel.Name = "NullStepLabel";
            this.NullStepLabel.Size = new System.Drawing.Size(113, 42);
            this.NullStepLabel.TabIndex = 1;
            this.NullStepLabel.Text = "   Ходят\r\n    \"нолики\".";
            this.NullStepLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MessagePanel
            // 
            this.MessagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagePanel.BackColor = System.Drawing.SystemColors.Window;
            this.MessagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessagePanel.Controls.Add(this.MessageLabel);
            this.MessagePanel.Location = new System.Drawing.Point(77, 444);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(425, 35);
            this.MessagePanel.TabIndex = 8;
            this.MessagePanel.Visible = false;
            // 
            // MessageLabel
            // 
            this.MessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageLabel.Location = new System.Drawing.Point(3, 4);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 23);
            this.MessageLabel.TabIndex = 0;
            // 
            // MovePanel
            // 
            this.MovePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MovePanel.BackColor = System.Drawing.SystemColors.Window;
            this.MovePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MovePanel.Controls.Add(this.GoHomeButton);
            this.MovePanel.Controls.Add(this.MoveLeftButton);
            this.MovePanel.Controls.Add(this.MoveRigthButton);
            this.MovePanel.Controls.Add(this.MoveDownButton);
            this.MovePanel.Controls.Add(this.MoveUpButton);
            this.MovePanel.Location = new System.Drawing.Point(509, 12);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(127, 124);
            this.MovePanel.TabIndex = 9;
            this.MovePanel.Visible = false;
            // 
            // GoHomeButton
            // 
            this.GoHomeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoHomeButton.BackgroundImage")));
            this.GoHomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoHomeButton.Location = new System.Drawing.Point(43, 45);
            this.GoHomeButton.Name = "GoHomeButton";
            this.GoHomeButton.Size = new System.Drawing.Size(39, 30);
            this.GoHomeButton.TabIndex = 11;
            this.GoHomeButton.UseVisualStyleBackColor = true;
            this.GoHomeButton.Click += new System.EventHandler(this.OnHomeButtonClick);
            // 
            // MoveLeftButton
            // 
            this.MoveLeftButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoveLeftButton.BackgroundImage")));
            this.MoveLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveLeftButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MoveLeftButton.Location = new System.Drawing.Point(1, 45);
            this.MoveLeftButton.Name = "MoveLeftButton";
            this.MoveLeftButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MoveLeftButton.Size = new System.Drawing.Size(40, 30);
            this.MoveLeftButton.TabIndex = 10;
            this.MoveLeftButton.UseVisualStyleBackColor = true;
            this.MoveLeftButton.Click += new System.EventHandler(this.MoveLeftButton_Click);
            // 
            // MoveRigthButton
            // 
            this.MoveRigthButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoveRigthButton.BackgroundImage")));
            this.MoveRigthButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveRigthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveRigthButton.Location = new System.Drawing.Point(84, 45);
            this.MoveRigthButton.Name = "MoveRigthButton";
            this.MoveRigthButton.Size = new System.Drawing.Size(40, 30);
            this.MoveRigthButton.TabIndex = 9;
            this.MoveRigthButton.UseVisualStyleBackColor = true;
            this.MoveRigthButton.Click += new System.EventHandler(this.MoveRigthButton_Click);
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoveDownButton.BackgroundImage")));
            this.MoveDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveDownButton.Location = new System.Drawing.Point(45, 81);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(35, 40);
            this.MoveDownButton.TabIndex = 8;
            this.MoveDownButton.UseVisualStyleBackColor = true;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoveUpButton.BackgroundImage")));
            this.MoveUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveUpButton.Location = new System.Drawing.Point(45, 1);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(35, 40);
            this.MoveUpButton.TabIndex = 7;
            this.MoveUpButton.UseVisualStyleBackColor = true;
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // ScorePanel
            // 
            this.ScorePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScorePanel.BackColor = System.Drawing.SystemColors.Window;
            this.ScorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScorePanel.Controls.Add(this.NullScore);
            this.ScorePanel.Controls.Add(this.NullScoreLabel);
            this.ScorePanel.Controls.Add(this.KrestScore);
            this.ScorePanel.Controls.Add(this.KrestScoreLabel);
            this.ScorePanel.Controls.Add(this.ScoreLabel);
            this.ScorePanel.Location = new System.Drawing.Point(509, 297);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(127, 142);
            this.ScorePanel.TabIndex = 2;
            this.ScorePanel.Visible = false;
            // 
            // NullScore
            // 
            this.NullScore.AutoSize = true;
            this.NullScore.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NullScore.Location = new System.Drawing.Point(2, 96);
            this.NullScore.Name = "NullScore";
            this.NullScore.Size = new System.Drawing.Size(0, 21);
            this.NullScore.TabIndex = 4;
            // 
            // NullScoreLabel
            // 
            this.NullScoreLabel.AutoSize = true;
            this.NullScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NullScoreLabel.Location = new System.Drawing.Point(-3, 75);
            this.NullScoreLabel.Name = "NullScoreLabel";
            this.NullScoreLabel.Size = new System.Drawing.Size(103, 21);
            this.NullScoreLabel.TabIndex = 3;
            this.NullScoreLabel.Text = " \"Нолики\" :";
            // 
            // KrestScore
            // 
            this.KrestScore.AutoSize = true;
            this.KrestScore.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KrestScore.Location = new System.Drawing.Point(2, 53);
            this.KrestScore.Name = "KrestScore";
            this.KrestScore.Size = new System.Drawing.Size(0, 21);
            this.KrestScore.TabIndex = 2;
            // 
            // KrestScoreLabel
            // 
            this.KrestScoreLabel.AutoSize = true;
            this.KrestScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KrestScoreLabel.Location = new System.Drawing.Point(-3, 32);
            this.KrestScoreLabel.Name = "KrestScoreLabel";
            this.KrestScoreLabel.Size = new System.Drawing.Size(113, 21);
            this.KrestScoreLabel.TabIndex = 1;
            this.KrestScoreLabel.Text = " \"Крестики\" :";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(-3, 4);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(138, 21);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Набранные очки ";
            // 
            // KrestPanel
            // 
            this.KrestPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KrestPanel.BackColor = System.Drawing.SystemColors.Window;
            this.KrestPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KrestPanel.BackgroundImage")));
            this.KrestPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.KrestPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KrestPanel.Controls.Add(this.KrestStepLabel);
            this.KrestPanel.Location = new System.Drawing.Point(1, 231);
            this.KrestPanel.Name = "KrestPanel";
            this.KrestPanel.Size = new System.Drawing.Size(127, 163);
            this.KrestPanel.TabIndex = 12;
            this.KrestPanel.Visible = false;
            // 
            // KrestStepLabel
            // 
            this.KrestStepLabel.AllowDrop = true;
            this.KrestStepLabel.AutoSize = true;
            this.KrestStepLabel.BackColor = System.Drawing.SystemColors.Window;
            this.KrestStepLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KrestStepLabel.Location = new System.Drawing.Point(-12, -1);
            this.KrestStepLabel.Name = "KrestStepLabel";
            this.KrestStepLabel.Size = new System.Drawing.Size(131, 42);
            this.KrestStepLabel.TabIndex = 1;
            this.KrestStepLabel.Text = "       Ходят \r\n     \"крестики\".";
            // 
            // CancelPanel
            // 
            this.CancelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelPanel.BackColor = System.Drawing.SystemColors.Window;
            this.CancelPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CancelPanel.Controls.Add(this.CancelGameButton);
            this.CancelPanel.Location = new System.Drawing.Point(509, 444);
            this.CancelPanel.Name = "CancelPanel";
            this.CancelPanel.Size = new System.Drawing.Size(127, 34);
            this.CancelPanel.TabIndex = 24;
            this.CancelPanel.Visible = false;
            // 
            // CancelGameButton
            // 
            this.CancelGameButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelGameButton.Location = new System.Drawing.Point(4, 4);
            this.CancelGameButton.Name = "CancelGameButton";
            this.CancelGameButton.Size = new System.Drawing.Size(116, 23);
            this.CancelGameButton.TabIndex = 0;
            this.CancelGameButton.Text = "Выход в меню";
            this.CancelGameButton.UseVisualStyleBackColor = true;
            this.CancelGameButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // ComputerGamePanel
            // 
            this.ComputerGamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComputerGamePanel.BackColor = System.Drawing.SystemColors.Window;
            this.ComputerGamePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComputerGamePanel.BackgroundImage")));
            this.ComputerGamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComputerGamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComputerGamePanel.Controls.Add(this.label1);
            this.ComputerGamePanel.Location = new System.Drawing.Point(7, 18);
            this.ComputerGamePanel.Name = "ComputerGamePanel";
            this.ComputerGamePanel.Size = new System.Drawing.Size(127, 163);
            this.ComputerGamePanel.TabIndex = 27;
            this.ComputerGamePanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-9, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "       Игра \r\n   компьютеров";
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MenuPanel.AutoScroll = true;
            this.MenuPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.OptionButton);
            this.MenuPanel.Controls.Add(this.ComputerGameButton);
            this.MenuPanel.Controls.Add(this.CancelProgramButton);
            this.MenuPanel.Controls.Add(this.RoolButton);
            this.MenuPanel.Controls.Add(this.MultiGameButton);
            this.MenuPanel.Controls.Add(this.SingleGameButton);
            this.MenuPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MenuPanel.Location = new System.Drawing.Point(-3, 484);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(209, 226);
            this.MenuPanel.TabIndex = 29;
            // 
            // OptionButton
            // 
            this.OptionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OptionButton.AutoSize = true;
            this.OptionButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.OptionButton.Location = new System.Drawing.Point(22, 140);
            this.OptionButton.Name = "OptionButton";
            this.OptionButton.Size = new System.Drawing.Size(163, 30);
            this.OptionButton.TabIndex = 6;
            this.OptionButton.Text = "Управление";
            this.OptionButton.UseVisualStyleBackColor = true;
            this.OptionButton.Click += new System.EventHandler(this.OptionButton_Click);
            // 
            // ComputerGameButton
            // 
            this.ComputerGameButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComputerGameButton.AutoSize = true;
            this.ComputerGameButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComputerGameButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComputerGameButton.Location = new System.Drawing.Point(22, 66);
            this.ComputerGameButton.Name = "ComputerGameButton";
            this.ComputerGameButton.Size = new System.Drawing.Size(163, 29);
            this.ComputerGameButton.TabIndex = 5;
            this.ComputerGameButton.Text = "Два компьютера";
            this.ComputerGameButton.UseVisualStyleBackColor = true;
            this.ComputerGameButton.Click += new System.EventHandler(this.ComputerGameButton_Click);
            // 
            // CancelProgramButton
            // 
            this.CancelProgramButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelProgramButton.AutoSize = true;
            this.CancelProgramButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.CancelProgramButton.Location = new System.Drawing.Point(22, 184);
            this.CancelProgramButton.Name = "CancelProgramButton";
            this.CancelProgramButton.Size = new System.Drawing.Size(163, 29);
            this.CancelProgramButton.TabIndex = 4;
            this.CancelProgramButton.Text = "Выход";
            this.CancelProgramButton.UseVisualStyleBackColor = true;
            this.CancelProgramButton.Click += new System.EventHandler(this.CancelProgramButton_Click);
            // 
            // RoolButton
            // 
            this.RoolButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RoolButton.AutoSize = true;
            this.RoolButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.RoolButton.Location = new System.Drawing.Point(22, 110);
            this.RoolButton.Name = "RoolButton";
            this.RoolButton.Size = new System.Drawing.Size(163, 29);
            this.RoolButton.TabIndex = 2;
            this.RoolButton.Text = "Правила игры";
            this.RoolButton.UseVisualStyleBackColor = true;
            this.RoolButton.Click += new System.EventHandler(this.RoolButton_Click);
            // 
            // MultiGameButton
            // 
            this.MultiGameButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MultiGameButton.AutoSize = true;
            this.MultiGameButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiGameButton.Location = new System.Drawing.Point(21, 36);
            this.MultiGameButton.Name = "MultiGameButton";
            this.MultiGameButton.Size = new System.Drawing.Size(163, 29);
            this.MultiGameButton.TabIndex = 1;
            this.MultiGameButton.Text = "Два игрока";
            this.MultiGameButton.UseVisualStyleBackColor = true;
            this.MultiGameButton.Click += new System.EventHandler(this.MultiGameButton_Click);
            // 
            // SingleGameButton
            // 
            this.SingleGameButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SingleGameButton.AutoSize = true;
            this.SingleGameButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingleGameButton.Location = new System.Drawing.Point(21, 6);
            this.SingleGameButton.Name = "SingleGameButton";
            this.SingleGameButton.Size = new System.Drawing.Size(163, 29);
            this.SingleGameButton.TabIndex = 0;
            this.SingleGameButton.Text = "Одиночная игра";
            this.SingleGameButton.UseVisualStyleBackColor = true;
            this.SingleGameButton.Click += new System.EventHandler(this.SingleGameButton_Click);
            // 
            // OptionPanel
            // 
            this.OptionPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.OptionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.OptionPanel.BackColor = System.Drawing.SystemColors.Window;
            this.OptionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionPanel.Controls.Add(this.richTextBox1);
            this.OptionPanel.Controls.Add(this.richTextBox2);
            this.OptionPanel.Controls.Add(this.RoolTextBox);
            this.OptionPanel.Controls.Add(this.CancelOptionButton);
            this.OptionPanel.Controls.Add(this.RoolsLabel);
            this.OptionPanel.Location = new System.Drawing.Point(598, 479);
            this.OptionPanel.Name = "OptionPanel";
            this.OptionPanel.Size = new System.Drawing.Size(450, 278);
            this.OptionPanel.TabIndex = 32;
            this.OptionPanel.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(40, 129);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(396, 54);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "Вариант№2. Выигрывает игрок, набравший большее колличество очков за определенное " +
                "время. За составленные в ряд 2 крестика (нолика) игрок получает 2 очка, за 3 кре" +
                "стика (нолика) - 3 очка и так далее.";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(40, 97);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(409, 42);
            this.richTextBox2.TabIndex = 25;
            this.richTextBox2.Text = "Вариант№1. Выигрывает игрок, первый составивший в ряд пять крестиков (или ноликов" +
                ").";
            // 
            // RoolTextBox
            // 
            this.RoolTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.RoolTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoolTextBox.Location = new System.Drawing.Point(16, 46);
            this.RoolTextBox.Name = "RoolTextBox";
            this.RoolTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.RoolTextBox.Size = new System.Drawing.Size(440, 39);
            this.RoolTextBox.TabIndex = 25;
            this.RoolTextBox.Text = "Правила игры достаточно просты.Каждый игрок по очереди ставит крестик или нолик н" +
                "а неограниченном поле, состоящем из клеток.\nУсловия победы:";
            // 
            // CancelOptionButton
            // 
            this.CancelOptionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelOptionButton.Location = new System.Drawing.Point(178, 243);
            this.CancelOptionButton.Name = "CancelOptionButton";
            this.CancelOptionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelOptionButton.TabIndex = 9;
            this.CancelOptionButton.Text = "Готово";
            this.CancelOptionButton.UseVisualStyleBackColor = true;
            this.CancelOptionButton.Click += new System.EventHandler(this.CancelOptionButton_Click);
            // 
            // RoolsLabel
            // 
            this.RoolsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RoolsLabel.AutoSize = true;
            this.RoolsLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoolsLabel.Location = new System.Drawing.Point(135, 15);
            this.RoolsLabel.Name = "RoolsLabel";
            this.RoolsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RoolsLabel.Size = new System.Drawing.Size(152, 28);
            this.RoolsLabel.TabIndex = 0;
            this.RoolsLabel.Text = "Правила игры";
            // 
            // GamePanel
            // 
            this.GamePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GamePanel.BackColor = System.Drawing.SystemColors.Window;
            this.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GamePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.GamePanel.Location = new System.Drawing.Point(77, 12);
            this.GamePanel.MaximumSize = new System.Drawing.Size(423, 423);
            this.GamePanel.MinimumSize = new System.Drawing.Size(423, 423);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(423, 423);
            this.GamePanel.TabIndex = 28;
            this.GamePanel.Visible = false;
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.GamePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GamePanel_MouseDown);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SettingsPanel.BackColor = System.Drawing.SystemColors.Window;
            this.SettingsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SettingsPanel.Controls.Add(this.RoolSettingsLabel);
            this.SettingsPanel.Controls.Add(this.SecondGameVariantCheckBox);
            this.SettingsPanel.Controls.Add(this.FirstGameVariantCheckBox);
            this.SettingsPanel.Controls.Add(this.SecondVariantTextBox);
            this.SettingsPanel.Controls.Add(this.GameTimeListBox);
            this.SettingsPanel.Controls.Add(this.FirstVariantTextBox);
            this.SettingsPanel.Controls.Add(this.TimeSettingsLabel);
            this.SettingsPanel.Controls.Add(this.SettingsButton);
            this.SettingsPanel.Controls.Add(this.SettingsLabel);
            this.SettingsPanel.Location = new System.Drawing.Point(217, 479);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(450, 314);
            this.SettingsPanel.TabIndex = 30;
            this.SettingsPanel.Visible = false;
            // 
            // RoolSettingsLabel
            // 
            this.RoolSettingsLabel.AutoSize = true;
            this.RoolSettingsLabel.Location = new System.Drawing.Point(37, 70);
            this.RoolSettingsLabel.Name = "RoolSettingsLabel";
            this.RoolSettingsLabel.Size = new System.Drawing.Size(82, 13);
            this.RoolSettingsLabel.TabIndex = 28;
            this.RoolSettingsLabel.Text = "Правила игры:";
            // 
            // SecondGameVariantCheckBox
            // 
            this.SecondGameVariantCheckBox.AutoSize = true;
            this.SecondGameVariantCheckBox.Location = new System.Drawing.Point(19, 129);
            this.SecondGameVariantCheckBox.Name = "SecondGameVariantCheckBox";
            this.SecondGameVariantCheckBox.Size = new System.Drawing.Size(15, 14);
            this.SecondGameVariantCheckBox.TabIndex = 27;
            this.SecondGameVariantCheckBox.UseVisualStyleBackColor = true;
            this.SecondGameVariantCheckBox.Click += new System.EventHandler(this.SecondGameVariantCheckBox_Click);
            // 
            // FirstGameVariantCheckBox
            // 
            this.FirstGameVariantCheckBox.AutoSize = true;
            this.FirstGameVariantCheckBox.Checked = true;
            this.FirstGameVariantCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FirstGameVariantCheckBox.Location = new System.Drawing.Point(19, 97);
            this.FirstGameVariantCheckBox.Name = "FirstGameVariantCheckBox";
            this.FirstGameVariantCheckBox.Size = new System.Drawing.Size(15, 14);
            this.FirstGameVariantCheckBox.TabIndex = 26;
            this.FirstGameVariantCheckBox.UseVisualStyleBackColor = true;
            this.FirstGameVariantCheckBox.Click += new System.EventHandler(this.FirstGameVariantCheckBox_Checked);
            // 
            // SecondVariantTextBox
            // 
            this.SecondVariantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondVariantTextBox.Location = new System.Drawing.Point(40, 129);
            this.SecondVariantTextBox.Name = "SecondVariantTextBox";
            this.SecondVariantTextBox.Size = new System.Drawing.Size(396, 54);
            this.SecondVariantTextBox.TabIndex = 25;
            this.SecondVariantTextBox.Text = "Вариант№2. Выигрывает игрок, набравший большее колличество очков за определенное " +
                "время. За составленные в ряд 2 крестика (нолика) игрок получает 2 очка, за 3 кре" +
                "стика (нолика) - 3 очка и так далее.";
            // 
            // GameTimeListBox
            // 
            this.GameTimeListBox.Enabled = false;
            this.GameTimeListBox.FormattingEnabled = true;
            this.GameTimeListBox.Items.AddRange(new object[] {
            "1 минута",
            "2 минуты",
            "3 минуты",
            "5 минут",
            "10 минут"});
            this.GameTimeListBox.Location = new System.Drawing.Point(40, 211);
            this.GameTimeListBox.Name = "GameTimeListBox";
            this.GameTimeListBox.Size = new System.Drawing.Size(120, 30);
            this.GameTimeListBox.TabIndex = 21;
            this.GameTimeListBox.SelectedIndexChanged += new System.EventHandler(this.TimeListBox_SelectedIndexChanged);
            // 
            // FirstVariantTextBox
            // 
            this.FirstVariantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstVariantTextBox.Location = new System.Drawing.Point(40, 97);
            this.FirstVariantTextBox.Name = "FirstVariantTextBox";
            this.FirstVariantTextBox.Size = new System.Drawing.Size(409, 42);
            this.FirstVariantTextBox.TabIndex = 25;
            this.FirstVariantTextBox.Text = "Вариант№1. Выигрывает игрок, первый составивший в ряд пять крестиков (или ноликов" +
                ").";
            // 
            // TimeSettingsLabel
            // 
            this.TimeSettingsLabel.AutoSize = true;
            this.TimeSettingsLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeSettingsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TimeSettingsLabel.Location = new System.Drawing.Point(40, 188);
            this.TimeSettingsLabel.Name = "TimeSettingsLabel";
            this.TimeSettingsLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TimeSettingsLabel.Size = new System.Drawing.Size(70, 15);
            this.TimeSettingsLabel.TabIndex = 19;
            this.TimeSettingsLabel.Text = "Время игры";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SettingsButton.Location = new System.Drawing.Point(186, 282);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 9;
            this.SettingsButton.Text = "Готово";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsLabel.Location = new System.Drawing.Point(135, 15);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SettingsLabel.Size = new System.Drawing.Size(170, 28);
            this.SettingsLabel.TabIndex = 0;
            this.SettingsLabel.Text = "Настройки игры";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 487);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.OptionPanel);
            this.Controls.Add(this.ComputerGamePanel);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.CancelPanel);
            this.Controls.Add(this.KrestPanel);
            this.Controls.Add(this.MessagePanel);
            this.Controls.Add(this.NullPanel);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.FirstCaptionLable);
            this.Controls.Add(this.SecondCaptionLable);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.MenuPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(656, 525);
            this.Name = "GameForm";
            this.Text = "Крестики - Нолики";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GamePanel_MouseDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.NullPanel.ResumeLayout(false);
            this.NullPanel.PerformLayout();
            this.MessagePanel.ResumeLayout(false);
            this.MessagePanel.PerformLayout();
            this.MovePanel.ResumeLayout(false);
            this.ScorePanel.ResumeLayout(false);
            this.ScorePanel.PerformLayout();
            this.KrestPanel.ResumeLayout(false);
            this.KrestPanel.PerformLayout();
            this.CancelPanel.ResumeLayout(false);
            this.ComputerGamePanel.ResumeLayout(false);
            this.ComputerGamePanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.OptionPanel.ResumeLayout(false);
            this.OptionPanel.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label FirstCaptionLable;
        public System.Windows.Forms.Label SecondCaptionLable;
        public System.Windows.Forms.Panel NullPanel;
        private System.Windows.Forms.Label NullStepLabel;
        public System.Windows.Forms.Panel MessagePanel;
        public System.Windows.Forms.Label MessageLabel;
        public System.Windows.Forms.Panel MovePanel;
        private System.Windows.Forms.Button MoveLeftButton;
        private System.Windows.Forms.Button MoveRigthButton;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Button MoveUpButton;
        public System.Windows.Forms.Timer GameTimer;
        public System.Windows.Forms.Panel ScorePanel;
        public System.Windows.Forms.Label NullScore;
        private System.Windows.Forms.Label NullScoreLabel;
        public System.Windows.Forms.Label KrestScore;
        private System.Windows.Forms.Label KrestScoreLabel;
        private System.Windows.Forms.Label ScoreLabel;
        public System.Windows.Forms.Panel KrestPanel;
        private System.Windows.Forms.Label KrestStepLabel;
        public System.Windows.Forms.Panel CancelPanel;
        private System.Windows.Forms.Button CancelGameButton;
        public System.Windows.Forms.Timer GameTimer1;
        public System.Windows.Forms.Panel ComputerGamePanel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label RoolSettingsLabel;
        private System.Windows.Forms.CheckBox SecondGameVariantCheckBox;
        private System.Windows.Forms.CheckBox FirstGameVariantCheckBox;
        private System.Windows.Forms.RichTextBox SecondVariantTextBox;
        private System.Windows.Forms.ListBox GameTimeListBox;
        private System.Windows.Forms.RichTextBox FirstVariantTextBox;
        private System.Windows.Forms.Label TimeSettingsLabel;
        private System.Windows.Forms.Button SettingsButton;
        public System.Windows.Forms.Label SettingsLabel;
       // public CGamePanel GamePanel;
        public System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button OptionButton;
        private System.Windows.Forms.Button ComputerGameButton;
        private System.Windows.Forms.Button CancelProgramButton;
        private System.Windows.Forms.Button RoolButton;
        private System.Windows.Forms.Button MultiGameButton;
        private System.Windows.Forms.Button SingleGameButton;
        public System.Windows.Forms.Panel OptionPanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox RoolTextBox;
        private System.Windows.Forms.Button CancelOptionButton;
        public System.Windows.Forms.Label RoolsLabel;
        private System.Windows.Forms.Button GoHomeButton;
        //public CGamePanel GamePanel;

    }
}

