using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lotnisko
{
    public partial class main_window : Form
    {
        int perm;
        public main_window(string id)
        {
            perm = Int32.Parse(id);
            InitializeComponent();
            timer1.Start();
            if (perm != 1)
                admin_button.Enabled = false;
        }
        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root; database = lotnisko"))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM flights", conn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                            {
                                dt.Load(reader);
                                DataGrid.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search_window swindow = new search_window();
            swindow.Show();
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            admin_window awindow = new admin_window();
            awindow.Show();
        }

    }
}
