using System.Drawing;
using System.Windows.Forms;

namespace PingPongSolution
{
    public class Ball : BasicObject
    {
        private bool gameOver;

        public enum collidedWithPaddle { leftPaddle, rightPaddle, invalid };

        public collidedWithPaddle paddleHit;

        public Ball(PictureBox basicObject, Rectangle boundaries) : base(basicObject, boundaries) { paddleHit = collidedWithPaddle.invalid; }

        override protected void ChangeVelocity()
        {
            if (basicObject.Left <= boundaries.Left)
            {
                velocity.X = -velocity.X;
                // game over in singleplayer and multiplayer
                gameOver = true;
            }

            if (basicObject.Right >= boundaries.Right)
            {
                velocity.X = -velocity.X;
                // game over in multiplayer
            }

            if (basicObject.Top <= boundaries.Top || basicObject.Bottom >= boundaries.Bottom)
            {
                velocity.Y = -velocity.Y;
            }

            if (paddleHit == collidedWithPaddle.leftPaddle)
            {
                velocity.X = -velocity.X;
                basicObject.Location = new Point(basicObject.Location.X + 6, basicObject.Location.Y);
                paddleHit = collidedWithPaddle.invalid;
            }

            if (paddleHit == collidedWithPaddle.rightPaddle)
            {
                velocity.X = -velocity.X;
                basicObject.Location = new Point(basicObject.Location.X - 6, basicObject.Location.Y);
                paddleHit = collidedWithPaddle.invalid;
            }
        }

        override public bool CheckForVictory()
        {
            if (gameOver)
            {
                return true;
            }
            return false;
        }
    }
}
