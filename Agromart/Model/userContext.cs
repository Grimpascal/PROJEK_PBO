using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Agromart.Model
{
    internal class userContext
    {
        public class UserContext
        {
            private string conn = "Host=localhost;Username=postgres;Password=1;Database=Agromart";
        }
        public bool validasilogin(string username, string password)
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
    }
}
