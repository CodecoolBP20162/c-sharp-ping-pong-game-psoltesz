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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingPongWindow));
            this.Paddle = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayField = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Paddle
            // 
            this.Paddle.Image = ((System.Drawing.Image)(resources.GetObject("Paddle.Image")));
            this.Paddle.Location = new System.Drawing.Point(336, 177);
            this.Paddle.Name = "Paddle";
            this.Paddle.Size = new System.Drawing.Size(31, 158);
            this.Paddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Paddle.TabIndex = 0;
            this.Paddle.TabStop = false;
            // 
            // PlayField
            // 
            this.PlayField.Location = new System.Drawing.Point(192, 49);
            this.PlayField.Name = "PlayField";
            this.PlayField.Size = new System.Drawing.Size(790, 435);
            this.PlayField.TabIndex = 1;
            this.PlayField.TabStop = false;
            this.PlayField.Visible = false;
            // 
            // Ball
            // 
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(773, 218);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(91, 83);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // PingPongWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 567);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Paddle);
            this.Controls.Add(this.PlayField);
            this.Name = "PingPongWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PingPongWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PingPongWindow_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PingPongWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PingPongWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Paddle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PlayField;
        private System.Windows.Forms.PictureBox Ball;
    }
}

