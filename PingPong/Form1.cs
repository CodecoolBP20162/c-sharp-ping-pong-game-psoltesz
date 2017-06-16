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
        private int PlayerScore;
        private bool GameRunning;
        private Ball theBall;
        private Paddle player1Paddle;
        private Paddle player2Paddle;
        private PaddleVsBall paddleVsBall;

        public PingPongWindow()
        {
            InitializeComponent();
            theBall = new Ball(Ball, PlayField.Bounds);
            theBall.velocity.X = 3;
            theBall.velocity.Y = 3;
            player1Paddle = new Paddle(Paddle, PlayField.Bounds, Keys.W, Keys.S);
            player2Paddle = new Paddle(Paddle2, PlayField.Bounds, Keys.O, Keys.L);
            paddleVsBall = new PaddleVsBall();

        }

        private void PingPongWindow_Load(object sender, EventArgs e)
        {
            PlayerScore = 0;
            ScoreLabel.Text = "Score: " + PlayerScore;
            timer1.Interval = 13;
            timer1.Tick += new EventHandler(TimerTick);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            theBall.touchingPaddle = paddleVsBall.CheckCollision(player1Paddle.basicObject.Bounds, theBall.basicObject.Bounds);
            theBall.Move();
            player1Paddle.Move();
            player2Paddle.Move();
            
            // updating score
            ScoreLabel.Text = "Score: " + PlayerScore;
        }

        // lagless paddle movement control
        private void PingPongWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (player1Paddle.KeyReleased(e.KeyCode) || player2Paddle.KeyReleased(e.KeyCode))
            {
                return;
            }
        }
        
        // rest of movement and extra KeyEvents
        private void PingPongWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (player1Paddle.KeyPressed(e.KeyCode) || player2Paddle.KeyPressed(e.KeyCode))
            {
                return;
            }

            if (e.KeyCode == Keys.Escape)
            {
                timer1.Stop();
                MessageBox.Show("Final score: " + PlayerScore);
                Application.Exit();
            }

            if (e.KeyCode == Keys.Space && GameRunning)
            {
                GameRunning = false;
                timer1.Stop();
                MessageBox.Show("Paused");
            }

            if (e.KeyCode == Keys.Space && !GameRunning)
            {
                GameRunning = true;
                timer1.Start();
            }
        }

        // single player mode
        private void SinglePlayerButton_Click(object sender, EventArgs e)
        {
            HideButtons();
            Ball.Visible = true;
            Paddle.Visible = true;
            Paddle2.SetBounds(1, 1, 1, 1);

            GameRunning = true;
            timer1.Start();
        }

        // 2 players mode
        private void TwoPlayersButton_Click(object sender, EventArgs e)
        {
            HideButtons();
            Ball.Visible = true;
            Paddle.Visible = true;
            Paddle2.Visible = true;

            GameRunning = true;
            timer1.Start();
        }

        // method to hide buttons
        private void HideButtons()
        {
            SinglePlayerButton.Visible = false;
            TwoPlayersButton.Visible = false;
        }

        // scalability
        private void PingPongWindow_SizeChanged(object sender, EventArgs e)
        {
            if (theBall != null)
            {
                player1Paddle.boundaries = PlayField.Bounds;
                player2Paddle.boundaries = PlayField.Bounds;
                theBall.boundaries = PlayField.Bounds;
            }
            Invalidate();
            Update();
        }

        // drawing a border for the playfield
        private void PingPongWindow_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            e.Graphics.DrawRectangle(blackPen, PlayField.Location.X, PlayField.Location.Y, PlayField.Size.Width, PlayField.Size.Height);
        }
    }
}
