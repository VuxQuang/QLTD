namespace QLTD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Quang" && txtPassword.Text == "123456" || txtUsername.Text == "Phatsan" && txtPassword.Text == "123")
            {
                Dashboard dbs = new Dashboard();
                dbs.Show();
                this.Hide();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignUpAccount sgn = new SignUpAccount();
            sgn.Show();
            this.Hide();
        }
    }
}
