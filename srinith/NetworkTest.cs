﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srinith
{
    public partial class NetworkTest : Form
    {
        public NetworkTest()
        {
            InitializeComponent();
        }

        private void NetworkTest_Load(object sender, EventArgs e)
        {
            // Set UI elements
            btnPing.Enabled = false;
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {
            if (txtHost.Text.Equals(""))
            {
                btnPing.Enabled = false;
            }
            else
            {
                btnPing.Enabled = true;
            }
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            if (txtHost.Text.Equals(""))
            {
                MessageBox.Show("Ping needs a host or IP Address.");
                return;
            }


        }
    }
}
