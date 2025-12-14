#nullable disable
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        int score;
        int highScore;
        bool isPaused = false;
        SoundPlayer eatSound;
        SoundPlayer gameOverSound;

        public Form1()
        {
            InitializeComponent();
            proptimer.Tick += new EventHandler(Gametimerevent);
            new Settings();

            try
            {
                string eatPath = System.IO.Path.Combine(Application.StartupPath, "Sounds", "eating-sound-effect-36186.wav");
                string gameOverPath = System.IO.Path.Combine(Application.StartupPath, "Sounds", "game-over-arcade-6435.wav");

                eatSound = new SoundPlayer(eatPath);
                gameOverSound = new SoundPlayer(gameOverPath);

                eatSound.Load();
                gameOverSound.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sound loading error:\n" + ex.Message);
            }
        }

        private void SetLevel(int interval)
        {
            proptimer.Stop();
            isPaused = false;

            Snake.Clear();
            new Settings();

            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);
            Circle body = new Circle { X = 9, Y = 5 };
            Snake.Add(body);

            Settings.direction = Directions.Right;
            proptimer.Interval = interval;

            GenerateFood();
            proptimer.Start();
            btnstart.Enabled = false;
            btnresume.Enabled = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    if (Settings.direction != Directions.Right) Settings.direction = Directions.Left;
                    return true;
                case Keys.Right:
                    if (Settings.direction != Directions.Left) Settings.direction = Directions.Right;
                    return true;
                case Keys.Up:
                    if (Settings.direction != Directions.Down) Settings.direction = Directions.Up;
                    return true;
                case Keys.Down:
                    if (Settings.direction != Directions.Up) Settings.direction = Directions.Down;
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnresume_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                proptimer.Start();
                isPaused = false;
                btnresume.Enabled = false;
                btnstart.Enabled = false;
                piccanvas.Focus();
            }
        }

        private void Startgame(object sender, EventArgs e)
        {
            RestartGame();
            btnstart.Enabled = false;
            btnresume.Enabled = false;
            piccanvas.Focus();
            proptimer.Start();
        }

        private void Stopgame(object sender, EventArgs e)
        {
            if (proptimer.Enabled)
            {
                proptimer.Stop();
                isPaused = true;
                btnstart.Enabled = true;
                btnresume.Enabled = true;
            }
        }

        private void RestartGame()
        {
            score = 0;
            lblscore.Text = "Score: " + score;

            new Settings();
            Snake.Clear();

            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);
            Circle body = new Circle { X = 9, Y = 5 };
            Snake.Add(body);

            GenerateFood();
        }

        private void Gametimerevent(object sender, EventArgs e)
        {
            MovePlayer();
            piccanvas.Invalidate();
        }

        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Directions.Right: Snake[i].X++; break;
                        case Directions.Left: Snake[i].X--; break;
                        case Directions.Up: Snake[i].Y--; break;
                        case Directions.Down: Snake[i].Y++; break;
                    }

                    int maxXPos = piccanvas.Size.Width / Settings.Width;
                    int maxYPos = piccanvas.Size.Height / Settings.Height;

                    if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos) GameOver();

                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y) GameOver();
                    }

                    if (Snake[i].X == food.X && Snake[i].Y == food.Y) EatFood();
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void GenerateFood()
        {
            int maxXPos = piccanvas.Size.Width / Settings.Width;
            int maxYPos = piccanvas.Size.Height / Settings.Height;
            Random random = new Random();
            food = new Circle { X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos) };
        }

        private void EatFood()
        {
            Circle body = new Circle { X = Snake[Snake.Count - 1].X, Y = Snake[Snake.Count - 1].Y };
            Snake.Add(body);
            score += 1;
            lblscore.Text = "Score: " + score;

            if (eatSound != null) eatSound.Play();
            GenerateFood();
        }

        private void GameOver()
        {
            if (btnstart.Enabled == true) return;
            if (isPaused && !proptimer.Enabled) return;

            proptimer.Stop();
            if (gameOverSound != null) gameOverSound.Play();

            btnstart.Enabled = true;
            btnresume.Enabled = false;
            isPaused = false;

            if (score > highScore)
            {
                highScore = score;
                lblhighscore.Text = "High Score: " + highScore;
            }

            MessageBox.Show("Game Over! \nYour Score: " + score);
        }

        private void Updatepicbox(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (Snake.Count == 0) return;

            for (int i = 0; i < Snake.Count; i++)
            {
                Brush snakeColour = Brushes.Yellow;
                canvas.FillEllipse(snakeColour,
                    new Rectangle(Snake[i].X * Settings.Width, 
                    Snake[i].Y * Settings.Height, 
                    Settings.Width,
                    Settings.Height));
            }

            canvas.FillEllipse(Brushes.Red, 
                new Rectangle(food.X * Settings.Width,
                food.Y * Settings.Height,
                Settings.Width, 
                Settings.Height));
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void keyisdown(object sender, KeyEventArgs e) { }
        private void keyisup(object sender, KeyEventArgs e) { }

        private void levelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isPaused = true;
            proptimer.Stop();
            btnresume.Enabled = true;
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            easyToolStripMenuItem.Checked = true;
            mediumToolStripMenuItem.Checked = false;
            hardToolStripMenuItem.Checked = false;
            SetLevel(200);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            easyToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = true;
            hardToolStripMenuItem.Checked = false;
            SetLevel(120);
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            easyToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = false;
            hardToolStripMenuItem.Checked = true;
            SetLevel(60);
        }
    }
}
