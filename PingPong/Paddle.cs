using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    class Paddle : BasicObject
    {
        Keys upKey;
        Keys downKey;
        enum collisionLocation { atBot, atTop, invalid };

        collisionLocation collisionDetection;

        public Paddle(PictureBox basicObject, Rectangle boundaries, Keys upKey, Keys downKey) : base(basicObject, boundaries)
        {
            this.upKey = upKey;
            this.downKey = downKey;
            collisionDetection = collisionLocation.invalid;
        }

        public bool KeyPressed(Keys key)
        {
            if (key == upKey && collisionDetection != collisionLocation.atTop)
            {
                velocity.Y = -6;
                return true;
            }
            else if (key == downKey && collisionDetection != collisionLocation.atBot)
            {
                velocity.Y = 6;
                return true;
            }
            return false;
        }

        public bool KeyReleased(Keys key)
        {
            if (key == upKey || key == downKey)
            {
                velocity.Y = 0;
                return true;
            }
            return false;
        }

        override protected void ChangeVelocity()
        {
            if (basicObject.Top <= boundaries.Top)
            {
                velocity.Y = 0;
                collisionDetection = collisionLocation.atTop;
            }
            else if (basicObject.Bottom >= boundaries.Bottom)
            {
                velocity.Y = 0;
                collisionDetection = collisionLocation.atBot;
            }
            else
            {
                collisionDetection = collisionLocation.invalid;
            }
        }
    }
}
