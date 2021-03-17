using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Clan
{
    public partial class Clanfrm : Form
    {
        Thread th;
        IProfile repository;
        string ProfileAdress = "D:\\Danial - Davood\\D&D.i\avatars";
        Battle battle = new Battle();
        public int Avatar_Profile;


        public Clanfrm()
        {            
            repository = new Profile();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblcup.Text = repository.selectall().Rows[0][3].ToString();
            lblmoney.Text = repository.selectall().Rows[0][4].ToString();
            EditNameUpdate();
            Profile_picture();
            BindGrid();
            searchgb.Hide();
        }

        private void BindGrid()
        {
            dgprofile.DataSource = repository.selectall();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            EditNameUpdate();
            BindGrid();
        }

        private void EditNameUpdate()
        {
            MyName.Text = repository.selectall().Rows[battle.ID][1].ToString();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            
            Avatar avatar = new Avatar();
            avatar.ShowDialog();
            if(avatar.DialogResult == DialogResult.OK)
            {
                BindGrid();
                Profile_picture();

            }
        }
        private void Profile_picture()
        {
            Avatar_Profile = (int)repository.selectall().Rows[battle.ID][2];
            switch (Avatar_Profile)
            {
                case 1:
                    {
                        this.profile.Load("D:\\Danial - Davood\\D&D.i\\avatars\\face1.png");
                        break;
                    }
                case 2:
                    {
                        this.profile.Load("D:\\Danial - Davood\\D&D.i\\avatars\\face2.png");
                        break;
                    }
                case 3:
                    {
                        this.profile.Load("D:\\Danial - Davood\\D&D.i\\avatars\\face3.png");
                        break;
                    }
                case 4:
                    {
                        this.profile.Load("D:\\Danial - Davood\\D&D.i\\avatars\\face4.png");
                        break;
                    }
                case 5:
                    {
                        this.profile.Load("D:\\Danial - Davood\\D&D.i\\avatars\\face5.png");
                        break;
                    }
                case 6:
                    {
                        this.profile.Load("D:\\Danial - Davood\\D&D.i\\avatars\\face6.png");
                        break;
                    }

                default:
                    break;
            }
        }




        private void btneditname_Click(object sender, EventArgs e)
        {
            EditName editfrm = new EditName();
            editfrm.ShowDialog();
            if(editfrm.DialogResult== DialogResult.OK){
                BindGrid();
                EditNameUpdate();
            }
        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Game game = new Game();
            game.ShowDialog();
          
            
        }
        private void btnbattle_Click(object sender, EventArgs e)
        {
            Battle battle = new Battle();
            battle.ShowDialog();
            if (battle.DialogResult == DialogResult.OK)
            {
                BindGrid();
                EditNameUpdate();
                lblcup.Text = repository.selectall().Rows[0][3].ToString();
                lblmoney.Text = repository.selectall().Rows[0][4].ToString();
            }
        }

        private void AddProfile_Click(object sender, EventArgs e)
        {
            AddProfile frm = new AddProfile();
            frm.ShowDialog();
            if (frm.DialogResult==DialogResult.OK)
            {
                BindGrid();                
            }
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            SelectProfile profile = new SelectProfile();
            profile.ShowDialog();

            if (profile.DialogResult == DialogResult.OK)
            {
                BindGrid();
                battle.ID = profile.Id-1; 
                MessageBox.Show(battle.ID.ToString());
                MyName.Text = repository.selectall().Rows[battle.ID][1].ToString();
                lblcup.Text = repository.selectall().Rows[battle.ID][3].ToString();
                lblmoney.Text = repository.selectall().Rows[battle.ID][4].ToString();
                Avatar_Profile = (int)repository.selectall().Rows[battle.ID][2];
                Profile_picture();
            }
            else
            {
                MessageBox.Show("Umy");
            }
        }

        
        

        private void button2_Click(object sender, EventArgs e)
        {
            searchgb.Show();
        }

        private void CloseSearch_Click(object sender, EventArgs e)
        {

            searchgb.Hide();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dgprofile.DataSource = repository.search(txtsearch.Text);
        }

        private void CloseSearch_MouseEnter(object sender, EventArgs e)
        {
            CloseSearch.BackColor = Color.Red;
        }

      
    }
}
