﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class GatewayGUI : Form
    {
        public GatewayGUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBoxFloors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected override void OnClosed(EventArgs e)
        {
            DialogResult rs2 = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs2 == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
                System.Environment.Exit(1);
            }
        }

    }
}
