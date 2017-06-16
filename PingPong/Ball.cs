using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    class Ball : BasicObject
    {
        public bool touchingPaddle;

        public Ball(PictureBox basicObject, Rectangle boundaries) : base(basicObject, boundaries)
        {
        }

        override protected void ChangeVelocity()
        {
            if (basicObject.Left <= boundaries.Left || basicObject.Right >= boundaries.Right)
            {
                velocity.X = -velocity.X;
            }

            if (basicObject.Top <= boundaries.Top || basicObject.Bottom >= boundaries.Bottom)
            {
                velocity.Y = -velocity.Y;
            }

            if (touchingPaddle)
            {
                velocity.X = -velocity.X;
                Point newLocation = new Point(basicObject.Location.X + 6, basicObject.Location.Y);
                basicObject.Location = newLocation;
            }
        }
    }
}
