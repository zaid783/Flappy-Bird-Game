namespace flappybird
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.restart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // flappybird
            // 
            this.flappybird.BackColor = System.Drawing.Color.Aqua;
            this.flappybird.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flappybird.Cursor = System.Windows.Forms.Cursors.Default;
            this.flappybird.ErrorImage = null;
            this.flappybird.Image = ((System.Drawing.Image)(resources.GetObject("flappybird.Image")));
            this.flappybird.InitialImage = null;
            this.flappybird.Location = new System.Drawing.Point(27, 257);
            this.flappybird.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(135, 93);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 0;
            this.flappybird.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pipebottom.Image = ((System.Drawing.Image)(resources.GetObject("pipebottom.Image")));
            this.pipebottom.InitialImage = ((System.Drawing.Image)(resources.GetObject("pipebottom.InitialImage")));
            this.pipebottom.Location = new System.Drawing.Point(831, -37);
            this.pipebottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(186, 318);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 1;
            this.pipebottom.TabStop = false;
            this.pipebottom.Click += new System.EventHandler(this.pipebottom_Click);
            // 
            // pipeTop
            // 
            this.pipeTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pipeTop.ErrorImage = null;
            this.pipeTop.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop.Image")));
            this.pipeTop.InitialImage = ((System.Drawing.Image)(resources.GetObject("pipeTop.InitialImage")));
            this.pipeTop.Location = new System.Drawing.Point(647, 482);
            this.pipeTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(193, 304);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-12, 767);
            this.ground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1821, 129);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Moccasin;
            this.scoreText.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(16, 795);
            this.scoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(225, 53);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // restart
            // 
            this.restart.AutoSize = true;
            this.restart.BackColor = System.Drawing.Color.ForestGreen;
            this.restart.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.restart.Location = new System.Drawing.Point(1019, 795);
            this.restart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(385, 59);
            this.restart.TabIndex = 5;
            this.restart.Text = "Try Again!!!";
            this.restart.Click += new System.EventHandler(this.restart_Click_1);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1435, 902);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.flappybird);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "game";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label restart;
    }
}

