using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clan
{
    public partial class Game : Form
    {
       
        IWin repository;
        public List<string> parts = new List<string>();
        public string[] mark = { "X", "O" };
        int i = 0;
        public int player = 1;
        
       
        public Game()
        {
            repository = new Win();
            InitializeComponent();

           
        }



        private void Game_Load(object sender, EventArgs e)
        {
           
        }
        
        private void CheckWin()
        {
            bool isWin = repository.CheckWin(btnpart1.Text, btnpart2.Text, btnpart3.Text, btnpart4.Text, btnpart5.Text, btnpart6.Text, btnpart7.Text, btnpart8.Text, btnpart9.Text);
            if(isWin == true)
            {
                MessageBox.Show(mark[player] + " is winner");

            }
            else
            {
                              
            }
        }

        private void Turn()
        {
            if (i % 2 == 0)
            {
                player = 0;
            }
            else
            {
                player = 1;
            }
            i++;
            label1.Text = "player" + (player+1) + "(" + mark[player] + " 's turn)";
        }

        private void btnpart1_Click(object sender, EventArgs e)
        {
            if (btnpart1.Text == "")
            {
                btnpart1.Text = mark[player];
                CheckWin();
                Turn();
            }
            else
            {

            }

        }

        private void btnpart2_Click(object sender, EventArgs e)
        {
            if (btnpart2.Text == "")
            {
                btnpart2.Text = mark[player];
                CheckWin();
                Turn();
                
            }
            else
            {

            }
        }

        private void btnpart3_Click(object sender, EventArgs e)
        {
            if (btnpart3.Text == "")
            {
                btnpart3.Text = mark[player];
                CheckWin();
                Turn();                
            }
            else
            {

            }
        }

        private void btnpart4_Click(object sender, EventArgs e)
        {
            if (btnpart4.Text == "")
            {
                btnpart4.Text = mark[player];
                CheckWin();
                Turn();
            }
            else
            {

            }
        }

        private void btnpart5_Click(object sender, EventArgs e)
        {
            if (btnpart5.Text == "")
            {
                btnpart5.Text = mark[player];
                CheckWin();
                Turn();
            }
            else
            {

            }
        }

        private void btnpart6_Click(object sender, EventArgs e)
        {
            if (btnpart6.Text == "")
            {
                btnpart6.Text = mark[player];
                Turn();
            }
            else
            {

            }
        }

        private void btnpart7_Click(object sender, EventArgs e)
        {
            if (btnpart7.Text == "")
            {
                btnpart7.Text = mark[player];
                CheckWin();
                Turn();
            }
            else
            {

            }
        }

        private void btnpart8_Click(object sender, EventArgs e)
        {
            if (btnpart8.Text == "")
            {
                btnpart8.Text = mark[player];
                CheckWin();
                Turn();
            }
            else
            {

            }
        }

        private void btnpart9_Click(object sender, EventArgs e)
        {
            if (btnpart9.Text == "")
            {
                btnpart9.Text = mark[player];
                CheckWin();
                Turn();
            }
            else
            {

            }
        }



    }
}
    

