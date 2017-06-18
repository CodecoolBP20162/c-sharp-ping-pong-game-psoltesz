namespace PingPong
{
    partial class PingPongWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel1 = new System.Windows.Forms.Label();
            this.SinglePlayerButton = new System.Windows.Forms.Button();
            this.TwoPlayersButton = new System.Windows.Forms.Button();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Paddle2 = new System.Windows.Forms.PictureBox();
            this.Paddle = new System.Windows.Forms.PictureBox();
            this.PlayField = new System.Windows.Forms.PictureBox();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.ScoreLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayField)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLabel1
            // 
            this.ScoreLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ScoreLabel1.AutoSize = true;
            this.ScoreLabel1.Location = new System.Drawing.Point(276, 519);
            this.ScoreLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel1.Name = "ScoreLabel1";
            this.ScoreLabel1.Size = new System.Drawing.Size(0, 17);
            this.ScoreLabel1.TabIndex = 4;
            // 
            // SinglePlayerButton
            // 
            this.SinglePlayerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SinglePlayerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SinglePlayerButton.Location = new System.Drawing.Point(332, 234);
            this.SinglePlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.SinglePlayerButton.Name = "SinglePlayerButton";
            this.SinglePlayerButton.Size = new System.Drawing.Size(133, 66);
            this.SinglePlayerButton.TabIndex = 5;
            this.SinglePlayerButton.Text = "Single player";
            this.SinglePlayerButton.UseVisualStyleBackColor = true;
            this.SinglePlayerButton.Click += new System.EventHandler(this.SinglePlayerButton_Click);
            // 
            // TwoPlayersButton
            // 
            this.TwoPlayersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TwoPlayersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TwoPlayersButton.Location = new System.Drawing.Point(687, 234);
            this.TwoPlayersButton.Margin = new System.Windows.Forms.Padding(4);
            this.TwoPlayersButton.Name = "TwoPlayersButton";
            this.TwoPlayersButton.Size = new System.Drawing.Size(133, 66);
            this.TwoPlayersButton.TabIndex = 6;
            this.TwoPlayersButton.Text = "2 players";
            this.TwoPlayersButton.UseVisualStyleBackColor = true;
            this.TwoPlayersButton.Click += new System.EventHandler(this.TwoPlayersButton_Click);
            // 
            // Ball
            // 
            this.Ball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.Image = global::PingPong.Properties.Resources.Cute_Ball_Games_icon;
            this.Ball.Location = new System.Drawing.Point(895, 234);
            this.Ball.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(50, 51);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            this.Ball.Visible = false;
            // 
            // Paddle2
            // 
            this.Paddle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Paddle2.Image = global::PingPong.Properties.Resources.rectvert;
            this.Paddle2.Location = new System.Drawing.Point(839, 181);
            this.Paddle2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Paddle2.Name = "Paddle2";
            this.Paddle2.Size = new System.Drawing.Size(31, 158);
            this.Paddle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Paddle2.TabIndex = 9;
            this.Paddle2.TabStop = false;
            this.Paddle2.Visible = false;
            // 
            // Paddle
            // 
            this.Paddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Paddle.Image = global::PingPong.Properties.Resources.rectvert;
            this.Paddle.Location = new System.Drawing.Point(307, 181);
            this.Paddle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Paddle.Name = "Paddle";
            this.Paddle.Size = new System.Drawing.Size(31, 158);
            this.Paddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Paddle.TabIndex = 0;
            this.Paddle.TabStop = false;
            this.Paddle.Visible = false;
            // 
            // PlayField
            // 
            this.PlayField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayField.Location = new System.Drawing.Point(193, 55);
            this.PlayField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayField.Name = "PlayField";
            this.PlayField.Size = new System.Drawing.Size(797, 434);
            this.PlayField.TabIndex = 1;
            this.PlayField.TabStop = false;
            this.PlayField.Visible = false;
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.Font = new System.Drawing.Font("Courier New", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.Location = new System.Drawing.Point(426, 240);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(313, 60);
            this.GameOverLabel.TabIndex = 10;
            this.GameOverLabel.Text = "GAME OVER";
            this.GameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameOverLabel.Visible = false;
            // 
            // ScoreLabel2
            // 
            this.ScoreLabel2.AutoSize = true;
            this.ScoreLabel2.Location = new System.Drawing.Point(836, 519);
            this.ScoreLabel2.Name = "ScoreLabel2";
            this.ScoreLabel2.Size = new System.Drawing.Size(0, 17);
            this.ScoreLabel2.TabIndex = 11;
            // 
            // PingPongWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1238, 567);
            this.Controls.Add(this.ScoreLabel2);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Paddle2);
            this.Controls.Add(this.TwoPlayersButton);
            this.Controls.Add(this.SinglePlayerButton);
            this.Controls.Add(this.ScoreLabel1);
            this.Controls.Add(this.Paddle);
            this.Controls.Add(this.PlayField);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PingPongWindow";
            this.Text = "Pong of Death";
            this.Load += new System.EventHandler(this.PingPongWindow_Load);
            this.SizeChanged += new System.EventHandler(this.PingPongWindow_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PingPongWindow_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PingPongWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PingPongWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox Paddle;
        protected System.Windows.Forms.Timer mainTimer;
        protected System.Windows.Forms.PictureBox PlayField;
        protected System.Windows.Forms.PictureBox Ball;
        protected System.Windows.Forms.Label ScoreLabel1;
        protected System.Windows.Forms.Button SinglePlayerButton;
        protected System.Windows.Forms.Button TwoPlayersButton;
        protected System.Windows.Forms.PictureBox Paddle2;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Label ScoreLabel2;
    }
}

