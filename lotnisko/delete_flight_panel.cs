﻿using MySql.Data.MySqlClient;
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
    public partial class delete_flight_panel : Form
    {
        public delete_flight_panel()
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
                    using (MySqlCommand cmd = new MySqlCommand($"DELETE FROM flights WHERE id = '{numeric_pick.Value}'",conn))
                    {
                        cmd.ExecuteReader();
                    }
                }
            }catch(MySqlException ex) { MessageBox.Show(ex.Message); }
        }
    }
}
