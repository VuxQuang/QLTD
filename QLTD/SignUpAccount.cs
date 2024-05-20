using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTD
{
    public partial class SignUpAccount : Form
    {
        public SignUpAccount()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Phatsan" && txtPassword.Text == "123")
            {
                MessageBox.Show("Bạn đã đăng kí thành công");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
