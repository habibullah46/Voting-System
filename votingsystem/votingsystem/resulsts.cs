﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace votingsystem
{
    public partial class resulsts : Form
    {
        public resulsts()
        {
            InitializeComponent();
        }

        private void resulsts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voting_systemDataSet10.votingform' table. You can move, or remove it, as needed.
            this.votingformTableAdapter.Fill(this.voting_systemDataSet10.votingform);

        }
    }
}
