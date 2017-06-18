using System.Drawing;
using System.Windows.Forms;

namespace PingPong
{
    class Paddle : BasicObject
    {
        Keys upKey;
        Keys downKey;
        enum collisionLocation { atBot, atTop, invalid };
        public string playerName;
        public int ID;
        private int score = 0;
        public bool scored;

        collisionLocation collisionDetection;

        public Paddle(PictureBox basicObject, Rectangle boundaries, Keys upKey, Keys downKey, string playerName, int ID) : base(basicObject, boundaries)
        {
            this.upKey = upKey;
            this.downKey = downKey;
            this.playerName = playerName;
            this.ID = ID;
            collisionDetection = collisionLocation.invalid;
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
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

        public void AddScore()
        {
            if (scored) { Score += 100; }
            scored = false;
        }

        override public bool CheckForVictory()
        {
            if (score == 1000)
            {
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
