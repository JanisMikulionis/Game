using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FinalGame2
{
    [Serializable()]
    public class HighScore
    {
        public int Score { get; set; }
        public string Initials { get; set; }
        public List<HighScore> ScoreList = new List<HighScore>();
        public void AddScoreToList(int thisScore, string name)
        {
            LoadScores();
            var score = new HighScore() { Score = thisScore, Initials = name };
            ScoreList.Add(score);
            SaveScores();
        }     
        void SaveScores()
        {
            var serializer = new XmlSerializer(ScoreList.GetType(), "HighScores.Scores");
            using (var writer = new StreamWriter("highscores.xml", false))
            {
                serializer.Serialize(writer.BaseStream, ScoreList);
            }
        } 
        public void LoadScores()
        {
            var serializer = new XmlSerializer(ScoreList.GetType(), "HighScores.Scores");
            object obj;
            using (var reader = new StreamReader("highscores.xml"))
            {
                obj = serializer.Deserialize(reader.BaseStream);
            }
            ScoreList = (List<HighScore>)obj;
        }
    }
}
