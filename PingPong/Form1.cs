using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class PingPongWindow : Form
    {
        private bool PaddleMovingUp;
        private bool PaddleMovingDown;
        private bool BallMovingUp;
        private bool BallMovingLeft;
        private int PlayerScore;
        private double BallSpeed;

        public PingPongWindow()
        {
            InitializeComponent();
        }

        private void PingPongWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            StartGameButton.Visible = false;
            BallMovingLeft = true;
            PlayerScore = 0;
            BallSpeed = 2.0;
            ScoreLabel.Text = "Score: " + PlayerScore;

            timer1.Interval = 10;
            timer1.Tick += new EventHandler(TimerTick);
            timer1.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            // paddle movement
            if (PaddleMovingUp && PlayField.Top < (Paddle.Top - 4))
            {
                Paddle.Top -= 10;
            }

            if (PaddleMovingDown && PlayField.Bottom > (Paddle.Bottom + 1))
            {
                Paddle.Top += 10;
            }

            // vertical movement
            if (BallMovingUp)
            {
                Ball.Top -= (int)BallSpeed;
            }
            if (!BallMovingUp)
            {
                Ball.Top += (int)BallSpeed;
            }

            // horizontal movement
            if (BallMovingLeft)
            {
                Ball.Left -= (int)BallSpeed;
            }
            if (!BallMovingLeft)
            {
                Ball.Left += (int)BallSpeed;
            }

            // border checks

            // left border: game over
            if (Ball.Left == PlayField.Left + 4)
            {
                timer1.Stop();
                MessageBox.Show("You lost.");
            }
            // right border: bounce
            if (Ball.Right >= PlayField.Right - 3)
            {
                BallMovingLeft = true;
            }

            //top border: bounce
            if (Ball.Top <= PlayField.Top + 4)
            {
                BallMovingUp = false;
            }
            // bottom border: bounce
            if (Ball.Bottom >= PlayField.Bottom - 3)
            {
                BallMovingUp = true;
            }
            // paddle contact: bounce
            if (Paddle.Bounds.IntersectsWith(Ball.Bounds))
            {
                BallMovingLeft = false;
                PlayerScore += 100;
            }
            // updating score
            ScoreLabel.Text = "Score: " + PlayerScore;
            //increasing speed
            BallSpeed += 0.00001;
        }

        // lagless paddle movement control
        private void PingPongWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                PaddleMovingUp = false;
            }

            if (e.KeyCode == Keys.S)
            {
                PaddleMovingDown = false;
            }
        }

        private void PingPongWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                PaddleMovingUp = true;
            }

            if (e.KeyCode == Keys.S)
            {
                PaddleMovingDown = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
                MessageBox.Show("Final score: " + PlayerScore);
            }
        }

        // drawing a border for the playfield
        private void PingPongWindow_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            e.Graphics.DrawRectangle(blackPen, PlayField.Location.X, PlayField.Location.Y, PlayField.Size.Width, PlayField.Size.Height);
        }
    }
}
