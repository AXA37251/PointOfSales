using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSales
{
    public partial class UserAdd : Form
    {
        readonly LogicLayer.Connection connection = new LogicLayer.Connection();

        public UserAdd()
        {
            InitializeComponent();
        }

        private void Btn_AddUser_Click(object sender, EventArgs e)
        {
            try
            {
                connection.LogicAddUser(Input_User.Text, Input_Password.Text, Input_Name.Text, Input_LastName.Text, Input_DocNum.Text, Input_Phone.Text);
                MessageBox.Show("User added successfully");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception);
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

