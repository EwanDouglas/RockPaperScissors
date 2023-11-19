using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RandomNumber();
        }

        private void RandomNumber()
        {
            Random rand = new Random();
            {
                int number1;
                number1 = rand.Next(1, 4);
                //lblRand.Text = Convert.ToString(number1);
                if (number1 == 1)
                {
                    lblRand.Text = "Rock";
                }
                if (number1 == 2)
                {
                    lblRand.Text = "Paper";
                }
                if (number1 == 3)
                {
                    lblRand.Text = "Scissors";
                }
            }
        }

        private void Rock()
        {
            lblRand.Visible = true;

            if (lblRand.Text == "Rock")
            {
                MessageBox.Show("Tie! Play again");
            }
            if (lblRand.Text == "Paper")
            {
                MessageBox.Show("Computer wins!");
            }
            else if (lblRand.Text == "Scissors")
            {
                MessageBox.Show("User wins!");
            }
        }

        private void Paper()
        {
            lblRand.Visible = true;

            if (lblRand.Text == "Rock")
            {
                MessageBox.Show("User wins!");
            }
            if (lblRand.Text == "Paper")
            {
                MessageBox.Show("Tie! Play again");
            }
            else if (lblRand.Text == "Scissors")
            {
                MessageBox.Show("Computer wins!");
            }

        }

        private void Scissors()
        {
            lblRand.Visible = true;

            if (lblRand.Text == "Rock")
            {
                MessageBox.Show("Computer wins!");
            }
            if (lblRand.Text == "Paper")
            {
                MessageBox.Show("User wins!");
            }
            else if (lblRand.Text == "Scissors")
            {
                MessageBox.Show("Tie! Play again");
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            Rock();
            RandomNumber();
            lblRand.Visible = false;
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            Paper();
            RandomNumber();
            lblRand.Visible = false;
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            Scissors();
            RandomNumber();
            lblRand.Visible = false;
        }
    }
}