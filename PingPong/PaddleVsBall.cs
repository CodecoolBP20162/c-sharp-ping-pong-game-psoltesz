using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    class PaddleVsBall
    {
        public PaddleVsBall()
        {
        }

        public bool CheckCollision(Rectangle paddleBounds, Rectangle ballBounds)
        {
            if (paddleBounds.IntersectsWith(ballBounds))
            {
                return true;
            }
            return false;
        }
    }
}
