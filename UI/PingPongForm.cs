using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PingPongSolution
{
    public partial class PingPongWindow : Form
    {
        private bool gameRunning;
        private bool gameOver;
        private Ball theBall;
        private List<Paddle> players;
        private Paddle player1Paddle;
        private Paddle player2Paddle;

        public PingPongWindow()
        {
            InitializeComponent();
            theBall = new Ball(Ball, PlayField.Bounds);
            theBall.velocity.X = 3;
            theBall.velocity.Y = 3;
            players = new List<Paddle>();
        }

        private void PingPongWindow_Load(object sender, EventArgs e)
        {
            mainTimer.Interval = 13;
            player1Paddle = new Paddle(Paddle, PlayField.Bounds, Keys.W, Keys.S, "Player 1", 1);
            players.Add(player1Paddle);
        }

        private void SingleplayerTick(object sender, EventArgs e)
        {
            // collision and score check
            Collision.CheckCollision(player1Paddle, theBall);
            // adding scores
            player1Paddle.AddScore();
            gameOver = player1Paddle.CheckForVictory();
            gameOver = theBall.CheckForVictory();
            // movement
            theBall.Move();
            player1Paddle.Move();
            // updating score
            ScoreLabel1.Text = "Score: " + player1Paddle.Score;
            CheckIfGameIsOver(player1Paddle);
        }

        private void TwoPlayersTick(object sender, EventArgs e)
        {
            // collision and score check
            if (!Collision.CheckCollision(player1Paddle, theBall))
            {
                Collision.CheckCollision(player2Paddle, theBall);
            }
            // adding scores
            player1Paddle.AddScore();
            gameOver = player1Paddle.CheckForVictory();
            player2Paddle.AddScore();
            gameOver = player2Paddle.CheckForVictory();
            theBall.CheckForVictory();
            // movement
            theBall.Move();
            player1Paddle.Move();
            player2Paddle.Move();
            // updating score
            ScoreLabel1.Text = "Score: " + player1Paddle.Score;
            ScoreLabel2.Text = "Score: " + player2Paddle.Score;
            CheckIfGameIsOver(player1Paddle);
            CheckIfGameIsOver(player2Paddle);
        }

        // lagless paddle movement control
        private void PingPongWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (players.Count == 2)
            {
                if (player1Paddle.KeyReleased(e.KeyCode) || player2Paddle.KeyReleased(e.KeyCode))
                {
                    return;
                }
            }
            if (player1Paddle.KeyReleased(e.KeyCode))
            {
                return;
            }
        }
        
        // rest of movement and extra KeyEvents
        private void PingPongWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (players.Count == 2)
            {
                if (player1Paddle.KeyPressed(e.KeyCode) || player2Paddle.KeyPressed(e.KeyCode))
                {
                    return;
                }
            }

            if (player1Paddle.KeyPressed(e.KeyCode))
            {
                return;
            }


            if (e.KeyCode == Keys.Escape)
            {
                mainTimer.Stop();
                Application.Exit();
            }

            if (e.KeyCode == Keys.Space && gameRunning)
            {
                gameRunning = false;
                mainTimer.Stop();
                MessageBox.Show("Paused");
            }

            if (e.KeyCode == Keys.Space && !gameRunning)
            {
                gameRunning = true;
                mainTimer.Start();
            }
        }

        // single player mode
        private void SinglePlayerButton_Click(object sender, EventArgs e)
        {
            mainTimer.Tick += new EventHandler(SingleplayerTick);
            HideButtons();
            Ball.Visible = true;
            Paddle.Visible = true;
            Paddle2.SetBounds(1, 1, 1, 1);
            Paddle2.Enabled = false;
            
            gameRunning = true;
            mainTimer.Start();
        }

        // 2 players mode
        private void TwoPlayersButton_Click(object sender, EventArgs e)
        {
            mainTimer.Tick += new EventHandler(TwoPlayersTick);
            HideButtons();
            Ball.Visible = true;
            Paddle.Visible = true;
            Paddle2.Visible = true;
            player2Paddle = new Paddle(Paddle2, PlayField.Bounds, Keys.O, Keys.L, "Player 2", 2);
            players.Add(player2Paddle);

            gameRunning = true;
            mainTimer.Start();
        }

        private void HideButtons()
        {
            SinglePlayerButton.Visible = false;
            TwoPlayersButton.Visible = false;
        }

        // game over check
        private void CheckIfGameIsOver(Paddle paddle)
        {
            if (gameOver)
            {
                mainTimer.Stop();
                theBall.basicObject.Visible = false;
                paddle.basicObject.Visible = false;
                GameOverLabel.Visible = true;
                MessageBox.Show(paddle.playerName + " wins!");
                Application.Exit();
            }
        }

        // scalability
        private void PingPongWindow_SizeChanged(object sender, EventArgs e)
        {
            if (theBall != null)
            {
                foreach (Paddle player in players)
                {
                    player.boundaries = PlayField.Bounds;
                }
                theBall.boundaries = PlayField.Bounds;
            }
            Invalidate();
        }

        // drawing a border for the playfield
        private void PingPongWindow_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            e.Graphics.DrawRectangle(blackPen, PlayField.Location.X, PlayField.Location.Y, PlayField.Size.Width, PlayField.Size.Height);
        }
    }
}
