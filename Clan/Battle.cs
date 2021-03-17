using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clan
{
    public partial class Battle : Form
    {
        IWin repository;
        IComputerBattle computer;
        public List<string> parts = new List<string>();
        public string[] mark = { "X", "O" };
        int i = 0;
        public int player = 0;
        public bool Winner = false;
        public int cup;
        public int money;
        public int currentcup;
        public int currentmoney;
        public int ID=0;
        public Battle()
        {
            InitializeComponent();
            repository = new Win();
            computer = new ComputerBattle();
             

    }
        private void Turn()
        {
            if (i % 2 == 0)
            {
                player = 1;
            }
            else
            {
                player = 0;
            }
            i++;
            if (player == 0)
            {
                label1.Text = "you're turn";
            }
            else
            {
                label1.Text = ("Computer turn");
            }

        }
        private void CheckWin()
        {
            bool isWin = repository.CheckWin(btnpart1.Text, btnpart2.Text, btnpart3.Text, btnpart4.Text, btnpart5.Text, btnpart6.Text, btnpart7.Text, btnpart8.Text, btnpart9.Text);
            if (isWin == true && Winner == false)
            {
                if (player == 1)
                {
                    cup = -12 + (i/2);
                    lblcup.Text = cup.ToString();
                    money = 5;
                    lblmoney.Text = "+" + money.ToString();
                    Winner = true;
                    MessageBox.Show("You lost");                   
                    Winner = true;
                }
                else
                {
                    cup = 12;
                    lblcup.Text = "+" + cup.ToString();
                    money = ((9 - i) * 5 + 1);
                    lblmoney.Text = "+" + money.ToString();
                    MessageBox.Show("You win");
                    Winner = true;
                }
                label1.Hide();
                btnOK.Show();
            }
            else
            {
                if(i == 9 && Winner == false)
                {
                    
                    MessageBox.Show("draw!");                    
                    Winner = true;
                    label1.Hide();
                    btnOK.Show();
                }
            }
        }
        private void ComputerTurn()
        {
            if (Winner == false) { 
                 if (btnpart3.Text == "" && btnpart2.Text == btnpart1.Text && btnpart1.Text == mark[1] && player == 1)
                {
                    btnpart3.Text = mark[1];
                }
                else if (btnpart6.Text == "" && btnpart4.Text == btnpart5.Text && btnpart4.Text == mark[1] && player == 1)
                {
                    btnpart6.Text = mark[1];
                }
                else if (btnpart9.Text == "" && btnpart7.Text == btnpart8.Text && btnpart7.Text == mark[1] && player == 1)
                {
                    btnpart9.Text = mark[1];
                }
                else if (btnpart9.Text == "" && btnpart1.Text == btnpart5.Text && btnpart1.Text == mark[1] && player == 1)
                {
                    btnpart9.Text = mark[1];
                }
                else if (btnpart7.Text == "" && btnpart3.Text == btnpart6.Text && btnpart3.Text == mark[1] && player == 1)
                {
                    btnpart7.Text = mark[1];
                }
                else if (btnpart7.Text == "" && btnpart1.Text == btnpart4.Text && btnpart1.Text == mark[1] && player == 1)
                {
                    btnpart7.Text = mark[1];
                }
                else if (btnpart8.Text == "" && btnpart2.Text == btnpart5.Text && btnpart2.Text == mark[1] && player == 1)
                {
                    btnpart8.Text = mark[1];
                }
                else if (btnpart9.Text == "" && btnpart3.Text == btnpart6.Text && btnpart3.Text == mark[1] && player == 1)
                {
                    btnpart9.Text = mark[1];
                }



                else if (btnpart1.Text == "" && btnpart2.Text == btnpart3.Text && btnpart1.Text == mark[1] && player == 1)
                {
                    btnpart1.Text = mark[1];
                }
                else if (btnpart4.Text == "" && btnpart6.Text == btnpart5.Text && btnpart5.Text == mark[1] && player == 1)
                {
                    btnpart4.Text = mark[1];
                }
                else if (btnpart7.Text == "" && btnpart9.Text == btnpart8.Text && btnpart9.Text == mark[1] && player == 1)
                {
                    btnpart7.Text = mark[1];
                }
                else if (btnpart1.Text == "" && btnpart9.Text == btnpart5.Text && btnpart9.Text == mark[1] && player == 1)
                {
                    btnpart1.Text = mark[1];
                }
                else if (btnpart3.Text == "" && btnpart7.Text == btnpart6.Text && btnpart7.Text == mark[1] && player == 1)
                {
                    btnpart3.Text = mark[1];
                }
                else if (btnpart1.Text == "" && btnpart7.Text == btnpart4.Text && btnpart7.Text == mark[1] && player == 1)
                {
                    btnpart1.Text = mark[1];
                }
                else if (btnpart2.Text == "" && btnpart8.Text == btnpart5.Text && btnpart8.Text == mark[1] && player == 1)
                {
                    btnpart2.Text = mark[1];
                }
                else if (btnpart3.Text == "" && btnpart9.Text == btnpart6.Text && btnpart9.Text == mark[1] && player == 1)
                {
                    btnpart3.Text = mark[1];
                }




                else if (btnpart2.Text == "" && btnpart1.Text == btnpart3.Text && btnpart1.Text == mark[1] && player == 1)
                {
                    btnpart2.Text = mark[1];
                }
                else if (btnpart6.Text == "" && btnpart4.Text == btnpart5.Text && btnpart5.Text == mark[1] && player == 1)
                {
                    btnpart6.Text = mark[1];
                }
                else if (btnpart8.Text == "" && btnpart9.Text == btnpart7.Text && btnpart9.Text == mark[1] && player == 1)
                {
                    btnpart8.Text = mark[1];
                }
                else if (btnpart5.Text == "" && btnpart9.Text == btnpart1.Text && btnpart9.Text == mark[1] && player == 1)
                {
                    btnpart5.Text = mark[1];
                }
                else if (btnpart6.Text == "" && btnpart7.Text == btnpart3.Text && btnpart7.Text == mark[1] && player == 1)
                {
                    btnpart6.Text = mark[1];
                }
                else if (btnpart4.Text == "" && btnpart7.Text == btnpart1.Text && btnpart7.Text == mark[1] && player == 1)
                {
                    btnpart4.Text = mark[1];
                }
                else if (btnpart5.Text == "" && btnpart8.Text == btnpart2.Text && btnpart8.Text == mark[1] && player == 1)
                {
                    btnpart5.Text = mark[1];
                }
                else if (btnpart6.Text == "" && btnpart9.Text == btnpart3.Text && btnpart9.Text == mark[1] && player == 1)
                {
                    btnpart6.Text = mark[1];
                }






                else if (btnpart3.Text == "" && btnpart2.Text == btnpart1.Text && btnpart1.Text == mark[0] && player == 1)
                {
                    btnpart3.Text = mark[1];
                }
                else if (btnpart6.Text == "" && btnpart4.Text == btnpart5.Text && btnpart4.Text == mark[0] && player == 1)
                {
                    btnpart6.Text = mark[1];
                }
                else if (btnpart9.Text == "" && btnpart7.Text == btnpart8.Text && btnpart7.Text == mark[0] && player == 1)
                {
                    btnpart9.Text = mark[1];
                }
                else if (btnpart9.Text == "" && btnpart1.Text == btnpart5.Text && btnpart1.Text == mark[0] && player == 1)
                {
                    btnpart9.Text = mark[1];
                }
                else if (btnpart7.Text == "" && btnpart3.Text == btnpart6.Text && btnpart3.Text == mark[0] && player == 1)
                {
                    btnpart7.Text = mark[1];
                }
                else if (btnpart7.Text == "" && btnpart1.Text == btnpart4.Text && btnpart1.Text == mark[0] && player == 1)
                {
                    btnpart7.Text = mark[1];
                }
                else if (btnpart8.Text == "" && btnpart2.Text == btnpart5.Text && btnpart2.Text == mark[0] && player == 1)
                {
                    btnpart8.Text = mark[1];
                }
                else if (btnpart9.Text == "" && btnpart3.Text == btnpart6.Text && btnpart3.Text == mark[0] && player == 1)
                {
                    btnpart9.Text = mark[1];
                }



                else if (btnpart1.Text == "" && btnpart2.Text == btnpart3.Text && btnpart1.Text == mark[0] && player == 1)
                {
                    btnpart1.Text = mark[1];
                }
                else if (btnpart4.Text == "" && btnpart6.Text == btnpart5.Text && btnpart5.Text == mark[0] && player == 1)
                {
                    btnpart4.Text = mark[1];
                }
                else if (btnpart7.Text == "" && btnpart9.Text == btnpart8.Text && btnpart9.Text == mark[0] && player == 1)
                {
                    btnpart7.Text = mark[1];
                }
                else if (btnpart1.Text == "" && btnpart9.Text == btnpart5.Text && btnpart9.Text == mark[0] && player == 1)
                {
                    btnpart1.Text = mark[1];
                }
                else if (btnpart3.Text == "" && btnpart7.Text == btnpart6.Text && btnpart7.Text == mark[0] && player == 1)
                {
                    btnpart3.Text = mark[1];
                }
                else if (btnpart1.Text == "" && btnpart7.Text == btnpart4.Text && btnpart7.Text == mark[0] && player == 1)
                {
                    btnpart1.Text = mark[1];
                }
                else if (btnpart2.Text == "" && btnpart8.Text == btnpart5.Text && btnpart8.Text == mark[0] && player == 1)
                {
                    btnpart2.Text = mark[1];
                }
                else if (btnpart3.Text == "" && btnpart9.Text == btnpart6.Text && btnpart9.Text == mark[0] && player == 1)
                {
                    btnpart3.Text = mark[1];
                }




                else if (btnpart2.Text == "" && btnpart1.Text == btnpart3.Text && btnpart1.Text == mark[0] && player == 1)
                {
                    btnpart2.Text = mark[1];
                }
                else if (btnpart6.Text == "" && btnpart4.Text == btnpart5.Text && btnpart5.Text == mark[0] && player == 1)
                {
                    btnpart6.Text = mark[1];
                }
                else if (btnpart8.Text == "" && btnpart9.Text == btnpart7.Text && btnpart9.Text == mark[0] && player == 1)
                {
                    btnpart8.Text = mark[1];
                }
                else if (btnpart5.Text == "" && btnpart9.Text == btnpart1.Text && btnpart9.Text == mark[0] && player == 1)
                {
                    btnpart5.Text = mark[1];
                }
                else if (btnpart6.Text == "" && btnpart7.Text == btnpart3.Text && btnpart7.Text == mark[0] && player == 1)
                {
                    btnpart6.Text = mark[1];
                }
                else if (btnpart4.Text == "" && btnpart7.Text == btnpart1.Text && btnpart7.Text == mark[0] && player == 1)
                {
                    btnpart4.Text = mark[1];
                }
                else if (btnpart5.Text == "" && btnpart8.Text == btnpart2.Text && btnpart8.Text == mark[0] && player == 1)
                {
                    btnpart5.Text = mark[1];
                }
                else if (btnpart6.Text == "" && btnpart9.Text == btnpart3.Text && btnpart9.Text == mark[0] && player == 1)
                {
                    btnpart6.Text = mark[1];
                }



                else if (btnpart1.Text != "" && btnpart1.Text == btnpart9.Text && btnpart8.Text == "")
                {
                    btnpart8.Text = mark[1];
                }
                else if (btnpart3.Text != "" && btnpart3.Text == btnpart7.Text && player == 1 && btnpart8.Text == "")
                {
                    btnpart8.Text = mark[1];
                }

                
                else if (btnpart2.Text != "" && btnpart2.Text == btnpart4.Text && player == 1 && btnpart1.Text == "")
                {
                    btnpart1.Text = mark[1];
                }
                else if (btnpart4.Text != "" && btnpart4.Text == btnpart6.Text && player == 1 && btnpart3.Text == "")
                {
                    btnpart3.Text = mark[1];
                }
                else if (btnpart6.Text != "" && btnpart6.Text == btnpart8.Text && player == 1 && btnpart7.Text == "")
                {
                    btnpart7.Text = mark[1];
                }
                else if (btnpart1.Text != "" && btnpart1.Text == btnpart8.Text && player == 1 && btnpart7.Text == "")
                {
                    btnpart7.Text = mark[1];
                }
                else if (btnpart3.Text != "" && btnpart3.Text == btnpart8.Text && player == 1 && btnpart9.Text == "")
                {
                    btnpart9.Text = mark[1];
                }
                else if (btnpart6.Text != "" && btnpart6.Text == btnpart8.Text && player == 1 && btnpart7.Text == "")
                {
                    btnpart7.Text = mark[1];
                }


                else if (btnpart5.Text == "" && player == 1)
                {
                    btnpart5.Text = mark[1];
                }
                else if (btnpart1.Text == "" && player == 1)
                {
                    btnpart1.Text = mark[1];
                }
               
                else if (btnpart7.Text == "" && player == 1)
                {
                    btnpart7.Text = mark[1];
                }
                else if (btnpart3.Text == "" && player == 1)
                {
                    btnpart3.Text = mark[1];
                }
                else if (btnpart9.Text == "" && player == 1)
                {
                    btnpart9.Text = mark[1];
                }
                else if (btnpart2.Text == "" && player == 1)
                {
                    btnpart2.Text = mark[1];
                }
                else if (btnpart4.Text == "" && player == 1)
                {
                    btnpart4.Text = mark[1];
                }
                else if (btnpart6.Text == "" && player == 1)
                {
                    btnpart6.Text = mark[1];
                }
                else if (btnpart8.Text == "" && player == 1)
                {
                    btnpart8.Text = mark[1];
                }


               
            }
            
        }


        private void btnpart1_Click(object sender, EventArgs e)
        {
            if (btnpart1.Text == "" &&Winner==false)
            {
                btnpart1.Text = mark[player];                
                CheckWin();
                Turn();
                ComputerTurn();
                Turn();
                CheckWin();
            }
            else
            {

            }
        }

        private void btnpart2_Click(object sender, EventArgs e)
        {
            if (btnpart2.Text == "" && Winner == false)
            {
                btnpart2.Text = mark[player];
                CheckWin();
                Turn();
                ComputerTurn();
                CheckWin();
                Turn();                
            }
            else
            {

            }
        }

        private void btnpart3_Click(object sender, EventArgs e)
        {
            if (btnpart3.Text == "" && Winner == false)
            {
                btnpart3.Text = mark[player];
                CheckWin();
                Turn();
                ComputerTurn();
                CheckWin();
                Turn();
                
            }
            else
            {

            }
        }

        private void btnpart4_Click(object sender, EventArgs e)
        {
            if (btnpart4.Text == "" && Winner == false)
            {
                btnpart4.Text = mark[player];
                CheckWin();
                Turn();
                ComputerTurn();
                CheckWin();
                Turn();                
            }
            else
            {

            }
        }

        private void btnpart5_Click(object sender, EventArgs e)
        {
            if (btnpart5.Text == "" && Winner == false)
            {
                btnpart5.Text = mark[player];
                CheckWin();
                Turn();
                ComputerTurn();
                CheckWin();
                Turn();                
            }
            else
            {

            }
        }

        private void btnpart6_Click(object sender, EventArgs e)
        {
            if (btnpart6.Text == "" && Winner == false)
            {
                btnpart6.Text = mark[player];
                CheckWin();
                Turn();
                ComputerTurn();
                CheckWin();
                Turn();
            }
            else
            {

            }
        }

        private void btnpart7_Click(object sender, EventArgs e)
        {
            if (btnpart7.Text == "" && Winner == false)
            {
                btnpart7.Text = mark[player];
                CheckWin();
                Turn();
                ComputerTurn();
                CheckWin();
                Turn();                
            }
            else
            {

            }
        }

        private void btnpart8_Click(object sender, EventArgs e)
        {
            if (btnpart8.Text == "" && Winner == false)
            {
                btnpart8.Text = mark[player];
                CheckWin();
                Turn();
                ComputerTurn();
                CheckWin();
                Turn();               
            }
            else
            {

            }
        }

        private void btnpart9_Click(object sender, EventArgs e)
        {
            if (btnpart9.Text == "" && Winner == false)
            {
                btnpart9.Text = mark[player];
                CheckWin();
                Turn();
                ComputerTurn();
                CheckWin();
                Turn();
            }
            else
            {

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            currentcup += cup;
            currentmoney += money;
            rewards.Show();
            lblname.Text = computer.Selectall().Rows[0][1].ToString();
            Profile_picture();
        }

        private void Battle_Load(object sender, EventArgs e)
        {
            btnOK.Hide();
            rewards.Hide();
            
        }

              private void Profile_picture()
        {
            int Avatar_Profile = (int)computer.Selectall().Rows[0][2];
            switch (Avatar_Profile)
            {
                case 1:
                    {
                        this.avatar.Load("D:\\Danial - Davood\\D&D.i\\avatars\\face1.png");
                        break;
                    }
                case 2:
                    {
                        this.avatar.Load("D:\\Danial - Davood\\D&D.i\\avatars\\face2.png");
                        break;
                    }
                case 3:
                    {
                        this.avatar.Load("D:\\Danial - Davood\\D&D.i\\avatars\\face3.png");
                        break;
                    }
                case 4:
                    {
                        this.avatar.Load("D:\\Danial - Davood\\D&D.i\\avatars\\face4.png");
                        break;
                    }
                case 5:
                    {
                        this.avatar.Load("D:\\Danial - Davood\\D&D.i\\avatars\\face5.png");
                        break;
                    }
                case 6:
                    {
                        this.avatar.Load("D:\\Danial - Davood\\D&D.i\\avatars\\face6.png");
                        break;
                    }

                default:
                    break;
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
           
            cup = currentcup;
            money = currentmoney;
            currentcup = (int)computer.Selectall().Rows[0][3];
            currentmoney = (int)computer.Selectall().Rows[0][4];
            bool isCupSuccess = computer.Cup(1, cup, currentcup, money, currentmoney);
            if (isCupSuccess == true)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("OOPS!");
            }
        }

        private void playagain_Click(object sender, EventArgs e)
        {
            Winner = false;
            btnpart1.Text = "";
            btnpart2.Text = "";
            btnpart3.Text = "";
            btnpart4.Text = "";
            btnpart5.Text = "";
            btnpart6.Text = "";
            btnpart7.Text = "";
            btnpart8.Text = "";
            btnpart9.Text = "";
            rewards.Hide();
            btnOK.Hide();
            i = 0;
        }
    }
}
