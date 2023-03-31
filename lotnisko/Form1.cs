using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;

namespace lotnisko
{
    public partial class Form1 : Form
    {
        string login = "";
        string password = "";
        string connstring = "datasource=127.0.0.1;port=3306;username=root; database = lotnisko";
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        string query = "";
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
            login = login_textbox.Text;
            password = password_textbox.Text;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connstring))
                {
                    conn.Open();
                    query = $"SELECT login,password FROM login WHERE login = '{login}' AND password= '{password}'";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (reader = command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                this.Hide();
                                main_window main_Window = new main_window();
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
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}


/*
 

            MySqlConnection conn = new MySqlConnection(connstring);
            string query = "select * from logowanie";
            MySqlCommand command = new MySqlCommand(query, conn);   

            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        MessageBox.Show(reader.GetString(0));
                    }
                }
            }catch(Exception ex){ Console.WriteLine(ex); }
 
 */