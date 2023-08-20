namespace PointOfSales
{
    public partial class Form1 : Form
    {
        LogicLayer.Connection connection = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if (connection.BDConnect(Input_user.Text, Input_password.Text) == 1)
            {
                MessageBox.Show("Succesful Login");
            }
        }


    }
}