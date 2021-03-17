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
    public partial class AddProfile : Form
    {
        IAddplayer repository;
        Battle battle = new Battle();
        public AddProfile()
        {
            repository = new Addplayer();
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            

            bool isSuccess=repository.add(battle.ID,txtname.Text, 2);
            if (isSuccess==true)
            {
                DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("DAdd");
            }


        }

        private void AddProfile_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Avatar avatar = new Avatar();
            avatar.ShowDialog();
        }
    }
}
