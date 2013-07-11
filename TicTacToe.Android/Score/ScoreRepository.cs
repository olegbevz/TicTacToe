using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TicTacToe.Android.Score
{
    using System.IO;
    using System.IO.IsolatedStorage;
    using System.Xml.Serialization;

    public enum PlayerType
    {
        Computer,

        Player
    }

    public class GameInfo
    {
        public PlayerType Winner { get; set; }

        public GameMode GameMode { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }

    public class Score
    {
        public Score()
        {
            GamesInfo = new List<GameInfo>();
        }

        public List<GameInfo> GamesInfo { get; set; } 

        public int GetVictoriesCount(PlayerType playerType)
        {
            return GamesInfo.Count(gameInfo => gameInfo.Winner ==  playerType);
        }
    }

    public class ScoreRepository
    {
        private string storage;

        public ScoreRepository(string storage)
        {
            this.storage = storage;
        }

        public void Save(Score score)
        {
            var serializer = new XmlSerializer(typeof(Score));

            var iso = IsolatedStorageFile.GetUserStoreForApplication();

            if (iso.FileExists(storage))
            {
                iso.DeleteFile(storage);
            }

            using (var stream = iso.OpenFile(storage, FileMode.CreateNew, FileAccess.Write))
            {
                serializer.Serialize(stream, score);
            }
        }

        public Score Load()
        {
            var serializer = new XmlSerializer(typeof(Score));

            var iso = IsolatedStorageFile.GetUserStoreForApplication();

            if (iso.FileExists(this.storage))
            {
                using (var stream = iso.OpenFile(this.storage, FileMode.Open, FileAccess.Read))
                {
                    return serializer.Deserialize(stream) as Score;
                }
            }

            return new Score();
        }
    }
}