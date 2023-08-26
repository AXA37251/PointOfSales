namespace PointOfSales
{
    public partial class Login : Form
    {
        readonly LogicLayer.Connection connection = new();

        public Login()
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
                this.Hide();
                MessageBox.Show("Succesful Login");
                MainWindow mainW = new MainWindow();
                mainW.Show();

            }else 
            {
                MessageBox.Show("invalid credentials");
            }
        }
    }
}