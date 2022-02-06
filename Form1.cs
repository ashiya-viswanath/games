using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace birdgame
{
    public partial class birdGame : Form
    {
        int score = 0;
        int gravity = 10;
        int pipeSpeed = 4;
        public birdGame()
        {
            InitializeComponent();
        }

        private void startGame(object sender, EventArgs e)
         {
            //scoreText.Text = bird.Top.ToString();
            bird.Top += gravity;
           
             pipeDown.Left -= pipeSpeed; // link the bottom pipes left position to the pipe speed integer, it will reduce the pipe speed value from the left position of the pipe picture box so it will move left with each tick
            pipeUp.Left -= pipeSpeed; // the same is happening with the top pipe, reduce the value of pipe speed integer from the left position of the pipe using the -= sign
           
            scoreText.Text = "Score: " + score; // sh
         
            if (pipeDown.Left < -150)
            {
                // if the bottom pipes location is -150 then we will reset it back to 800 and add 1 to the score
                pipeDown.Left = 800;
                score++;
            }
             if (pipeUp.Left < -180)
            {
                // if the top pipe location is -180 then we will reset the pipe back to the 950 and add 1 to the score
                pipeUp.Left = 950;
                score++;
            }
           
             if (bird.Bounds.IntersectsWith(pipeDown.Bounds) ||
               bird.Bounds.IntersectsWith(pipeUp.Bounds) ||
               bird.Bounds.IntersectsWith(ground.Bounds) || bird.Top < -25
               )
            {
                // if any of the conditions are met from above then we will run the end game function
                endGame();
            }
            void endGame()
            {
                timer1.Stop(); // stop the main timer
                scoreText.Text += " Game over!!!";

            }
        }

        private void birdGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

        }

        private void birdGame_KeyDown(object sender, KeyEventArgs e)
          {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }

        }

        private void textBox1_AcceptsTabChanged(object sender, EventArgs e)
        {

        }
    }    
}
