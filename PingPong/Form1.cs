using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public PingPongWindow()
        {
            InitializeComponent();
        }

        private void PingPongWindow_Load(object sender, EventArgs e)
        {
            Ball.Location = new Point(600, 200);
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
                Ball.Top -= 2;
            }
            if (!BallMovingUp)
            {
                Ball.Top += 2;
            }

            // horizontal movement
            if (BallMovingLeft)
            {
                Ball.Left -= 2;
            }
            if (!BallMovingLeft)
            {
                Ball.Left += 2;
            }

            if (Ball.Left == PlayField.Left + 4)
            {
                timer1.Stop();
                MessageBox.Show("You lost");
            }
            if (Ball.Right >= PlayField.Right - 3)
            {
                BallMovingLeft = true;
            }
            //send it to bottom
            if (Ball.Top == PlayField.Top + 4)
            {
                BallMovingUp = false;
            }
            // send it to top
            if (Ball.Bottom >= PlayField.Bottom - 3)
            {
                BallMovingUp = true;
            }
            // paddle contact
            if (Ball.Left == Paddle.Right)
            {
                BallMovingLeft = true;
            }
        }

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
        }

        private void PingPongWindow_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            e.Graphics.DrawRectangle(blackPen, PlayField.Location.X, PlayField.Location.Y, PlayField.Size.Width, PlayField.Size.Height);
        }
    }
}
