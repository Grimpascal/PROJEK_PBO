using System.Drawing.Text;
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
            string query = "Host=localhost;Username=postgres;Password=1;Database=Agromart";
            using (NpgsqlConnection conn = new NpgsqlConnection())
                try
                {
                    conn.Open();
                } catch
                {
                    MessageBox.Show("Ada kesalahan saat Login","Notifikasi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
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
    }
}
