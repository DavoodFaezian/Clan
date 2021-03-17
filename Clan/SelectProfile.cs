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
    public partial class SelectProfile : Form
    {
        Battle battle = new Battle();
        IProfile repository;
        int i = 0;
        public int Id = 0;
        List<int> Person = new List<int>();
        List<Button> newbtn = new List<Button>();
        public SelectProfile()
        {
            InitializeComponent();
            repository = new Profile();
          
        }

        

        private void SelectProfile_Load(object sender, EventArgs e)
        {

            int y = 0;
            int x = 100;
            
            
            for ( i = 0; i < 1; i++)
            {
                x += 100;
                if (i%3 == 0)
                {
                    y += 100;
                    x = 0;
                }
                if (i == 0)
                {
                    y = 0;
                    x = 0;
                }

                
                Button newButton = new Button();
                this.Controls.Add(newButton);
                newButton.Text = repository.selectall().Rows[i][0].ToString();
                newButton.Location = new Point(50, 50);
                newButton.Size = new Size(100, 100);
                newButton.Location = new Point(x, y);
                newbtn.Add(newButton);
                newbtn[i].Click += new EventHandler(button_Click);

            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;           
            Id= Convert.ToInt32(s);
            battle.ID = Id-1;
        }
       
        private void SelectProfile_Click(object sender, EventArgs e)
        {


        }

        private void btnsumbit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(battle.ID.ToString());
            DialogResult = DialogResult.OK;
        }
    }
}
