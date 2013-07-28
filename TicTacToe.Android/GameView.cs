namespace TicTacToe.Android
{
    using System;

    using GamePanelApplication;

    using TicTacToe.Interfaces;

    using global::Android.App;
    using global::Android.Content;
    using global::Android.Graphics;
    using global::Android.Runtime;
    using global::Android.Util;
    using global::Android.Views;

    using Color = global::Android.Graphics.Color;

    public class GameView : View, Game.IGameView
    {
        public AndroidGraphics graphics;

        protected GameView(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public GameView(Context context)
            : base(context)
        {
        }

        public GameView(Context context, IAttributeSet attrs)
            : base(context, attrs)
        {
        }

        public GameView(Context context, IAttributeSet attrs, int defStyle)
            : base(context, attrs, defStyle)
        {
        }

        public GameMode GameMode { get; set; }

        public Game Game { get; private set; }
        
        protected override void OnDraw(Canvas canvas)
        {
            if (graphics == null)
            {
                this.graphics = new AndroidGraphics(canvas, Resources);

                this.Game = new Game();

                Game._gamers = GameMode;

                this.Game.Start(this);

                Game.Field.cellSize = 50;

                if (Game._gamers == GameMode.TwoComputers)
                {
                    Game.ComputersGame(this);
                }
            }

            canvas.Save();

            canvas.DrawColor(Color.White);

            Game.Field.Draw();

            base.OnDraw(canvas);

            canvas.Restore();
        }

        public override bool OnTouchEvent(MotionEvent e)
        {
            string Message = "";
            if ((e.Action == MotionEventActions.Down) && Game._gameIsGoing)
            {
                int x = 0, y = 0;

                Game.Field.HitPosition((int)e.GetX(), (int)e.GetY(), out x, out y);

                int Result = this.Game.Go(x, y, this, ref Message);

                this.Invalidate();
                
                //MessageLabel.Text = Message;
                //if (game._rule == 2)
                //ShowScore(game._player1._score, game._player2._score);
                if (Game._gamers == GameMode.TwoPlayers)
                    if (Result != 0)
                        ChangeStep();
            }

            return base.OnTouchEvent(e);
        }

        private void ChangeStep()
        {
        }

        public IGraphics CreateGraphics()
        {
            return this.graphics;
        }

        public void ShowMessage(string message)
        {
            //ShowMessage(message,this.Context);
        }

        public static void ShowMessage(string message, Context context)
        {
            var builder = new AlertDialog.Builder(context);
            builder.SetTitle("Error");
            builder.SetMessage(message);
            builder.SetCancelable(false);
            builder.SetPositiveButton("OK", delegate { });
            builder.Show();
        }
    }
}