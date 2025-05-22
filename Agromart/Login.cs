using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using Microsoft.VisualBasic.Logging;
using Npgsql;


namespace Agromart
{
    public partial class Login : Form
    {
        private NpgsqlConnection conn;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validasilogin(string username, string password)
        {
            string connDb = "Host=localhost;Username=postgres;Password=1;Database=Agromart";
            string query = "SELECT user_id FROM users WHERE username = @username AND password = @password";

            using (NpgsqlConnection conn = new NpgsqlConnection(connDb))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi Error", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
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

            if (validasilogin(username, password))
            {
                MessageBox.Show("Login Berhasil", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                DashboarUser dashboarU = new DashboarUser();
                dashboarU.Show();
            }
            else
            {
                MessageBox.Show("Login Gagal", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
