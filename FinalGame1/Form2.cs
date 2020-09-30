using System;
using System.Windows.Forms;

namespace FinalGame2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Form1 f = new Form1();
                f.Show();
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
        private void rules_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
        private void score_Click(object sender, EventArgs e)
        {
            HIGHSCORES scores = new HIGHSCORES();
            scores.Show();
        }
    }
}
