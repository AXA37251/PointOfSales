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
    public partial class UserDelete : Form
    {
        readonly LogicLayer.Connection connection = new();
        public UserDelete()
        {
            InitializeComponent();
            DGV_DeleteUsers.DataSource = connection.GetInfoUsers_UserDocument();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            //try
            //{
            connection.LogicDeleteUser(Input_DeleteDocument.Text);
            DGV_DeleteUsers.DataSource = connection.GetInfoUsers_UserDocument();
            //}
            //catch(Exception exception) 
            //{
            //    MessageBox.Show("Error tryng: " + exception);
            //}
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
