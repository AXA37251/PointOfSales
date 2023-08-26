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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Users_Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAdd AddUserW = new UserAdd();
            AddUserW.ShowDialog();
            this.Show();
        }

        private void Users_Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserEdit EditUserW = new UserEdit();
            EditUserW.ShowDialog();
            this.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDelete UserDeleteW = new UserDelete();
            UserDeleteW.ShowDialog();
            this.Show();
        }
    }
}
