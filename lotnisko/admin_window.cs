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
    public partial class admin_window : Form
    {
        public admin_window()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            add_flight_panel addpanel = new add_flight_panel();
            addpanel.Show();
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            delete_flight_panel deletepanel = new delete_flight_panel();
            deletepanel.Show();
        }
    }
}
