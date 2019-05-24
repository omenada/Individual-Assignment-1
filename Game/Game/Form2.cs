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
    public partial class Form2 : Form 
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            if (txtplayer1.Text == "") // validation to not accept empty value
            {
                MessageBox.Show("Enter your name.");
                
            }
            else
            {
                Form1 mainGame = new Form1();// intanciate the form 1 to find the label  
                mainGame.lblPlayer1.Text = txtplayer1.Text;
                mainGame.Show();//call to show the other form

            }
           
           
         }

        
    }
}
