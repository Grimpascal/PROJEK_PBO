using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using Agromart.Model;
using Microsoft.VisualBasic.Logging;
using Npgsql;


namespace Agromart
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHide.Checked == true)
            {
                textPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            userContext userContext = new userContext();
            bool isValid = userContext.validasilogin(username, password);

            if (isValid)
            {
                MessageBox.Show("Login Berhasil", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                DashboarUser dashboarU = new DashboarUser();
                dashboarU.Show();
            }
            else
            {
                MessageBox.Show("Akun tidak ditemukan, silahkan klik tombol register", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUsername.Clear();
                textPassword.Clear();
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formRegister register = new formRegister();
            register.Show();
            this.Hide();
        }
    }
}
