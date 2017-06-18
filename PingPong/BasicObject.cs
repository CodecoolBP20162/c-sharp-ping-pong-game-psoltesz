using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public abstract class BasicObject
    {
        public Point velocity;
        public Rectangle boundaries;
        public PictureBox basicObject;

        public BasicObject(PictureBox basicObject, Rectangle boundaries)
        {
            velocity = new Point(0, 0);
            this.basicObject = basicObject;
            this.boundaries = boundaries;
        }

        public void Move()
        {
            basicObject.Location = new Point(basicObject.Location.X + velocity.X, basicObject.Location.Y + velocity.Y);
            ChangeVelocity();
        }

        // abstract method since the ball and the paddles require different handling
        abstract protected void ChangeVelocity();
        abstract public bool CheckForVictory();
    }
}
