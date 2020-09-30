using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalGame2
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int x;
        int y;
        int gameSpeed = 0;
        int walletVal = 0;
        int totalDistanceTravelled = 0;
        int currentEnemy1X;
        int currentEnemy2X;
        int currentEnemy3X;
        int currentEnemy4X;
        int potholeCount;
        int policeFinesVal;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            hideFields();
            playAmbient();
        }
        private void hideFields()
        {
            clickSpace.Visible = true;
            Summary.Visible = false;
            Summary1.Visible = false;
            button1.Visible = false;
            textBox1.Visible = false;
            enterName.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            totalDistanceTravelled++;
            moveLine(gameSpeed);
            enemy(gameSpeed);
            gameOver();
            addCoins();
            distanceMarker();
            punishments();
        }
        void playAmbient()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"ambience.wav");
            player.PlayLooping();
        }
        void playFail()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"crash.wav");
            player.Play();
        }
        private void distanceMarker()
        {
            distance.Text = (totalDistanceTravelled/10).ToString();
        }
        void gameOver()
        {
            if (moto.Bounds.IntersectsWith(enm1.Bounds) || moto.Bounds.IntersectsWith(enm2.Bounds) || 
                moto.Bounds.IntersectsWith(enm3.Bounds) || moto.Bounds.IntersectsWith(enm4.Bounds) || walletVal < 0)
            {
                playFail();
                timer1.Enabled = false;
                clickSpace.Visible = false;
                Summary.Text = ($"{totalDistanceTravelled/10} + cash bonus {(walletVal) * (totalDistanceTravelled/100) }");
                Summary1.Text= ($"Your score: {(totalDistanceTravelled/10) + (walletVal) * (totalDistanceTravelled / 100)}");
                Summary.Visible = true;
                Summary1.Visible = true;
                textBox1.Visible = true;
                enterName.Visible = true;
                button1.Visible = true;
            }
        }
        void punishments()
        {
            if (moto.Bounds.IntersectsWith(pothole.Bounds))
            {
                walletVal -= 2;
                potholeCount++;
                potholes.Text = potholeCount.ToString();
                money.Text = walletVal.ToString();
                x = rand.Next(10, 482);
                y = 700;
                pothole.Location = new Point(x, y);
            }
            if (moto.Bounds.IntersectsWith(popo.Bounds))
            {
                walletVal -= 5;
                policeFinesVal += 5;
                fines.Text = policeFinesVal.ToString();
                money.Text = walletVal.ToString();
                x = 402;
                y = 900;
                popo.Location = new Point(x, y);
            }
        }
        void addCoins()
        {
            if (moto.Bounds.IntersectsWith (coin.Bounds))
            {
                walletVal += 1;
                money.Text = walletVal.ToString();
                x = rand.Next(10, 482);
                y = 0;
                coin.Location = new Point(x, y);
            }
        }
        void moveLine(int speed)
        {
            if (line2.Top >= 500)
            {
                line2.Top = -63;
            }
            else
            {
                line2.Top += speed;
            }
            if (line1.Top >= 500)
            {
                line1.Top = -63;
            }
            else
            {
                line1.Top += speed;
            }
            if (line3.Top >= 500)
            {
                line3.Top = -63;
            }
            else
            {
                line3.Top += speed;
            }
            if (line4.Top >= 500)
            {
                line4.Top = -63;
            }
            else
            {
                line4.Top += speed;
            }
            if (line5.Top >= 500)
            {
                line5.Top = -63;
            }
            else
            {
                line5.Top += speed;
            }
            if (line6.Top >= 500)
            {
                line6.Top = -63;
            }
            else
            {
                line6.Top += speed;
            }
            if (line7.Top >= 500)
            {
                line7.Top = -63;
            }
            else
            {
                line7.Top += speed;
            }
            if (line8.Top >= 500)
            {
                line8.Top = -63;
            }
            else
            {
                line8.Top += speed;
            }
            if (line9.Top >= 500)
            {
                line9.Top = -63;
            }
            else
            {
                line9.Top += speed;
            }
            if (line10.Top >= 500)
            {
                line10.Top = -63;
            }
            else
            {
                line10.Top += speed;
            }
            if (line11.Top >= 500)
            {
                line11.Top = -63;
            }
            else
            {
                line11.Top += speed;
            }
            if (line12.Top >= 500)
            {
                line12.Top = -63;
            }
            else
            {
                line12.Top += speed;
            }
            if (coin.Top >= 500)
            {
                x = rand.Next(10, 442);
                y = -20;
                coin.Location = new Point(x, y);
            }
            else
            {
                coin.Top += speed;
            }
            if (pothole.Top >= 500)
            {
                x = rand.Next(10, 442);
                y = -20;
                pothole.Location = new Point(x, y);
            }
            else
            {
                pothole.Top += speed;
            }
            if (popo.Top >= 1400)
            {
                x = 372;
                y = -20;
                popo.Location = new Point(x, y);
            }
            else
            {
                popo.Top += speed;
            }
        }
        void enemy(int speed)
        {
            if (enm1.Top >= 500)
            {
                x = rand.Next(10, 442);
                y = -50;
                currentEnemy1X = x;
                x = generateFurtherX(x);
                enm1.Location = new Point(x, y);
            }
            else
            {
                enm1.Top += speed-1;
            }
            if (enm3.Top >= 500)
            {
                x = rand.Next(10, 442);
                currentEnemy3X = x;
                y = -50;
                x = generateFurtherX(x);
                enm3.Location = new Point(x, y);
            }
            else
            {
                enm3.Top += speed - 1;
            }
            if (enm4.Top >= 500)
            {
                x = rand.Next(10, 442);
                currentEnemy4X = x;
                y = -50;
                x = generateFurtherX(x);
                enm4.Location = new Point(x, y);
            }
            else
            {
                enm4.Top += speed - 1;
            }

            if (totalDistanceTravelled/10 < 300)
            {
                if (enm2.Top >= 500)
                {
                    x = rand.Next(10, 442);
                    currentEnemy2X = x;
                    y = -50;
                    x = generateFurtherX(x);
                    enm2.Location = new Point(x, y);
                }
                else
                {
                    enm2.Top += speed - 1;
                }
            }
            else
            {
                fastEnemy(gameSpeed);
            }

            if (totalDistanceTravelled / 10 > 600)
            {
                if (extraEnm1.Top >= 500)
                {
                    x = rand.Next(10, 442);
                    y = -50;
                    extraEnm1.Location = new Point(x, y);
                }
                else
                {
                    extraEnm1.Top += speed - 1;
                }
            }
            if (totalDistanceTravelled / 10 > 900)
            {
                if (extraEnm2.Top >= 500)
                {
                    x = rand.Next(10, 442);
                    y = -50;
                    extraEnm2.Location = new Point(x, y);
                }
                else
                {
                    extraEnm2.Top += speed - 1;
                }
            }
            if (totalDistanceTravelled / 10 > 1200)
            {
                if (extraEnm3.Top >= 500)
                {
                    x = rand.Next(10, 442);
                    y = -50;
                    extraEnm3.Location = new Point(x, y);
                }
                else
                {
                    extraEnm3.Top += speed - 1;
                }
            }
        }
        void fastEnemy(int speed)
        {
            if (enm2.Top <= 0)
            {
                x = rand.Next(10, 442);
                currentEnemy2X = x;
                x = generateFurtherX(x);
                y = 1000;
                enm2.Location = new Point(x, y);
            }
            else
            {
                enm2.Top -= speed + 1;
            }
        }
        int generateFurtherX(int x)
        {
            int new_x;
            //if (x == currentEnemy1X || x == currentEnemy2X || x == currentEnemy3X || x == currentEnemy4X)
            if (!(x < currentEnemy1X - 10 || x > currentEnemy1X + 10 ||
                x < currentEnemy2X - 10 || x > currentEnemy2X + 10 ||
                x < currentEnemy3X - 10 || x > currentEnemy3X + 10 ||
                x < currentEnemy4X - 10 || x > currentEnemy4X + 10))
            {
                new_x = rand.Next(10, 442);
                generateFurtherX(new_x);
            }
            else
            {
                return x;
            }
            return new_x;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (moto.Left > 10)
                {
                    moto.Left += -8;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (moto.Right < 442)
                {
                    moto.Left += 8;
                }
            }
            if (gameSpeed == 0)
            {
                if (e.KeyCode == Keys.Space)
                {
                    clickSpace.Visible = false;
                    timer1.Start();
                    gameSpeed = 2;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HighScore newScore = new HighScore();
            if (textBox1.Text != null)
            {
                newScore.AddScoreToList((totalDistanceTravelled / 10) + walletVal * (totalDistanceTravelled / 100), textBox1.Text);
            }
            else
            {
                newScore.AddScoreToList((totalDistanceTravelled / 10) + walletVal * (totalDistanceTravelled / 100), "NoName");
            }
            this.Close();
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HighScore newScore = new HighScore();
                if (textBox1.Text != null)
                {
                    newScore.AddScoreToList((totalDistanceTravelled / 10) + walletVal * (totalDistanceTravelled / 100), textBox1.Text);
                }
                else
                {
                    newScore.AddScoreToList((totalDistanceTravelled / 10) + walletVal * (totalDistanceTravelled / 100), "NoName");
                }
                this.Close();

            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
