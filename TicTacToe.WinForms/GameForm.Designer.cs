namespace GameApplication
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
            this.GamePanel = new System.Windows.Forms.Panel();
            this.FirstCaptionLable = new System.Windows.Forms.Label();
            this.SecondCaptionLable = new System.Windows.Forms.Label();
            this.OptionPanel = new System.Windows.Forms.Panel();
            this.OptionTextBox = new System.Windows.Forms.RichTextBox();
            this.SecondVariantTextBox = new System.Windows.Forms.RichTextBox();
            this.FirstVariantTextBox = new System.Windows.Forms.RichTextBox();
            this.RoolTextBox = new System.Windows.Forms.RichTextBox();
            this.GameTimeListBox = new System.Windows.Forms.ListBox();
            this.GameTimeLabel = new System.Windows.Forms.Label();
            this.SecondGameVarianCheckBox = new System.Windows.Forms.CheckBox();
            this.FirstGameVariantCheckBox = new System.Windows.Forms.CheckBox();
            this.OptionLabel = new System.Windows.Forms.Label();
            this.CancelOptionButton = new System.Windows.Forms.Button();
            this.RoolsLabel = new System.Windows.Forms.Label();
            this.NullPanel = new System.Windows.Forms.Panel();
            this.NullStepLabel = new System.Windows.Forms.Label();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MovePanel = new System.Windows.Forms.Panel();
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ComputerGameButton = new System.Windows.Forms.Button();
            this.CancelProgramButton = new System.Windows.Forms.Button();
            this.OptionButton = new System.Windows.Forms.Button();
            this.MultiGameButton = new System.Windows.Forms.Button();
            this.SingleGameButton = new System.Windows.Forms.Button();
            this.GameTimer1 = new System.Windows.Forms.Timer(this.components);
            this.OptionPanel.SuspendLayout();
            this.NullPanel.SuspendLayout();
            this.MessagePanel.SuspendLayout();
            this.MovePanel.SuspendLayout();
            this.ScorePanel.SuspendLayout();
            this.KrestPanel.SuspendLayout();
            this.CancelPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.SystemColors.Window;
            this.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GamePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.GamePanel.Location = new System.Drawing.Point(77, 12);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(423, 423);
            this.GamePanel.TabIndex = 4;
            this.GamePanel.Visible = false;
            this.GamePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // FirstCaptionLable
            // 
            this.FirstCaptionLable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstCaptionLable.AutoSize = true;
            this.FirstCaptionLable.BackColor = System.Drawing.SystemColors.Window;
            this.FirstCaptionLable.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstCaptionLable.ForeColor = System.Drawing.Color.Blue;
            this.FirstCaptionLable.Location = new System.Drawing.Point(128, -5);
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
            // OptionPanel
            // 
            this.OptionPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.OptionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.OptionPanel.BackColor = System.Drawing.SystemColors.Window;
            this.OptionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionPanel.Controls.Add(this.OptionTextBox);
            this.OptionPanel.Controls.Add(this.SecondVariantTextBox);
            this.OptionPanel.Controls.Add(this.FirstVariantTextBox);
            this.OptionPanel.Controls.Add(this.RoolTextBox);
            this.OptionPanel.Controls.Add(this.GameTimeListBox);
            this.OptionPanel.Controls.Add(this.GameTimeLabel);
            this.OptionPanel.Controls.Add(this.SecondGameVarianCheckBox);
            this.OptionPanel.Controls.Add(this.FirstGameVariantCheckBox);
            this.OptionPanel.Controls.Add(this.OptionLabel);
            this.OptionPanel.Controls.Add(this.CancelOptionButton);
            this.OptionPanel.Controls.Add(this.RoolsLabel);
            this.OptionPanel.Location = new System.Drawing.Point(85, 47);
            this.OptionPanel.Name = "OptionPanel";
            this.OptionPanel.Size = new System.Drawing.Size(450, 382);
            this.OptionPanel.TabIndex = 7;
            this.OptionPanel.Visible = false;
            // 
            // OptionTextBox
            // 
            this.OptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionTextBox.Location = new System.Drawing.Point(16, 263);
            this.OptionTextBox.Name = "OptionTextBox";
            this.OptionTextBox.Size = new System.Drawing.Size(420, 70);
            this.OptionTextBox.TabIndex = 26;
            this.OptionTextBox.Text = resources.GetString("OptionTextBox.Text");
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
            // RoolTextBox
            // 
            this.RoolTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.RoolTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoolTextBox.Location = new System.Drawing.Point(16, 46);
            this.RoolTextBox.Name = "RoolTextBox";
            this.RoolTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.RoolTextBox.Size = new System.Drawing.Size(440, 43);
            this.RoolTextBox.TabIndex = 25;
            this.RoolTextBox.Text = "Правила игры достаточно просты.Каждый игрок по очереди ставит крестик или нолик н" +
                "а неограниченном поле, состоящем из клеток.\nУсловия победы:";
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
            this.GameTimeListBox.Location = new System.Drawing.Point(117, 194);
            this.GameTimeListBox.Name = "GameTimeListBox";
            this.GameTimeListBox.Size = new System.Drawing.Size(120, 30);
            this.GameTimeListBox.TabIndex = 21;
            this.GameTimeListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // GameTimeLabel
            // 
            this.GameTimeLabel.AutoSize = true;
            this.GameTimeLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameTimeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GameTimeLabel.Location = new System.Drawing.Point(32, 197);
            this.GameTimeLabel.Name = "GameTimeLabel";
            this.GameTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GameTimeLabel.Size = new System.Drawing.Size(70, 15);
            this.GameTimeLabel.TabIndex = 19;
            this.GameTimeLabel.Text = "Время игры";
            // 
            // SecondGameVarianCheckBox
            // 
            this.SecondGameVarianCheckBox.AutoSize = true;
            this.SecondGameVarianCheckBox.Location = new System.Drawing.Point(19, 132);
            this.SecondGameVarianCheckBox.Name = "SecondGameVarianCheckBox";
            this.SecondGameVarianCheckBox.Size = new System.Drawing.Size(15, 14);
            this.SecondGameVarianCheckBox.TabIndex = 18;
            this.SecondGameVarianCheckBox.UseVisualStyleBackColor = true;
            this.SecondGameVarianCheckBox.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // FirstGameVariantCheckBox
            // 
            this.FirstGameVariantCheckBox.AutoSize = true;
            this.FirstGameVariantCheckBox.Checked = true;
            this.FirstGameVariantCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FirstGameVariantCheckBox.Location = new System.Drawing.Point(19, 100);
            this.FirstGameVariantCheckBox.Name = "FirstGameVariantCheckBox";
            this.FirstGameVariantCheckBox.Size = new System.Drawing.Size(15, 14);
            this.FirstGameVariantCheckBox.TabIndex = 17;
            this.FirstGameVariantCheckBox.UseVisualStyleBackColor = true;
            this.FirstGameVariantCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // OptionLabel
            // 
            this.OptionLabel.AutoSize = true;
            this.OptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OptionLabel.Location = new System.Drawing.Point(152, 224);
            this.OptionLabel.Name = "OptionLabel";
            this.OptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OptionLabel.Size = new System.Drawing.Size(128, 28);
            this.OptionLabel.TabIndex = 10;
            this.OptionLabel.Text = "Управление";
            // 
            // CancelOptionButton
            // 
            this.CancelOptionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelOptionButton.Location = new System.Drawing.Point(188, 339);
            this.CancelOptionButton.Name = "CancelOptionButton";
            this.CancelOptionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelOptionButton.TabIndex = 9;
            this.CancelOptionButton.Text = "Готово";
            this.CancelOptionButton.UseVisualStyleBackColor = true;
            this.CancelOptionButton.Click += new System.EventHandler(this.button10_Click);
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
            // NullPanel
            // 
            this.NullPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NullPanel.BackColor = System.Drawing.SystemColors.Window;
            this.NullPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NullPanel.BackgroundImage")));
            this.NullPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NullPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NullPanel.Controls.Add(this.NullStepLabel);
            this.NullPanel.Location = new System.Drawing.Point(507, 135);
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
            this.MessagePanel.Location = new System.Drawing.Point(77, 441);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(423, 35);
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
            this.MovePanel.Controls.Add(this.MoveLeftButton);
            this.MovePanel.Controls.Add(this.MoveRigthButton);
            this.MovePanel.Controls.Add(this.MoveDownButton);
            this.MovePanel.Controls.Add(this.MoveUpButton);
            this.MovePanel.Location = new System.Drawing.Point(507, 12);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(127, 124);
            this.MovePanel.TabIndex = 9;
            this.MovePanel.Visible = false;
            // 
            // MoveLeftButton
            // 
            this.MoveLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveLeftButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MoveLeftButton.Location = new System.Drawing.Point(-1, 47);
            this.MoveLeftButton.Name = "MoveLeftButton";
            this.MoveLeftButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MoveLeftButton.Size = new System.Drawing.Size(50, 30);
            this.MoveLeftButton.TabIndex = 10;
            this.MoveLeftButton.Text = "<";
            this.MoveLeftButton.UseVisualStyleBackColor = true;
            this.MoveLeftButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // MoveRigthButton
            // 
            this.MoveRigthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveRigthButton.Location = new System.Drawing.Point(77, 47);
            this.MoveRigthButton.Name = "MoveRigthButton";
            this.MoveRigthButton.Size = new System.Drawing.Size(50, 30);
            this.MoveRigthButton.TabIndex = 9;
            this.MoveRigthButton.Text = ">";
            this.MoveRigthButton.UseVisualStyleBackColor = true;
            this.MoveRigthButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveDownButton.Location = new System.Drawing.Point(45, 77);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(35, 45);
            this.MoveDownButton.TabIndex = 8;
            this.MoveDownButton.Text = "v";
            this.MoveDownButton.UseVisualStyleBackColor = true;
            this.MoveDownButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveUpButton.Location = new System.Drawing.Point(45, 3);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(35, 45);
            this.MoveUpButton.TabIndex = 7;
            this.MoveUpButton.Text = "^";
            this.MoveUpButton.UseVisualStyleBackColor = true;
            this.MoveUpButton.Click += new System.EventHandler(this.button6_Click);
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
            this.ScorePanel.Location = new System.Drawing.Point(507, 297);
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
            this.KrestPanel.Location = new System.Drawing.Point(12, 231);
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
            this.CancelPanel.Location = new System.Drawing.Point(507, 441);
            this.CancelPanel.Name = "CancelPanel";
            this.CancelPanel.Size = new System.Drawing.Size(127, 34);
            this.CancelPanel.TabIndex = 24;
            this.CancelPanel.Visible = false;
            // 
            // CancelGameButton
            // 
            this.CancelGameButton.Location = new System.Drawing.Point(4, 4);
            this.CancelGameButton.Name = "CancelGameButton";
            this.CancelGameButton.Size = new System.Drawing.Size(116, 23);
            this.CancelGameButton.TabIndex = 0;
            this.CancelGameButton.Text = "Выход в меню";
            this.CancelGameButton.UseVisualStyleBackColor = true;
            this.CancelGameButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MenuPanel.AutoScroll = true;
            this.MenuPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.ComputerGameButton);
            this.MenuPanel.Controls.Add(this.CancelProgramButton);
            this.MenuPanel.Controls.Add(this.OptionButton);
            this.MenuPanel.Controls.Add(this.MultiGameButton);
            this.MenuPanel.Controls.Add(this.SingleGameButton);
            this.MenuPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MenuPanel.Location = new System.Drawing.Point(209, 130);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(209, 196);
            this.MenuPanel.TabIndex = 25;
            // 
            // ComputerGameButton
            // 
            this.ComputerGameButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComputerGameButton.AutoSize = true;
            this.ComputerGameButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComputerGameButton.Location = new System.Drawing.Point(22, 62);
            this.ComputerGameButton.Name = "ComputerGameButton";
            this.ComputerGameButton.Size = new System.Drawing.Size(163, 23);
            this.ComputerGameButton.TabIndex = 5;
            this.ComputerGameButton.Text = "Два компьютера";
            this.ComputerGameButton.UseVisualStyleBackColor = true;
            this.ComputerGameButton.Click += new System.EventHandler(this.ComputerGameButton_Click);
            // 
            // CancelProgramButton
            // 
            this.CancelProgramButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelProgramButton.AutoSize = true;
            this.CancelProgramButton.Location = new System.Drawing.Point(22, 160);
            this.CancelProgramButton.Name = "CancelProgramButton";
            this.CancelProgramButton.Size = new System.Drawing.Size(163, 23);
            this.CancelProgramButton.TabIndex = 4;
            this.CancelProgramButton.Text = "Выход";
            this.CancelProgramButton.UseVisualStyleBackColor = true;
            this.CancelProgramButton.Click += new System.EventHandler(this.CancelProgramButton_Click);
            // 
            // OptionButton
            // 
            this.OptionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OptionButton.AutoSize = true;
            this.OptionButton.Location = new System.Drawing.Point(22, 100);
            this.OptionButton.Name = "OptionButton";
            this.OptionButton.Size = new System.Drawing.Size(163, 50);
            this.OptionButton.TabIndex = 2;
            this.OptionButton.Text = "Правила игры и Управление";
            this.OptionButton.UseVisualStyleBackColor = true;
            this.OptionButton.Click += new System.EventHandler(this.OptionButton_Click);
            // 
            // MultiGameButton
            // 
            this.MultiGameButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MultiGameButton.AutoSize = true;
            this.MultiGameButton.Location = new System.Drawing.Point(21, 34);
            this.MultiGameButton.Name = "MultiGameButton";
            this.MultiGameButton.Size = new System.Drawing.Size(163, 23);
            this.MultiGameButton.TabIndex = 1;
            this.MultiGameButton.Text = "Два игрока";
            this.MultiGameButton.UseVisualStyleBackColor = true;
            this.MultiGameButton.Click += new System.EventHandler(this.MultiGameButton_Click);
            // 
            // SingleGameButton
            // 
            this.SingleGameButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SingleGameButton.AutoSize = true;
            this.SingleGameButton.Location = new System.Drawing.Point(21, 7);
            this.SingleGameButton.Name = "SingleGameButton";
            this.SingleGameButton.Size = new System.Drawing.Size(163, 23);
            this.SingleGameButton.TabIndex = 0;
            this.SingleGameButton.Text = "Одиночная игра";
            this.SingleGameButton.UseVisualStyleBackColor = true;
            this.SingleGameButton.Click += new System.EventHandler(this.SingleGameButton_Click);
            // 
            // GameTimer1
            // 
            this.GameTimer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 484);
            this.Controls.Add(this.OptionPanel);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.CancelPanel);
            this.Controls.Add(this.KrestPanel);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.MessagePanel);
            this.Controls.Add(this.NullPanel);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.FirstCaptionLable);
            this.Controls.Add(this.SecondCaptionLable);
            this.Controls.Add(this.MenuPanel);
            this.DoubleBuffered = true;
            this.Name = "GameForm";
            this.Text = "Крестики - Нолики";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.OptionPanel.ResumeLayout(false);
            this.OptionPanel.PerformLayout();
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
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel GamePanel;
        public System.Windows.Forms.Label FirstCaptionLable;
        public System.Windows.Forms.Label SecondCaptionLable;
        public System.Windows.Forms.Label RoolsLabel;
        public System.Windows.Forms.Panel OptionPanel;
        private System.Windows.Forms.Button CancelOptionButton;
        private System.Windows.Forms.Label OptionLabel;
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
        private System.Windows.Forms.CheckBox SecondGameVarianCheckBox;
        private System.Windows.Forms.CheckBox FirstGameVariantCheckBox;
        private System.Windows.Forms.Label GameTimeLabel;
        private System.Windows.Forms.ListBox GameTimeListBox;
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
        private System.Windows.Forms.RichTextBox RoolTextBox;
        private System.Windows.Forms.RichTextBox FirstVariantTextBox;
        private System.Windows.Forms.RichTextBox SecondVariantTextBox;
        private System.Windows.Forms.RichTextBox OptionTextBox;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button ComputerGameButton;
        private System.Windows.Forms.Button CancelProgramButton;
        private System.Windows.Forms.Button OptionButton;
        private System.Windows.Forms.Button MultiGameButton;
        private System.Windows.Forms.Button SingleGameButton;
        public System.Windows.Forms.Timer GameTimer1;

    }
}

