﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2Parcial
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            TicketsForm ticketsForm = new TicketsForm();
            ticketsForm.MdiParent = this;
            ticketsForm.Show();
        }
    }
}
