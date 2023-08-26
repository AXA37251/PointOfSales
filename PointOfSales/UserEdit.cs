using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;

namespace PointOfSales
{
    public partial class UserEdit : Form
    {
        readonly LogicLayer.Connection connection = new();

        public UserEdit()
        {
            InitializeComponent();
            DGV_EditUsers.DataSource = connection.GetUsers();
        }

        private void UsersTable(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_EditUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DGV_EditUsers.Rows[e.RowIndex];

                Input_User.Text = Convert.ToString(selectedRow.Cells["user"].Value);
                Input_Password.Text = Convert.ToString(selectedRow.Cells["password"].Value);
                Input_Name.Text = Convert.ToString(selectedRow.Cells["name"].Value);
                Input_LastName.Text = Convert.ToString(selectedRow.Cells["lastname"].Value);
                Input_Document.Text = Convert.ToString(selectedRow.Cells["dni"].Value);
                Input_Phone.Text = Convert.ToString(selectedRow.Cells["phone"].Value);
            }
            else
            {
                Input_User.Clear();
                Input_Password.Clear();
                Input_Name.Clear();
                Input_LastName.Clear();
                Input_Document.Clear();
                Input_Phone.Clear();
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            int status;
            status = connection.LogicEditUser(Input_User.Text, Input_Password.Text, Input_Name.Text, Input_LastName.Text, Input_Document.Text, Input_Phone.Text);
            if (status == 1)
            {
                MessageBox.Show("User edited successfully");
            }
            DGV_EditUsers.DataSource = connection.GetUsers();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
