
namespace TicTacToe.Android
{
    using System;

    using TicTacToe.Android.Score;

    using global::Android.App;
    using global::Android.Content;
    using global::Android.OS;

    using global::Android.Widget;

    [Activity(Label = "Tic Tac Toe", MainLauncher = true, Icon = "@drawable/icon")]
    public class MenuActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            try
            {
                // Set our view from the "main" layout resource
                SetContentView(Resource.Layout.Main);

                // Get our button from the layout resource,
                // and attach an event to it
                FindViewById<Button>(Resource.Id.OnePlayerButton).Click += OnStartSinglePlayerGame;

                FindViewById<Button>(Resource.Id.TwoPlayersButton).Click += OnStartMultiplePlayerGame;

                //FindViewById<Button>(Resource.Id.TwoComputersButton).Click += OnStartComputerPlayerGame;
            }
            catch (Exception ex)
            {
                GameView.ShowMessage(ex.Message, this.BaseContext);
            }
        }

        protected override void OnResume()
        {
                try
            {
                var repository = new ScoreRepository("score.xml");

                var score = repository.Load();

                ShowComputerVictoriesCount(score.GetVictoriesCount(PlayerType.Computer));

                ShowPlayerVictoriesCount(score.GetVictoriesCount(PlayerType.Player));
            }
             catch (Exception ex)
             {
                 GameView.ShowMessage(ex.Message, this.BaseContext);
             }

            base.OnResume();
        }

        private void ShowComputerVictoriesCount(int victoriesCount)
        {
            this.SetTextViewContent(
                Resource.Id.ComputerVictoriesTextView, 
                "Computer victories: " + victoriesCount);
        }

        private void ShowPlayerVictoriesCount(int victoriesCount)
        {
            this.SetTextViewContent(
                Resource.Id.PlayerVictoriesTextView,
                "Player victories: " + victoriesCount);
        }

        private void SetTextViewContent(int textViewId, string content)
        {
            var textView = this.FindViewById<TextView>(textViewId);

            if (textView != null)
            {
                textView.Text = content;
            }
        }

        private void OnStartSinglePlayerGame(object sender, EventArgs e)
        {
            OnStartGame(GameMode.OnePlayer);
        }

        private void OnStartMultiplePlayerGame(object sender, EventArgs e)
        {
            OnStartGame(GameMode.TwoPlayers);
        }

        private void OnStartComputerPlayerGame(object sender, EventArgs e)
        {
            OnStartGame(GameMode.TwoComputers);
        }

        private void OnStartGame(GameMode gameMode)
        {
            try
            {
                var intent = new Intent(BaseContext, typeof(GameActivity));

                intent.PutExtra("GameMode", (int)gameMode);

                this.StartActivity(intent);
            }
            catch (Exception ex)
            {
                GameView.ShowMessage(ex.Message, this);
            }
        }
    }
}

