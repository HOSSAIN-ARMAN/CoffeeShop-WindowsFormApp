﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTestApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ItemInfoButton_Click(object sender, EventArgs e)
        {
            ItemUi itemUi = new ItemUi();
            itemUi.Show();
        }

        private void CustomerInfoButton_Click(object sender, EventArgs e)
        {
            CustomerInfoForm customerInfoForm = new CustomerInfoForm();
            customerInfoForm.Show();
        }
    }
}
