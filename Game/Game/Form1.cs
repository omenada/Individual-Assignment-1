using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                              

        }

        private void BtnRock_Click(object sender, EventArgs e)
        {
            PlayGame("rock");
            pictureBox1.Image = Properties.Resources.rock;
            //pictureBox2.Image = Properties.Resources.rock;
        }

        private void BtnPaper_Click(object sender, EventArgs e)
        {
            PlayGame("paper");
            pictureBox1.Image = Properties.Resources.paper;                
            //pictureBox2.Image = Properties.Resources.paper;
        }

        private void BtnScissors_Click(object sender, EventArgs e)
        {
            PlayGame("scissor");
            pictureBox1.Image = Properties.Resources.scissors;
            //pictureBox2.Image = Properties.Resources.scissors;

        }

        private void PlayGame(string playerChoice )
        {
            string[] Choice = new string[] { "rock", "paper", "scissor" };
            Random rdChoice = new Random();
            int c = rdChoice.Next(0, 2);
            string computerInput = Choice[c];

            int count = 0; //user
            int count1 = 0; //computer

            playerChoice = playerChoice.ToUpper();
            computerInput = computerInput.ToUpper();

            if (playerChoice == "ROCK" && computerInput == "SCISSOR")
            {
                pictureBox2.Image = Properties.Resources.scissors;
                lblresult.Visible = true;
                lblresult.Text ="User wins";

                //count++;
                //lbluser.Text = ("User Win " + count + " times");
            }
            else if (playerChoice == "ROCK" && computerInput == "PAPER")
            {
                pictureBox2.Image = Properties.Resources.paper;
                lblresult.Visible = true;
                lblresult.Text = "Computer wins";
                //count1++;
                //lblComp.Text = ("Computer Win" + count1 + " times");


            }
            else 
            if (playerChoice == "PAPER" && computerInput == "ROCK")
            {
                pictureBox2.Image = Properties.Resources.rock;
                lblresult.Visible = true;
                lblresult.Text= "User wins";
                //count++;
                //lbluser.Text = ("User Win " + count + " times");

            }
            else if (playerChoice == "PAPER" && computerInput == "SCISSOR")
            {
                pictureBox2.Image = Properties.Resources.scissors;
                lblresult.Visible = true;
                lblresult.Text="Computer Wins";
                //count1++;
                //lblComp.Text = ("Computer Win" + count1 + " times");

            }
            else if (playerChoice == "SCISSOR" && computerInput == "ROCK")
            {
                pictureBox2.Image = Properties.Resources.rock;
                lblresult.Visible = true;
                lblresult.Text="Computer Wins";
                //count1++;                                                            
                //lblComp.Text = ("Computer Win" + count1 + " times");


            }
            else if (playerChoice == "SCISSOR" && computerInput == "PAPER")
            {
                pictureBox2.Image = Properties.Resources.paper;
                lblresult.Visible = true;
                lblresult.Text = "User wins";
                //count++;
                //lbluser.Text = ("User Win " + count + " times");
                
            }
            else
            {
                lblresult.Visible = true;
                lblresult.Text = "Same choices";
                
            }
                       

            //lbluser.Text = ("User Win " + count + " times");
           // lblComp.Text = ("Computer Win" + count1 + " times");

        }

        
    }
}
