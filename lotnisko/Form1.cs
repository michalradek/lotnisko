using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Text;

namespace lotnisko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_void();
        }

        private void login_void()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root; database = lotnisko"))
                {
                    conn.Open();
                    using (SHA256 mySHA = SHA256.Create())
                    {
                        byte[] hashed_pass = mySHA.ComputeHash(Encoding.UTF8.GetBytes(password_textbox.Text));
                        string password = BitConverter.ToString(hashed_pass);
                        password = password.Replace("-", "");
                        password = password.ToLower();
                        using (MySqlCommand command = new MySqlCommand($"SELECT id FROM login WHERE login = '{login_textbox.Text}' AND password= '{password}'", conn))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {

                                    this.Hide();
                                    main_window main_Window = new main_window(reader.GetString(0));
                                    main_Window.ShowDialog();
                                    this.Close();

                                }
                                else
                                {
                                    MessageBox.Show("There is not any user with this login or password.");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}