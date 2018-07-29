using ARGOPOS.Login.DatabaseRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARGOPOS.Login
{
    public partial class LoginView : Form
    {
        UserRepo userRepo;
        public LoginView()
        {
            InitializeComponent();
            userRepo = new UserRepo();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

           pos_user user = userRepo.userExits(username, password);

            if (user != null)
            {
                ArgoPosParent argoPosParent = new ArgoPosParent();
                argoPosParent.Show();
                this.Hide();
            }
            else {


                MessageBox.Show("invalid user name or password","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
