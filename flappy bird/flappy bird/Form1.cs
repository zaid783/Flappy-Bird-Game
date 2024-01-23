using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappybird
{
    public partial class game : Form
    {


        int pipspeed = 25;
        int gravity = 15;
        int SCORE = 0;

        public game()
        {
            InitializeComponent();
        }
        ////////////GAME STARTUP CODE///////////////////////////
        private void gametimerevent(object sender, EventArgs e)
        {
            restart.Hide();
            flappybird.Top += gravity;
            pipebottom.Left -= pipspeed;
            pipeTop.Left -= pipspeed;
            scoreText.Text = "score: " + SCORE;
            ///////////////gravity step/////////////////
            if (pipebottom.Left < -150)
            {
                pipebottom.Left = 800;
                SCORE++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                SCORE++;
            }
            ////////////intersect section///////////////////
            if (flappybird.Bounds.IntersectsWith(pipebottom.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappybird.Bounds.IntersectsWith(ground.Bounds) || flappybird.Top < -25
                )
            {
                endGame();
            }
            /////////speed & score section ////////////
            if (SCORE > 5)
            {
                pipspeed = 28;
            }
            if (SCORE > 10)
            {
                pipspeed = 32;
            }
            if (SCORE > 15)
            {
                pipspeed = 40;
            }

        }
        /////////GAME PLAY'S KEY section/////////////////////
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }


        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;

            }
        }
        void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += "Game over!!!";
            restart.Show();
        }
        /////////////RESTART CODING section/////////////////////
        private void restart_Click_1(object sender, EventArgs e)
        {
            gameTimer.Start();
            restart.Hide();
            flappybird.Location = new Point(48, 217);
            pipeTop.Location = new Point(494, 414);
            pipebottom.Location = new Point(637, -20);
            ground.Location = new Point(-9, 623);
            SCORE = 0;
            pipspeed = 25;
        }

        private void pipebottom_Click(object sender, EventArgs e)
        {

        }

        private void game_Load(object sender, EventArgs e)
        {

        }
    }
}



