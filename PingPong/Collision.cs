﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    static class Collision
    {
        public static bool CheckCollision(Paddle paddle, Ball ball)
        {
            if (paddle.basicObject.Bounds.IntersectsWith(ball.basicObject.Bounds))
            {
                if (paddle.ID == 1)
                {
                    ball.paddleHit = Ball.collidedWithPaddle.leftPaddle;
                    paddle.scored = true;
                }
                else
                {
                    ball.paddleHit = Ball.collidedWithPaddle.rightPaddle;
                    paddle.scored = true;
                }
                return true;
            }
            ball.paddleHit = Ball.collidedWithPaddle.invalid;
            return false;
        }
    }
}
