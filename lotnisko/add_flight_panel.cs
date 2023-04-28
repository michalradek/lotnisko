using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotnisko
{
    public partial class add_flight_panel : Form
    {
        public add_flight_panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root; database = lotnisko"))
                {
                    conn.Open();
                    DateTime date = DateTime.Parse(date_textbox.Text);
                    string formatted_date = date.ToString("yyyy-MM-dd");
                    using (MySqlCommand cmd = new MySqlCommand($"INSERT INTO `flights` (`id`, `from_where`, `to_where`, `date`, `time`) VALUES (NULL, '{from_textbox.Text}', '{to_textbox.Text}', '{formatted_date}', '{time_textbox.Text}');", conn))
                    {
                        cmd.ExecuteReader();
                    }
                }
            }
            catch (MySqlException ex) { MessageBox.Show(ex.Message); }
        }
    }
}
