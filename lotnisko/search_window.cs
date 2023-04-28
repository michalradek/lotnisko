using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotnisko
{
    public partial class search_window : Form
    {
        private string? cmdd;
        public search_window()
        {
            InitializeComponent();
        }

        private async void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root; database = lotnisko"))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    if (from_radio.Checked)
                        cmdd = $"SELECT * FROM flights WHERE from_where LIKE '{search_textbox.Text}'";
                    else if (to_radio.Checked)
                        cmdd = $"SELECT * FROM flights WHERE to_where LIKE '{search_textbox.Text}'";
                    else if (time_radio.Checked)
                        cmdd = $"SELECT * FROM flights WHERE time = '{search_textbox.Text}'";
                    else if (monthCalendar1.SelectionStart.Day != monthCalendar1.SelectionStart.Day + 1)
                        cmdd = $"SELECT * FROM flights WHERE date = '{monthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd").Replace(".", "-")}'";
                    using (MySqlCommand cmd = new MySqlCommand(cmdd, conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                dt.Load(reader);
                                search_data_grid_view.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void MonthCalendar1_DateChanged(object? sender, DateRangeEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
