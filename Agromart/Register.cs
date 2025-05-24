using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Agromart
{
    public partial class formRegister : Form
    {
        public string db = "Host=localhost;Username=postgres;Password=1;Database=Agromart";
        public formRegister()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTelepon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = textUser.Text;
            string password = textPass.Text;
            string no_telepon = textTelepon.Text;
            string queryRegis = ("INSERT INTO users (username, password,no_telepon) VALUES (@username,@password,@no_telepon)");
            string queryCheck = ("SELECT COUNT(*) FROM users WHERE username = @username");

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(no_telepon))
            {
                textUser.Clear();
                textPass.Clear();
                textTelepon.Clear(); 
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show($"Username tidak boleh kosong");
                    return;
                }else if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show($"Password tidak boleh kosong");
                    return;
                }else if (string.IsNullOrEmpty(no_telepon))
                {
                    MessageBox.Show($"Nomor Telepon tidak boleh kosong");
                    return;
                }
            }

            using (NpgsqlConnection conn = new NpgsqlConnection(db))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand check = new NpgsqlCommand(queryCheck, conn))
                    {
                        check.Parameters.AddWithValue("@username", username);
                        int checkUser = Convert.ToInt32(check.ExecuteScalar());

                        if (checkUser > 0)
                        {
                            textUser.Clear();
                            textPass.Clear();
                            textTelepon.Clear();
                            MessageBox.Show("Username sudah digunakan, gunakan username lain!");
                            return;
                        }
                    }
                    using (NpgsqlCommand cmd = new NpgsqlCommand(queryRegis, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@no_telepon", no_telepon);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Registrasi Berhasil", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login login = new Login();
                            login.Show();
                            this.Hide();

                        }
                        else
                        {
                            {
                                MessageBox.Show("Registrasi gagal");
                                textUser.Clear();
                                textPass.Clear();
                                textTelepon.Clear();
                            }
                        }
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
