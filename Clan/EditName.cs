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
    public partial class EditName : Form
    {
        Battle battle = new Battle();
        IProfile repository;
        public EditName()
        {
            repository = new Profile();
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                bool isSuccess = repository.Update_name(txtName.Text, (int)1);
                if (isSuccess == true)
                {

                    DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Enter your name");
            }
        }

        private void EditName_Load(object sender, EventArgs e)
        {
            txtName.Text = repository.selectall().Rows[battle.ID][1].ToString();
        }
    }
}
