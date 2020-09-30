using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FinalGame2
{
    public partial class HIGHSCORES : Form
    {
        public HIGHSCORES()
        {
            InitializeComponent();
            HighScore newScore = new HighScore();
            newScore.LoadScores();
            List<HighScore> SortedList = newScore.ScoreList.OrderByDescending(o => o.Score).ToList();
            SortedList.RemoveRange(10, SortedList.Count - 10);
            dataGridView1.DataSource = SortedList;
            dataGridView1.ReadOnly = true;
        }
        private void ScoresDisplayer_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
